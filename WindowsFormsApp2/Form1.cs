using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using ZXing;
using System.Net.Sockets;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        int AvailableSeats = 0; //座位剩餘數量(特定場次

        //照片根目錄Application.StartupPath→bin/debug/image
        string img_dir = Path.Combine(Application.StartupPath, "image");
        
        // 初始化字典
        Dictionary<string, MoviePoster> moviePosters = new Dictionary<string, MoviePoster>();  //電影對應它的展示海報              
        Dictionary<string, List<int>> MovieShowtimesID = new Dictionary<string, List<int>>(); //電影對應它的場次ID



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //顏色..
            //顏色-選電影
            panel_nav.BackColor = ColorTranslator.FromHtml("#2F3645");  //左側導覽列
            panel_top.BackColor = ColorTranslator.FromHtml("#939185");  //右側上方資訊(較窄)
            
            btn_toChooseTicket.BackColor = ColorTranslator.FromHtml("#939185"); //右側下方資訊(較窄)
            

            //顏色-選票種
            panel_top2.BackColor = ColorTranslator.FromHtml("#939185"); //上方資訊區
            btn_toChooseSeat.BackColor = ColorTranslator.FromHtml("#939185");  //前往下一步
            btn_backToChooseMovie.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#939185"); //回到上一步

            //顏色-選座位
            panel_top3.BackColor = ColorTranslator.FromHtml("#939185");
            btn_toConfirm.BackColor = ColorTranslator.FromHtml("#939185");  //前往下一步
            btn_backToChooseTic.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#939185"); //回到上一步
            lbl_selectedColor.BackColor = ColorTranslator.FromHtml("#789461");
            lbl_noColor.BackColor = ColorTranslator.FromHtml("#ECB159");


            //顏色-會員驗證與確認
            lbl_top4.BackColor = ColorTranslator.FromHtml("#939185");
            btn_backtoChooseSeat.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#939185");

            movie_area.FlowDirection = FlowDirection.LeftToRight;
            movie_area.WrapContents = true; // 自動換行
            movie_area.AutoScroll = true;   // 自動滾動
                                            //以上不確定需不需要


            load_date();  //載入日期選項
            cbox_date.SelectedIndex = 0;
            GlobalVar.SelectedDate = cbox_date.SelectedItem.ToString();

            load_movie(); //載入電影選項          
        }

        //function:載入可選擇日期
        private void load_date()
        {
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                conn.Open();  //打開資料庫
                //創建命令--讀取電影撥放日期
                SqlCommand cmd_date = new SqlCommand();
                cmd_date.Connection = conn;
                /*cmd_date.CommandText = "SELECT DISTINCT ShowDate FROM show_time";*/  //原本的
                cmd_date.CommandText = "SELECT DISTINCT ShowDate FROM show_time where DATEPART(MONTH, showDate) >= 8"; //後改的
                SqlDataReader reader_date = cmd_date.ExecuteReader();
                while (reader_date.Read())
                {
                    cbox_date.Items.Add($"{reader_date.GetValue(0):yyyy-MM-dd}"); //將日期選項添加到下拉式清單
                }
            }
        }

        //function載入電影
        private void load_movie()  //改成一次載入全部場次
        {
            movie_area.Controls.Clear();
            moviePosters.Clear();
            MovieShowtimesID.Clear();

            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                conn.Open();

                // 讀取電影和場次
                SqlCommand cmd_movieDetail = new SqlCommand(
                    "SELECT m.title, m.Duration, m.mimage, m.movieRating , s.showTimeID, s.showTime " +
                    "FROM movie m " +
                    "JOIN show_time s ON m.movieID = s.movieID " +
                    "WHERE s.showDate = @ShowDate", conn);
                cmd_movieDetail.Parameters.AddWithValue("@ShowDate", GlobalVar.SelectedDate);

                SqlDataReader reader_movieDetail = cmd_movieDetail.ExecuteReader();

                while (reader_movieDetail.Read())
                {
                    string title = reader_movieDetail["title"].ToString();

                    // 如果MoviePoster已存在，只添加場次
                    if ((moviePosters.ContainsKey(title)) && (MovieShowtimesID.ContainsKey(title)))
                    {
                        moviePosters[title].cbox_showTime.Items.Add(((TimeSpan)reader_movieDetail["showTime"]).ToString(@"hh\:mm"));
                        // 添加場次id到現有的列表中
                        MovieShowtimesID[title].Add((int)reader_movieDetail["showTimeID"]);
                        //Console.WriteLine(string.Join(", ", MovieShowtimesID[title]));
                    }
                    else
                    {
                        // 創建新的MoviePoster
                        MoviePoster poster = new MoviePoster
                        {
                            //Margin = new Padding(5)
                        };
                        //設置poster屬性
                        poster.lbl_title.Text = title; //片名
                        poster.lbl_MovieLength.Text = $"片長：{reader_movieDetail["Duration"]}分"; //片長
                        //電影照片設置
                        string img_name = reader_movieDetail["mimage"].ToString(); //電影照片檔案名稱讀取
                        string full_imgPath = Path.Combine(img_dir, img_name);
                        System.IO.FileStream fs = System.IO.File.OpenRead(full_imgPath);
                        poster.pbox_movie.Image = Image.FromStream(fs);
                        fs.Close();
                        //電影分級icon設置
                        string movieRatingIcon = reader_movieDetail["movieRating"].ToString();
                        string ratingIconPath = Path.Combine(img_dir, movieRatingIcon) + ".png"; 

                        System.IO.FileStream fs2 = System.IO.File.OpenRead(ratingIconPath);
                        poster.Pbox_movieRating.Image = Image.FromStream(fs2);
                        fs.Close();



                        //添加新的場次列表
                        List<int> showtimeIDForMovie = new List<int>();

                        poster.cbox_showTime.Items.Add(((TimeSpan)reader_movieDetail["showTime"]).ToString(@"hh\:mm")); //添加場次到combobox
                        poster.cbox_showTime.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged); //當選擇的場次變動時的事件
                        poster.cbox_showTime.Tag = title;

                        poster.panel_movie.MouseHover += new EventHandler(movie_choose);  //選擇影片的hover效果

                        movie_area.Controls.Add(poster); //將電影海報添加到電影片單區域

                        showtimeIDForMovie.Add((int)(reader_movieDetail["showTimeID"]));

                        moviePosters[title] = poster;
                        MovieShowtimesID[title] = showtimeIDForMovie;

                    }
                }
            }
        }

        //建立事件:滑鼠移到某電影區塊時(不確定要不要)
        private void movie_choose(object sender, EventArgs e)
        {
            //Panel panel_movie = sender as Panel;
            //panel_movie.BackColor = Color.LightBlue;
        }

        //當特定電影場次的combo box被選取
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox selectedComboBox = sender as ComboBox;

            if (selectedComboBox.SelectedIndex > 0)
            {
                GlobalVar.SelectedMovie = (string)selectedComboBox.Tag;
                GlobalVar.SelectedTime = selectedComboBox.SelectedItem.ToString();
                GlobalVar.selectedTimeID = MovieShowtimesID[GlobalVar.SelectedMovie][selectedComboBox.SelectedIndex - 1]; //抓出showtimeid
            }

            // 遍歷 movie_area 中的所有控件
            foreach (Control control in movie_area.Controls)
            {
                if (control is MoviePoster)
                {
                    MoviePoster poster = control as MoviePoster;
                    if (poster.cbox_showTime != selectedComboBox)
                    {
                        // 暫時移除事件處理器，避免重置時觸發事件
                        poster.cbox_showTime.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
                        // 將其他 ComboBox 的選擇設為初始值
                        poster.cbox_showTime.SelectedIndex = 0;
                        // 重置後重新添加事件處理器
                        poster.cbox_showTime.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
                    }

                }
            }
            //確認有成功抓出選取電影、場次時間、場次id
            Console.WriteLine($"電影:{GlobalVar.SelectedMovie} showtimeID:{GlobalVar.selectedTimeID} 場次時間:{GlobalVar.SelectedTime}");
        }

        //當選擇日期改變
        private void cbox_date_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //選擇日期改變
            GlobalVar.SelectedDate = cbox_date.SelectedItem.ToString();
            load_movie(); //載入電影    
        }


        //function:計算價格(選擇票種階段，尚未考慮是否為會員) ，此fcuntion要放在當改變購買數量的事件

        private void price_calulate()
        {
            int total_tickets = 0; //購買張數
            int single_price = 0; //單個方案總價
            double total_price = 0; //費用總計(不包含折扣的)

            //全票方案小計
            if (cbox_fullQ.SelectedIndex > 0)
            {
                int ticketNum = Convert.ToInt32(cbox_fullQ.SelectedItem);
                if (total_tickets + ticketNum > AvailableSeats)
                {
                    cbox_fullQ.SelectedIndex = 0;
                    MessageBox.Show("購買張數超過剩餘座位數!", "提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    single_price = ticketNum * 280;
                    lbl_fullPriceTotal.Text = $"${single_price}";
                    total_price += single_price;
                    total_tickets += ticketNum;
                }
            }
            else
            {
                lbl_fullPriceTotal.Text = $"$0";
            }

            // 學生票方案小計
            if (cbox_studentQ.SelectedIndex > 0)
            {
                int ticketNum = Convert.ToInt32(cbox_studentQ.SelectedItem);
                if (total_tickets + ticketNum > AvailableSeats)
                {
                    cbox_studentQ.SelectedIndex = 0;
                    MessageBox.Show("購買張數超過剩餘座位數!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    single_price = ticketNum * 240;
                    lbl_studentPriceTotal.Text = $"${single_price}";
                    total_price += single_price;
                    total_tickets += ticketNum;
                }
            }
            else
            {
                lbl_studentPriceTotal.Text = $"$0";
            }

            // 爆米花套票方案小計
            if (cbox_popcornQ.SelectedIndex > 0)
            {
                int ticketNum = Convert.ToInt32(cbox_popcornQ.SelectedItem);
                if (total_tickets + ticketNum > AvailableSeats)
                {
                    cbox_popcornQ.SelectedIndex = 0;
                    MessageBox.Show("購買張數超過剩餘座位數!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    single_price = ticketNum * 380;
                    lbl_popcornPriceTotal.Text = $"${single_price}";
                    total_price += single_price;
                    total_tickets += ticketNum;
                }
            }
            else
            {
                lbl_popcornPriceTotal.Text = $"$0";
            }

            // 雙人爆米花套票方案小計
            if (cbox_popcorn2Q.SelectedIndex > 0)
            {
                int ticketNum = Convert.ToInt32(cbox_popcorn2Q.SelectedItem) * 2;
                if (total_tickets + ticketNum > AvailableSeats)
                {
                    cbox_popcorn2Q.SelectedIndex = 0;
                    MessageBox.Show("購買張數超過剩餘座位數!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    single_price = Convert.ToInt32(cbox_popcorn2Q.SelectedItem) * 750; // 雙人票的單價計算
                    lbl_popcorn2PriceTotal.Text = $"${single_price}";
                    total_price += single_price;
                    total_tickets += ticketNum;
                }
            }
            else
            {
                lbl_popcorn2PriceTotal.Text = $"$0";
            }

            // 雙人吉拿套票方案小計
            if (cbox_stickQ.SelectedIndex > 0)
            {
                int ticketNum = Convert.ToInt32(cbox_stickQ.SelectedItem) * 2;
                if (total_tickets + ticketNum > AvailableSeats)
                {
                    cbox_stickQ.SelectedIndex = 0;
                    MessageBox.Show("購買張數超過剩餘座位數!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    single_price = Convert.ToInt32(cbox_stickQ.SelectedItem) * 800;
                    lbl_stickPriceTotal.Text = $"${single_price}";
                    total_price += single_price;
                    total_tickets += ticketNum;
                }
            }
            else
            {
                lbl_stickPriceTotal.Text = $"$0";
            }
            lbl_totalPrice.Text = $"總計 ${total_price}";
            GlobalVar.selectedTicketNum = total_tickets;
            Console.WriteLine(GlobalVar.selectedTicketNum);
            GlobalVar.priceBeforeDiscount = total_price;
            GlobalVar.finalPrice = total_price;


        }

        //function:計算特定場次剩餘座位數，並以此為依據建立購票數量
        private int  GetAvailableSeats(int showTimeID)
        {
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                conn.Open();  //打開資料庫
                //創建命令--讀取場次剩餘座位數
                SqlCommand cmd_AvailableSeats = new SqlCommand();
                cmd_AvailableSeats.Connection = conn;

                // 添加參數
                cmd_AvailableSeats.Parameters.AddWithValue("@ShowTimeID", showTimeID);
                //使用參數查詢
                cmd_AvailableSeats.CommandText = "SELECT count(se.isbooked) "+
                    "FROM show_time s JOIN seat se ON s.showtimeID = se.showtimeID " +
                    "WHERE s.ShowTimeID = @ShowTimeID AND se.isbooked = 'false'";

                SqlDataReader reader_AvailableSeats = cmd_AvailableSeats.ExecuteReader();

                reader_AvailableSeats.Read();
                //讀取選取場次剩餘座位數
                AvailableSeats = Convert.ToInt32(reader_AvailableSeats.GetValue(0));
                return AvailableSeats;
            }
        }


        //function:顯示場次座位(按鈕)，及更新場次座位資訊(包含影廳資訊、座位狀態等)
        private void display_seat(int showTimeID)
        {

            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                
                conn.Open();  //打開資料庫

                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string query_seatCount = "Select count(*) From seat where showtimeID = @showtimeID";
                    SqlCommand cmd_seatCount = new SqlCommand(query_seatCount, conn, transaction);
                    cmd_seatCount.Parameters.AddWithValue("@showtimeID", showTimeID);
                    int seatCount = (int)cmd_seatCount.ExecuteScalar();
                    Console.WriteLine($"座位數:{seatCount}");

                    //好像不用寫那麼長..
                    string query_searchSeat = "SELECT s.showTimeID, t.theaterID, t.TheaterName, se.seatID, se.seatNumber, se.IsBooked " +
                        "FROM show_time s JOIN theater t ON s.theaterID = t.theaterID JOIN seat se ON s.showtimeID = se.showtimeID " +
                        "WHERE s.showTimeID = @ShowTimeID";
                    SqlCommand cmd_displaySeat = new SqlCommand(query_searchSeat, conn, transaction);
                    // 添加參數
                    cmd_displaySeat.Parameters.AddWithValue("@ShowTimeID", showTimeID);
                    //使用參數查詢

                    SqlDataReader reader_displaySeat = cmd_displaySeat.ExecuteReader();

                    int count = 0; //座位數45用
                    int row = 1; //座位數45用
                    if (reader_displaySeat.Read())
                    {
                        // 讀取場次影廳名稱
                        GlobalVar.selectedTheaterName = reader_displaySeat.GetValue(2).ToString();

                        //int seatPositionX = ClientSize.Width / 3 - 15; //座位初始位置(x軸) 
                        //int seatPositionY = ClientSize.Height / 3; //座位初始位置(y軸)

                        int seatPositionX = 0;
                        int seatPositionY = ClientSize.Height / 3;

                        //設定座位初始位置
                        if (seatCount == 50)  
                        {
                            seatPositionX = ClientSize.Width / 6;   
                        }
                        else if(seatCount == 45) //位置漸增
                        {
                            seatPositionX = (int)(ClientSize.Width / 3.5);
                        }


                        // 產生座位按鈕
                        do
                        {
                            // 創建座位按鈕及設定屬性
                            Button seat = new Button();
                            seat.Name = $"btn_seat{reader_displaySeat.GetValue(3)}"; //命名為seatID
                            seat.Tag = reader_displaySeat.GetValue(3).ToString(); //★每個按鈕的tag即為其seatid
                            seat.Size = new Size(45, 45);  //座位大小
                            seat.Location = new Point(seatPositionX, seatPositionY); //座標位置                       
                            seat.Font = new Font("微軟正黑體", 12);
                            seat.Text = $"{reader_displaySeat.GetValue(4)}";
                            seat.TextAlign = ContentAlignment.MiddleCenter;
                            tabPage_seat.Controls.Add(seat);  //添加到選取座位頁籤

                            //處理顏色(若已被預訂，要顯示黃色按鈕
                            if (reader_displaySeat.GetValue(5).ToString() == "true")
                            {
                                seat.BackColor = ColorTranslator.FromHtml("#ECB159");
                                seat.Cursor = Cursors.No;
                            }
                            else
                            {
                                seat.BackColor = Color.White;
                                seat.Cursor = Cursors.Hand;  //游標(可點選游標)
                            }
                            seat.ForeColor = Color.Black;

                            if (seatCount == 50)
                            {
                                if (seatPositionX < ClientSize.Width / 6 + 483)   //47*9 + 60(後加7個座位+2個空位)
                                {   //如果目前座標為第二個位置或
                                    if (seatPositionX == ClientSize.Width / 6 + 47 || seatPositionX == ClientSize.Width / 6 + 47 * 6 + 30) {
                                        seatPositionX += 47 + 30; //30為空位
                                    }
                                    else
                                    {
                                        seatPositionX += 47;
                                    }
                                }
                                else
                                {
                                    seatPositionX = ClientSize.Width / 6;
                                    if (seatPositionY == ClientSize.Height / 3 + 47)
                                    {
                                        seatPositionY += 47 + 30; //30為空位
                                    }
                                    else
                                    {
                                        seatPositionY += 47;
                                    }
                                }
                            } else if (seatCount == 45)
                            {
                                if (count == 4 || count == 11 || count == 20 || count == 31)
                                {
                                    seatPositionY += 47;                                   
                                    seatPositionX = (int)(ClientSize.Width / 3.5) - 47 * row;
                                    row += 1;
                                }
                                else
                                {
                                    if (seatPositionX == (int)(ClientSize.Width / 3.5) + 47)
                                    {
                                        seatPositionX += 47 + 25;//25為空位
                                    }
                                    else
                                    {
                                        seatPositionX += 47;
                                    }
                                }
                                count++;
                            }
                            

                            seat.Click += new EventHandler(seat_choose);  //把seat_choose事件，添加到seat的click事件
                        }
                        while (reader_displaySeat.Read());
                        reader_displaySeat.Close();
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("An error occurred: " + ex.Message);
                }                    
                
            }
        }

        //function:選擇座位，立即改變座位狀態(改為被預訂)-先暫時把改為被預訂與不被預訂分開寫
        private void changeSeatStatus_true(int seatID)
        {
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                string query = "UPDATE seat SET isbooked = 'true' WHERE seatID = @seatID";
                
                conn.Open();  //打開資料庫
                //創建命令--讀取場次剩餘座位數
                SqlCommand cmd_updateSeatStatus = new SqlCommand(query, conn);

                cmd_updateSeatStatus.Parameters.AddWithValue("@seatID", seatID);
                //使用參數查詢
                cmd_updateSeatStatus.ExecuteNonQuery();
            }
        }

        //function:選擇座位，立即改變座位狀態(改為不被預訂)-先暫時把改為被預訂與不被預訂分開寫
        private void changeSeatStatus_false(int seatID)
        {
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                string query = "UPDATE seat SET isbooked = 'false' WHERE seatID = @seatID";

                conn.Open();  //打開資料庫
                //創建命令--讀取場次剩餘座位數
                SqlCommand cmd_updateSeatStatus = new SqlCommand(query, conn);

                cmd_updateSeatStatus.Parameters.AddWithValue("@seatID", seatID);
                //使用參數查詢
                cmd_updateSeatStatus.ExecuteNonQuery();
            }
        }



        //前往選取票種
        private void btn_toChooseTicket_Click(object sender, EventArgs e)
        {
            //預設值皆為0
            cbox_fullQ.SelectedIndex = 0;
            cbox_studentQ.SelectedIndex = 0;
            cbox_popcornQ.SelectedIndex = 0;
            cbox_popcorn2Q.SelectedIndex = 0;
            cbox_stickQ.SelectedIndex = 0;
            //上方顯示選取電影資訊
            lbl_movie.Text = GlobalVar.SelectedMovie;
            lbl_time.Text = $"開演時間：{GlobalVar.SelectedDate}  {GlobalVar.SelectedTime}";
            lbl_seatCount.Text = $"剩餘座位數：{GetAvailableSeats(GlobalVar.selectedTimeID)}";

            tabControl1.SelectedTab = tabPage_price; //切換到選取票種方案頁面
        }

        //事件:當票種方案數量改變
        private void cbox_fullQ_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            price_calulate();
        }

        private void cbox_studentQ_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            price_calulate();
        }

        private void cbox_popcornQ_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            price_calulate();
        }

        private void cbox_popcorn2Q_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            price_calulate();
        }

        private void cbox_stickQ_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            price_calulate();
        }



        //-----------------------------------
        //事件:選完購票方案欲前往選位
        private void btn_toChooseSeat_Click(object sender, EventArgs e)
        {
            GlobalVar.selectedTicketType.Clear();
            GlobalVar.selectedTicketCount.Clear();
            //
            if (cbox_fullQ.SelectedIndex > 0)  //購買張數至少1張
            {
                GlobalVar.selectedTicketType.Add("全票");
                GlobalVar.selectedTicketCount.Add(Convert.ToInt32(cbox_fullQ.SelectedItem));
            }
            if (cbox_studentQ.SelectedIndex > 0)
            {
                GlobalVar.selectedTicketType.Add("學生票");
                GlobalVar.selectedTicketCount.Add(Convert.ToInt32(cbox_studentQ.SelectedItem));
            }
            if (cbox_popcornQ.SelectedIndex > 0)
            {
                GlobalVar.selectedTicketType.Add("爆米花套票");
                GlobalVar.selectedTicketCount.Add(Convert.ToInt32(cbox_popcornQ.SelectedItem));
            }
            if (cbox_popcorn2Q.SelectedIndex > 0)
            {
                GlobalVar.selectedTicketType.Add("雙人爆米花套票");
                GlobalVar.selectedTicketCount.Add(Convert.ToInt32(cbox_popcorn2Q.SelectedItem));
            }
            if (cbox_stickQ.SelectedIndex > 0)
            {
                GlobalVar.selectedTicketType.Add("雙人吉拿套票");
                GlobalVar.selectedTicketCount.Add(Convert.ToInt32(cbox_stickQ.SelectedItem));
            }

            //產出相對應座位
            display_seat(GlobalVar.selectedTimeID);

            //頁面上方資訊
            lbl_movie2.Text = GlobalVar.SelectedMovie;
            lbl_time2.Text = $"開演時間：{GlobalVar.SelectedDate}  {GlobalVar.SelectedTime}";
            lbl_ticketNum.Text = $"購票張數：{GlobalVar.selectedTicketNum}";
            lbl_theaterName.Text = $"{GlobalVar.selectedTheaterName} 廳";
            tabControl1.SelectedTab = tabPage_seat; //跳轉到選位頁面
        }



        //事件:當選擇座位時
        private void seat_choose(object sender, EventArgs e)
        {
            
            Button chooseSeat = (Button)sender;


            // 檢查是否超過最大票數
            if (GlobalVar.selectedSeatNum.Count >= GlobalVar.selectedTicketNum && chooseSeat.BackColor != ColorTranslator.FromHtml("#789461") && chooseSeat.BackColor != ColorTranslator.FromHtml("#ECB159"))
            {
                MessageBox.Show("已超過購票張數，請先取消已選取座位", "提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            

            if (chooseSeat.BackColor == ColorTranslator.FromHtml("#789461"))  // 若已被選取
            {
                // 取消選取
                chooseSeat.BackColor = Color.White;　
                chooseSeat.ForeColor = Color.Black;
                //從選取座位清單移除                
                GlobalVar.selectedSeatID.Remove(Convert.ToInt32(chooseSeat.Tag)); 
                GlobalVar.selectedSeatNum.Remove(Convert.ToInt32(chooseSeat.Text));
                changeSeatStatus_false(Convert.ToInt32(chooseSeat.Tag)); //改變資料庫座位狀態

            }
            else if (chooseSeat.BackColor == ColorTranslator.FromHtml("#ECB159"))
            {
                return;  // 直接返回，等同於不能點擊
            }
            else
            {
                // 若還未被選取，選取後則變綠色，並加到選位清單
                chooseSeat.BackColor = ColorTranslator.FromHtml("#789461");
                chooseSeat.ForeColor = Color.White;

                GlobalVar.selectedSeatID.Add(Convert.ToInt32(chooseSeat.Tag)); //把選的座位id加到選位清單
                GlobalVar.selectedSeatNum.Add(Convert.ToInt32(chooseSeat.Text)); //選的座位號碼加到選位清單
                changeSeatStatus_true(Convert.ToInt32(chooseSeat.Tag)); //改變資料庫座位狀態
            }
            for(int i = 0; i < GlobalVar.selectedSeatID.Count; i++)
            {
                Console.WriteLine(GlobalVar.selectedSeatID[i]);
            }
        }

        //事件:選完座位，前往驗證身分，確認訂票資訊
        private void btn_toConfirm_Click_1(object sender, EventArgs e)
        {
            lbox_bookingInfo.Items.Clear();  //清空購物車
            //加載訂單資訊(考慮寫到一個方法)
            lbox_bookingInfo.Items.Add(GlobalVar.SelectedMovie);
            lbox_bookingInfo.Items.Add($"場次：{GlobalVar.SelectedDate} {GlobalVar.SelectedTime}");

            lbox_bookingInfo.Items.Add("------------------------------------------------------------------------------------------");
            string eachTicket = "";

            for(int i =0; i < GlobalVar.selectedTicketType.Count(); i++)
            {
                eachTicket += $"{GlobalVar.selectedTicketType[i]} x {GlobalVar.selectedTicketCount[i]}, ";
            }

            eachTicket = eachTicket.Remove(eachTicket.Length - 2);
            lbox_bookingInfo.Items.Add($"票種：{eachTicket}");
            lbox_bookingInfo.Items.Add($"位置：{GlobalVar.selectedTheaterName} 廳 ");
            string seatNum = "";
            GlobalVar.selectedSeatNum.Sort();  //選擇的座位號碼進行排序
            foreach (int seat in GlobalVar.selectedSeatNum)
            {
                seatNum += $"{seat}號,  ";
            }
            seatNum = seatNum.Remove(seatNum.Length - 3);  //去掉最後面多餘的逗號及空白
            lbox_bookingInfo.Items.Add($"座位：{seatNum}");

            lbox_bookingInfo.Items.Add("");
            lbox_bookingInfo.Items.Add("");
            lbox_bookingInfo.Items.Add("會員卡號");
            lbl_priceNotDis.Text = $"小計: {GlobalVar.priceBeforeDiscount} 元";
            lbl_finalPrice.Text = $"總計：{GlobalVar.priceBeforeDiscount} 元";


            tabControl1.SelectedTab = tabPage_confirm; //轉跳到會員驗證及確認訂票資訊頁面
        }




        
        //事件:輸入卡號後，點擊查詢(驗證會員身分、顯示紅利資訊)
        double maxDiscount = 0;
        private void btn_searchMember_Click(object sender, EventArgs e)
        {
            if (txt_member.Text != "")
            {
                //會先執行輸入格式驗證，再進行查詢
                if (Member.IsValidMember(txt_member.Text))
                {
                    //如果非會員則不會執行下方程式碼
                    lbl_memberName.Text = Member.memberName;
                    maxDiscount = Math.Floor(Member.bonusPoint * 0.3);
                    lbl_memberBonus.Text = $"紅利點數：{Member.bonusPoint}點";
                    txt_useBonus.Text = $"{maxDiscount}";
                    lbl_discount.Text = $"- 會員9折優惠 {GlobalVar.priceBeforeDiscount * 0.1} 元";
                    panel_memberInfo.Visible = true;
                    panel_discount.Visible = true;
                    GlobalVar.memberID = txt_member.Text; //把輸入會員卡號存在全域變數(之後要儲存到訂單的)
                    lbox_bookingInfo.Items[8] = "會員" + GlobalVar.memberID;

                }
                else  //會員已到期或是查無此人    //後續還有一些BUG要處理，一開始輸入對，但是要改後如果查無此人，金額會錯
                {
                    panel_memberInfo.Visible = false;
                    maxDiscount = 0;
                    panel_discount.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("請輸入會員卡號");
            }
        }


        //事件:改變折抵紅利，折抵金額，及總計需變動
        private void txt_useBonus_TextChanged_1(object sender, EventArgs e)
        {
            int usebonus = 0; //折抵的紅利
            if (!int.TryParse(txt_useBonus.Text, out usebonus))
            {
                usebonus = 0; // 若轉換失敗(如空值)，默認為0(這行其實不用打，已經預設為0了)    
            }
            if (usebonus > maxDiscount)
            {
                MessageBox.Show("已超過折抵上限", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_useBonus.Text = $"{maxDiscount}";  //輸入超過，把值從設為折抵上限
                return;
            }

            //試圖將數入內容轉為字串

            lbl_useBonus.Text = $"- 紅利折抵 {usebonus}元";
            GlobalVar.finalPrice = GlobalVar.priceBeforeDiscount - GlobalVar.priceBeforeDiscount * 0.1 - usebonus;
            lbl_finalPrice.Text = $"總計：{GlobalVar.finalPrice} 元";
        }


        //事件:按下加入會員按鈕:生成會員ID，及會員註冊
        private void btn_signUp_Click_1(object sender, EventArgs e)
        {
            panel_discount.Visible = false;  //已經是會員的會員訊息隱藏
            panel_memberInfo.Visible = false; //已經是會員的會員資訊隱藏
            txt_member.Text = "";  //輸入卡號欄清空
            txt_useBonus.Text = ""; //折扣的值也要清空
            GlobalVar.useBonusPoint = 0;  //沒有使用紅利點數(剛加入)
            string newMemberID = Member.GenerateMemberID();
            Member.AddNewMemberFromSaleSys(newMemberID);
            lbl_memberFee.Text = "+ 加入會員工本費 100元";
            lbl_memberDiscount.Text = $"- 會員9折優惠 {GlobalVar.priceBeforeDiscount * 0.1} 元";
            
            panel_NewMemberDiscount.Visible = true;
            GlobalVar.finalPrice = GlobalVar.priceBeforeDiscount - GlobalVar.priceBeforeDiscount * 0.1 + 100; //折扣前金額扣除會員優惠+加入會員工本費
            lbl_finalPrice.Text = $"總計：{GlobalVar.finalPrice} 元";

            GlobalVar.memberID = newMemberID; //全域變數(會員ID)
            lbox_bookingInfo.Items[8] = "會員" + newMemberID;
        }

        //事件:按下"結帳"紐，提交訂單(function寫下方，應該也還能再優化)
        private void button3_Click(object sender, EventArgs e)
        {
            submitOrder();
            //測試
            for (int i = 0; i < GlobalVar.selectedTicketType.Count; i++)  //票種數量
            {
                int numberOfTicket = 0;
                if (GlobalVar.selectedTicketType[i] == "雙人爆米花套票" || GlobalVar.selectedTicketType[i] == "雙人吉拿套票")
                {
                    numberOfTicket = GlobalVar.selectedTicketCount[i] * 2;
                }
                else
                {
                    numberOfTicket = GlobalVar.selectedTicketCount[i];
                }
                for (int j = 0; j < numberOfTicket; j++)  //每個票種的張數
                {
                    Ticket ticket = new Ticket();  //生成票根
                    ticket.lbl_movieName.Text = $"電影名稱：《{GlobalVar.SelectedMovie}》";
                    ticket.lbl_showtime.Text = $"場次時間： {GlobalVar.SelectedDate} {GlobalVar.SelectedTime}";
                    ticket.lbl_ticketType.Text = $"票種： {GlobalVar.selectedTicketType[i]}";
                    ticket.lbl_seatNum.Text = $"座位編號：{GlobalVar.selectedTheaterName}廳 {GlobalVar.selectedSeatNum[0]}號";
                    ticket.lbl_bookingID.Text = $"訂單編號： {GlobalVar.newBookingID}";
                    ticket.lbl_memberID.Text = $"會員卡號： {GlobalVar.memberID}";
                    //生成QRCode
                    BarcodeWriter barcodeWriter = new BarcodeWriter();
                    barcodeWriter.Format = BarcodeFormat.QR_CODE;
                    barcodeWriter.Options = new ZXing.QrCode.QrCodeEncodingOptions
                    {
                        Width = 200,
                        Height = 200,
                        ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.H
                    };
                    string qrContent = $"orderID:{GlobalVar.newBookingID}";
                    Bitmap qrBitmap = barcodeWriter.Write(qrContent);
                    ticket.Pbox_qrcode.Image = qrBitmap;
                    GlobalVar.selectedSeatNum.RemoveAt(0);
                    flow_tickets.Controls.Add(ticket);
                }
            }
            tabControl1.SelectedTab = tabPage_final;  //跳轉到生成QRcode頁面
        }


        //function:提交訂單
        private void submitOrder()
        {
            int discount = 0;
            if(Int32.TryParse(txt_useBonus.Text, out discount)){
                GlobalVar.useBonusPoint = (int)(discount / 0.3);
                //新的紅利 = 原本的紅利 - 折抵的紅利 + 此筆訂單增加的紅利
                GlobalVar.newBonusPoint = Member.bonusPoint - GlobalVar.useBonusPoint + (int)GlobalVar.finalPrice / 10;
            }
            else
            {
                GlobalVar.useBonusPoint = 0;
                //GlobalVar.newBonusPoint = Member.bonusPoint - GlobalVar.useBonusPoint + (int)GlobalVar.finalPrice / 10;
                GlobalVar.newBonusPoint = 50 + (int)GlobalVar.finalPrice / 10;
            }
                
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                conn.Open();  //打開資料庫
                SqlTransaction transaction = conn.BeginTransaction(); //★
                try
                {

                    //執行1:建立訂單資料(booking)
                    string query_booking = "";
                    if (GlobalVar.memberID != "")
                    {   //有輸入會員的版本
                        query_booking = "INSERT INTO booking(orderDate, memberID, showtimeID, totalTicket, useBonusPoint, totalPrice) " +
                        "OUTPUT INSERTED.BookingID " +
                        "Values(@orderDate, @memberID, @showtimeID, @totalTicket, @useBonusPoint, @totalPrice);";
                    }
                    else
                    {   //非會員
                        query_booking = "INSERT INTO booking(orderDate, showtimeID, totalTicket, totalPrice) " +
                            "OUTPUT INSERTED.BookingID "+
                            "Values(@orderDate, @showtimeID, @totalTicket, @totalPrice);";
                    }
                    SqlCommand cmd_submitOrder = new SqlCommand(query_booking, conn, transaction);
                    cmd_submitOrder.Parameters.AddWithValue("@orderDate", DateTime.Now.Date); 
                    cmd_submitOrder.Parameters.AddWithValue("@memberID", GlobalVar.memberID);
                    cmd_submitOrder.Parameters.AddWithValue("@showtimeID", GlobalVar.selectedTimeID);
                    cmd_submitOrder.Parameters.AddWithValue("@totalTicket", GlobalVar.selectedTicketNum);
                    cmd_submitOrder.Parameters.AddWithValue("@useBonusPoint", GlobalVar.useBonusPoint);
                    cmd_submitOrder.Parameters.AddWithValue("@totalPrice", GlobalVar.finalPrice);
                    
                    //對此命令執行查詢，並會返回查詢結果第一行第一列的值                                   
                    GlobalVar.newBookingID = Convert.ToInt32(cmd_submitOrder.ExecuteScalar());
                    
                    //執行2:建立訂單詳細資料(booking_detail)
                    string query_bookingDetail = "INSERT INTO booking_detail " +
                        "Values(@bookingID, @TicketType, @Quantity)";

                    SqlCommand cmd_submitDetail = new SqlCommand(query_bookingDetail, conn, transaction);


                    for(int i = 0; i<GlobalVar.selectedTicketType.Count; i++)
                    {
                        cmd_submitDetail.Parameters.Clear();
                        cmd_submitDetail.Parameters.AddWithValue("@bookingID", GlobalVar.newBookingID);
                        cmd_submitDetail.Parameters.AddWithValue("@TicketType", GlobalVar.selectedTicketType[i]);
                        cmd_submitDetail.Parameters.AddWithValue("@Quantity", GlobalVar.selectedTicketCount[i]);
                        cmd_submitDetail.ExecuteNonQuery();
                    }

                    //執行3:建立選位資料(booking_seat)
                    string query_submitSeat = "INSERT INTO booking_seat " +
                        "Values(@bookingID, @seatID)";
                    SqlCommand cmd_submitSeat = new SqlCommand(query_submitSeat, conn, transaction);
                    cmd_submitSeat.Parameters.AddWithValue("@bookingID", GlobalVar.newBookingID);
                    cmd_submitSeat.Parameters.Add("@seatID", SqlDbType.Int);
                    foreach (int seat in GlobalVar.selectedSeatID)
                    {
                        cmd_submitSeat.Parameters["@seatID"].Value = seat;
                        cmd_submitSeat.ExecuteNonQuery();
                    }
                    MessageBox.Show("成功新增選位資訊");

                    //執行4:更新紅利處理(扣除/累積) -優先處理原因為，先在此計算折抵紅利，以利後續訂單建立  
                    if (GlobalVar.memberID != "")
                    {//非會員不會執行)
                        //新紅利點數 = 原始紅利 - 折抵紅利 +  新訂單紅利
                        string query_BonusUpdate = "Update members Set BonusPoints = @newBonusPoint Where memberID = @memberID";
                        SqlCommand cmd_updateMemberBonus = new SqlCommand(query_BonusUpdate, conn, transaction);
                        cmd_updateMemberBonus.Parameters.AddWithValue("@newBonusPoint", GlobalVar.newBonusPoint);
                        cmd_updateMemberBonus.Parameters.AddWithValue("@memberID", GlobalVar.memberID);
                        cmd_updateMemberBonus.ExecuteNonQuery();
                        MessageBox.Show("會員紅利更新成功!");
                    }


                    //提交交易
                    transaction.Commit();

                    MessageBox.Show("訂單提交成功!");
                }
                catch (Exception ex)
                {
                    //回滾交易(有成功執行的部分也取消
                    transaction.Rollback();
                    MessageBox.Show("訂單提交失敗" + ex.Message);
                }
            }
        }

        //返回上一步(重選票種)→有選擇的座位也要清零
        private void btn_backToChooseTic_Click(object sender, EventArgs e)
        {
            
            tabControl1.SelectedTab = tabPage_price;
        }


        //轉跳頁面
        //轉跳電影管理頁面
        private void btn_toMovieManage_Click(object sender, EventArgs e)
        {
            MovieManagement movieManagement = new MovieManagement();
            this.Hide();
            movieManagement.ShowDialog();
            this.Close();
        }
        //轉跳到會員管理頁面
        private void btn_toMemberManage_Click(object sender, EventArgs e)
        {
            MemberManagement memberManagement = new MemberManagement();
            this.Hide();
            // 顯示 SecondaryForm
            memberManagement.ShowDialog();
            this.Close();
            
        }

        //轉跳到訂單管理頁面
        private void btn_toOrderManage_Click(object sender, EventArgs e)
        {            
            OrderManagement orderManagement = new OrderManagement();
            this.Hide();
            orderManagement.ShowDialog();
            this.Close();

        }

        //轉跳到報表中心
        private void btn_toReport_Click(object sender, EventArgs e)
        {
            Report_Center form_report_Center = new Report_Center();
            this.Hide();
            form_report_Center.ShowDialog();
            this.Close();
        }

        
    }
}
