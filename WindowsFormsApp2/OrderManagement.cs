using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace WindowsFormsApp2
{
    public partial class OrderManagement : Form
    {
        int bookingID = 0;
        string title = "";
        string date = "";
        string time = "";
        string memberID = "";
        string theater = "";
        int totalTicket = 0;
        int useBonus = 0;   //到時退票要處理點數(會員):加回折抵的點數、扣除該筆訂單產生的點數(總金額/10)
        int price = 0;


        List<int>seatID = new List<int>();
        List<int>seatNum = new List<int>();
        List<string>ticketType = new List<string>();  //票種種類
        List<int>ticketCount = new List<int>(); //票種對應購買數量

        //場次時間  (日期加時間)
        DateTime showDateTime = new DateTime();


        public OrderManagement()
        {
            InitializeComponent();
        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {
            panel_nav.BackColor = ColorTranslator.FromHtml("#2F3645");  //左側導覽列
            panel_top.BackColor = ColorTranslator.FromHtml("#939185");  //右側上方()
            panel_top2.BackColor = ColorTranslator.FromHtml("#939185"); //右側上方()
            dataView_orderList.DataSource = load_order();  //載入訂單資訊
            lbl_count.Text = $"共 {load_order().Rows.Count} 筆";
            InitializeDetailsPlaceholder(); //讓版面不要太空
            InitializeSeatsPlaceholder(); //讓版面不要太空

            cbox_search.SelectedIndex = 0; 
        }

        //佔位符，讓版面不要那麼空  //先取消
        private void InitializeDetailsPlaceholder()
        {
            //DataTable detailsPlaceholder = new DataTable();
            //detailsPlaceholder.Columns.Add("提示");
            //detailsPlaceholder.Rows.Add("請選擇一筆訂單查看詳情");

            //dataView_orderDetail.DataSource = detailsPlaceholder;
        }

        private void InitializeSeatsPlaceholder() //先取消
        {
            //DataTable seatsPlaceholder = new DataTable();
            //seatsPlaceholder.Columns.Add("提示");
            //seatsPlaceholder.Rows.Add("請選擇一筆訂單查看座位訊息");

            //dataView_seat.DataSource = seatsPlaceholder;
        }

        //事件:按下退票按鈕
        private void btn_refund_Click(object sender, EventArgs e)
        {
            refund();
            dataView_orderList.DataSource = load_order();
            lbl_count.Text = $"共 {load_order().Rows.Count} 筆";
        }

        //事件:按下補票按鈕
        private void btn_sup_Click(object sender, EventArgs e)
        {
            GenerateTicket();
            tabControl1.SelectedTab = tabPage2;
        }


        //function:載入訂單資訊(booking)
        private DataTable load_order()
        {
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    //查詢，這是不需要加入參數情況(載入全部資料)，所以不需要用sql command
                    string query = "SELECT b.bookingID AS 編號, b.orderdate AS 訂單日期, me.memberID AS 會員卡號, b.useBonusPoint 折抵點數, b.totalPrice AS 訂單金額 " +
                        "FROM booking b LEFT JOIN members me ON b.memberID = me.memberID";

                    // SqlDataAdapter為資料來源(資料庫等)及資料集之間填充數據的橋樑
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return null;
                }
            }
        }

        private DataTable searchOrder(string search)
        {
            string query = "";

            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    //查詢，這是不需要加入參數情況(載入全部資料)，所以不需要用sql command
                    if (cbox_search.SelectedIndex == 0)
                    {
                        query = "SELECT b.bookingID AS 編號, b.orderdate AS 訂單日期, me.memberID AS 會員卡號, " +
                            "b.useBonusPoint 折抵點數, b.totalPrice AS 訂單金額 " +
                            "FROM booking b JOIN members me ON b.memberID = me.memberID " +
                            "Where me.memberID = @search"; 
                    }else if (cbox_search.SelectedIndex == 1)
                    {
                        query = "SELECT b.bookingID AS 編號, b.orderdate AS 訂單日期, me.memberID AS 會員卡號, " +
                            "b.useBonusPoint 折抵點數, b.totalPrice AS 訂單金額 " +
                            "FROM booking b JOIN members me ON b.memberID = me.memberID " +
                            "Where b.bookingID = @search";
                    }
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("search", search);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if(dataTable.Rows.Count > 0)
                    {
                        return dataTable;
                    }
                    else
                    {
                        MessageBox.Show("查無訂單!");
                        return null;
                    }                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return null;
                }
            }

            
        }

        //雙擊某筆資料載入訂單詳細資訊
        private void dataView_orderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 獲取所雙擊的行
            DataGridViewRow row = dataView_orderList.Rows[e.RowIndex];

            // 獲取行中的特定儲存格的值
            bookingID = (int)row.Cells["編號"].Value;
            if(row.Cells["會員卡號"].Value.ToString()!= null)
            {
                memberID = row.Cells["會員卡號"].Value.ToString();
            }
            Int32.TryParse(row.Cells["折抵點數"].Value.ToString(), out useBonus);
            price = (int)row.Cells["訂單金額"].Value;
            //載入訂單票種 (以後再看要不要用datatable)
            load_orderDetail(bookingID);
            //載入訂單座位  (以後再看要不要用datatable
            load_orderSeat(bookingID);
            load_movieDetail(bookingID);

            //test
            Console.WriteLine(memberID);
            Console.WriteLine(useBonus);

        }

        //function:載入訂單電影資訊(右邊資訊區)
        private void load_movieDetail(int bookingID)
        {
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT  m.title, t.theaterName, b.totalTicket, s.showDate, s.showTime " +
                        "From booking b JOIN show_time s ON b.showtimeID = s.showTimeID " +
                        "JOIN movie m ON s.movieID = m.movieID " +
                        "JOIN theater t ON s.theaterID = t.theaterID " +
                        "Where bookingID = @bookingID";

                    SqlCommand cmd = new SqlCommand(query, conn);                    
                    // 添加參數
                    cmd.Parameters.AddWithValue("@bookingID", bookingID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    //改變區域變數
                    title = reader["title"].ToString();
                    date = reader["showDate"].ToString();
                    time = ((TimeSpan)reader["showTime"]).ToString(@"hh\:mm");
                    Console.WriteLine(date);
                    Console.WriteLine(time);


                    //為了準確抓出時間(決定退票最晚時間)
                    DateTime showDate = (DateTime)reader["showDate"];
                    TimeSpan showTime = (TimeSpan)reader["showTime"];
                    // 合并日期和时间
                    showDateTime = showDate.Date.Add(showTime);
                    Console.WriteLine(showDateTime);


                    theater = reader["theaterName"].ToString();
                    totalTicket = (int)reader["totalTicket"];

                    txt_movie.Text = title;
                    dtp_date.Value = Convert.ToDateTime(date);
                    dtp_time.Value = Convert.ToDateTime(time);                   
                    date = dtp_date.Value.ToString("yyyy-MM-dd");

                    txt_theater.Text = $"{theater}廳";
                    txt_ticket.Text = totalTicket.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        //function:載入訂單詳細資料(票種)  //datatable先不用
        private DataTable load_orderDetail(int bookingID)
        {
            ticketType.Clear();
            ticketCount.Clear();

            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    //查詢，這是不需要加入參數情況(載入全部資料)，所以不需要用sql command
                    string query = "SELECT ticketType AS 購買票種, quantity AS 購買數量 From booking_detail " +
                        "Where bookingID = @bookingID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // 添加參數
                        cmd.Parameters.AddWithValue("@bookingID", bookingID);

                        // 使用 SqlDataAdapter 和 SqlCommand 填充 DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        //把票種跟張數加到字典
                        foreach (DataRow row in dataTable.Rows)
                        {
                            ticketType.Add(row["購買票種"].ToString());
                            ticketCount.Add((int)row["購買數量"]);                            
                        }
                        string buyTicket = "";
                        for (int i = 0; i < ticketType.Count; i++)
                        {
                            buyTicket += $"{ticketType[i]} x {ticketCount[i]}\r\n";
                        }
                        txt_ticketType.Text = buyTicket;


                        return dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return null;
                }
            }
        }

        //function:載入訂單詳細資料(選位) //datatable先不用
        private DataTable load_orderSeat (int bookingID)
        {
            seatID.Clear();
            seatNum.Clear();

            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    //查詢，這是不需要加入參數情況(載入全部資料)，所以不需要用sql command
                    string query = "SELECT bs.seatID, se.seatNumber AS 座位編號 From booking_seat bs JOIN seat se ON bs.seatID = se.seatID " +
                        "Where bs.bookingID = @bookingID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // 添加參數
                        cmd.Parameters.AddWithValue("@bookingID", bookingID);

                        // 使用 SqlDataAdapter 和 SqlCommand 填充 DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        //把選位加到list
                        foreach (DataRow row in dataTable.Rows)
                        {
                            seatID.Add((int)row["seatID"]);
                            seatNum.Add((int)row["座位編號"]);
                        }
                        string chooseSeat = "";
                        foreach (int number in seatNum)
                        {
                            chooseSeat += $"{number} 號, ";
                        }
                        txt_seatNum.Text = chooseSeat.Substring(0, chooseSeat.Length - 2);

                        return dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return null;
                }
            }
        }

        //function:退票相關流程
        private void refund()
        {
            //最晚退票時間
            DateTime lastCancelTime = showDateTime.AddMinutes(-20);

            if (DateTime.Now <= lastCancelTime)
            {
                Console.WriteLine("可以退票");
                using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
                {
                    conn.Open();  //打開資料庫
                    SqlTransaction transaction = conn.BeginTransaction(); //★
                    try
                    {
                        //1. 更新seat表(座位預定狀態改變)
                        string query_updateSeatStatus = "Update seat SET isbooked = 'false' where seatID = @seatID";
                        SqlCommand cmd_updateSeatStatus = new SqlCommand(query_updateSeatStatus, conn, transaction);
                        cmd_updateSeatStatus.Parameters.Add("@seatID", SqlDbType.Int);
                        for (int i = 0; i < seatID.Count; i++)
                        {
                            cmd_updateSeatStatus.Parameters["@seatID"].Value = seatID[i];
                            cmd_updateSeatStatus.ExecuteNonQuery();
                        }
                        MessageBox.Show("成功更新座位狀態!");

                        //2. 刪除booking_seat資料(用bookingID篩選)
                        string query_deleteSeat = "Delete from booking_seat where bookingID = @bookingID";
                        SqlCommand cmd_deleteSeat = new SqlCommand(query_deleteSeat, conn, transaction);
                        cmd_deleteSeat.Parameters.AddWithValue("@bookingID", bookingID);
                        cmd_deleteSeat.ExecuteNonQuery();
                        MessageBox.Show("已刪除訂單座位資訊!");

                        //3. 刪除booking_detail資料(用bookingID篩選)
                        string query_deleteDetail = "Delete from booking_detail where bookingID = @bookingID";
                        SqlCommand cmd_deleteDetail = new SqlCommand(query_deleteDetail, conn, transaction);
                        cmd_deleteDetail.Parameters.AddWithValue("@bookingID", bookingID);
                        cmd_deleteDetail.ExecuteNonQuery();
                        MessageBox.Show("已刪除訂單詳細資訊!");

                        //4. 若為會員，更新紅利(用會員id)
                        if (memberID != "")
                        {
                            string query_searchCurrentPoint = "select BonusPoints from members where memberID = @memberID";
                            SqlCommand cmd = new SqlCommand(query_searchCurrentPoint, conn, transaction);
                            cmd.Parameters.AddWithValue("@memberID", memberID);
                            int currentBonusPoint = (int)cmd.ExecuteScalar();
                            int newBonusPoint = currentBonusPoint + useBonus - price / 10;  //新紅利點數=原本的紅利+本筆訂單折抵點數歸還-本筆訂單累積點數
                            string query_updateBonusPoint = "Update members SET bonusPoints = @newBonusPoint where memberID = @memberID";
                            SqlCommand cmd_updateBonusPoint = new SqlCommand(query_updateBonusPoint, conn, transaction);
                            cmd_updateBonusPoint.Parameters.AddWithValue("@newBonusPoint", newBonusPoint);
                            cmd_updateBonusPoint.Parameters.AddWithValue("@memberID", memberID);
                            cmd_updateBonusPoint.ExecuteNonQuery();
                            MessageBox.Show($"已更新紅利點數，會員卡號{memberID}");
                        }

                        //5. 刪除booking資料(用bookingID篩選)
                        string query_deleteBooking = "DELETE FROM booking WHERE bookingID = @bookingID";
                        SqlCommand cmd_deleteBooking = new SqlCommand(query_deleteBooking, conn, transaction);
                        cmd_deleteBooking.Parameters.AddWithValue("@bookingID", bookingID);
                        cmd_deleteBooking.ExecuteNonQuery();
                        MessageBox.Show("已刪除訂單!");

                        //提交交易
                        transaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        //回滾交易(有成功執行的部分也取消
                        transaction.Rollback();
                        MessageBox.Show("訂單刪除失敗" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("已超過最晚退票時間\n(場次開始前20分)", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
                        
        }

        //function:補票流程(生成QRCODER，基本和售票模組生成方法一樣)
        private void GenerateTicket()
        {
            for (int i = 0; i < ticketType.Count; i++)  //票種數量
            {
                int numberOfTicket = 0;
                if (ticketType[i] == "雙人爆米花套票" || ticketType[i] == "雙人吉拿套票")
                {
                    numberOfTicket = ticketCount[i] * 2;
                }
                else
                {
                    numberOfTicket = ticketCount[i];
                }
                for (int j = 0; j < numberOfTicket; j++)  //每個票種的張數
                {
                    Ticket ticket = new Ticket();  //生成票根
                    ticket.lbl_movieName.Text = $"電影名稱：《{title}》";
                    ticket.lbl_showtime.Text = $"場次時間：{date} {time}";
                    ticket.lbl_ticketType.Text = $"票種： {ticketType[i]}";
                    ticket.lbl_seatNum.Text = $"座位編號：{theater}廳 {seatNum[0]}號";
                    ticket.lbl_bookingID.Text = $"訂單編號： {bookingID}";
                    ticket.lbl_memberID.Text = $"會員卡號： {memberID}";
                    //生成QRCode
                    BarcodeWriter barcodeWriter = new BarcodeWriter();
                    barcodeWriter.Format = BarcodeFormat.QR_CODE;
                    barcodeWriter.Options = new ZXing.QrCode.QrCodeEncodingOptions
                    {
                        Width = 200,
                        Height = 200,
                        ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.H
                    };
                    string qrContent = $"orderID:{bookingID}";
                    Bitmap qrBitmap = barcodeWriter.Write(qrContent);
                    ticket.Pbox_qrcode.Image = qrBitmap;
                    seatNum.RemoveAt(0);
                    flow_tickets.Controls.Add(ticket);
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_SearchOrder.Text != "")
            {
                if (searchOrder(txt_SearchOrder.Text) != null)
                {
                    dataView_orderList.DataSource = searchOrder(txt_SearchOrder.Text);
                    lbl_count.Text = $"共 {searchOrder(txt_SearchOrder.Text).Rows.Count} 筆";
                }
                else
                {
                    dataView_orderList.DataSource = load_order();
                    lbl_count.Text = $"共 {load_order().Rows.Count} 筆";
                }
                
            }
        }

        //轉跳到電影管理頁面
        private void btn_toMovieManage_Click(object sender, EventArgs e)
        {
            MovieManagement form_movieManage = new MovieManagement();
            this.Hide();
            form_movieManage.ShowDialog();
            this.Close();
        }

        private void btn_showList_Click(object sender, EventArgs e)
        {
            dataView_orderList.DataSource = load_order();  //載入訂單資訊
        }
    }

    
    
}
