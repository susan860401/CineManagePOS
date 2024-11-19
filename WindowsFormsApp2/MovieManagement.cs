using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Application = System.Windows.Forms.Application;

namespace WindowsFormsApp2
{

    public partial class MovieManagement : Form
    {
        //考慮統整到movie的全域變數?
        int Current_movieID = 0;
        string Current_title = "";
        int Current_theaterID = 0;

        //照片根目錄Application.StartupPath→bin/debug/image
        string imageDir = Path.Combine(Application.StartupPath, "image");

        public MovieManagement()
        {
            InitializeComponent();

        }

        private void MovieManagement_Load(object sender, EventArgs e)
        {
            panel_nav.BackColor = ColorTranslator.FromHtml("#2F3645");  //左側導覽列
            panel_top.BackColor = ColorTranslator.FromHtml("#939185");  //右側上方(電影資訊管理)
            panel_top2.BackColor = ColorTranslator.FromHtml("#939185"); //右側上方(場次管理)
            panel_addMovie.Visible = false;  //增加場次的框先不要出現
            dtp_time.Value = new DateTime(1990, 1, 1, 0, 0, 0);


            dataView_movie.DataSource = Movie.LoadMovieList(); //載入電影列表
            dataView_showTime.DataSource = Movie.LoadShowTimetList(); //載入場次列表
            // 延遲設定格式以確保 DataGridView 完全綁定數據                                                        
            dataView_showTime.DataBindingComplete += (s, args) =>
            {
                dataView_showTime.Columns["時間"].DefaultCellStyle.Format = @"hh\:mm";
            };

            cbox_theater.SelectedIndex = 0;

            Movie.searchMovieInfo();  //用來取得一些電影資訊(重複載入會有bug，由於有dict
            foreach (string key in Movie.dict_movie.Keys)  //把電影清單載入到電影選單combobox
            {
                cbox_movie.Items.Add(key);
            }

        }


        //進入新增片單頁面
        private void btn_toAddMovie_Click(object sender, EventArgs e)
        {
            AddMovie addMovieForm = new AddMovie();
            addMovieForm.MovieAdded += UpdateMovieList;
            addMovieForm.ShowDialog();
        }

        private void UpdateMovieList()
        {
            dataView_movie.DataSource = Movie.LoadMovieList();


        }

        //進入修改電影頁面
        private void btn_toModifyMovie_Click(object sender, EventArgs e)
        {
            //要先獲得選取的movieid
            Current_movieID = (int)dataView_movie.SelectedCells[0].Value; //獲取選擇的movieID
            Movie.loadMovieDetail(Current_movieID);   //載入選取電影的資訊，準備載入到修改電影資訊的頁面


            modifyMovieInfo form_modifyMovie = new modifyMovieInfo();
            form_modifyMovie.MovieModify += UpdateMovieList;
            form_modifyMovie.ShowDialog();

            //test 
            Console.WriteLine(Current_movieID); //確認是否正確取得選取id
        }

        //當開始搜尋場次(以電影名稱)
        private void txt_searchShowTime_TextChanged(object sender, EventArgs e)
        {
            //進行電影搜索會載入場次
            dataView_showTime.DataSource = Movie.searchMovieShowTime(txt_searchShowTime.Text);
        }

        //進入/顯示新增電影場次頁面(我這邊預設已經選好電影)
        private void btn_toAddShowTime_Click(object sender, EventArgs e)
        {
            cbox_movie.SelectedItem = (string)dataView_showTime.SelectedCells[1].Value;  //combo box顯示要新增場次的電影
            panel_addMovie.Visible = true;
            btn_addShowTime.Visible = true;
        }

        //確認新增場次
        private void btn_addShowTime_Click(object sender, EventArgs e)
        {
            Current_title = cbox_movie.SelectedItem.ToString(); //取得所選的電影title
            Current_movieID = cbox_movie.SelectedIndex + 1; //所選的電影ID (索引值加1)  
            Current_theaterID = cbox_theater.SelectedIndex + 1;

            Movie.addNewShowTime(Current_movieID, dtp_date.Value, dtp_time.Value, Current_theaterID);
            dataView_showTime.DataSource = Movie.LoadShowTimetList(); //重新載入場次表
            //修改時間表式方式:
            dataView_showTime.DataBindingComplete += (s, args) =>
            {
                dataView_showTime.Columns["時間"].DefaultCellStyle.Format = @"hh\:mm";
            };

            //test
            Console.WriteLine(Current_title);
            Console.WriteLine(Current_movieID);
        }

        //當變換選擇的影廳，改變配置圖
        private void cbox_theater_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_theater.SelectedIndex == 0 || cbox_theater.SelectedIndex == 2)
            {               
                Pbox_theater.ImageLocation = Path.Combine(imageDir, "TheaterAC.png");
            }
            else if(cbox_theater.SelectedIndex == 1)
            {                
                Pbox_theater.ImageLocation = Path.Combine(imageDir, "TheaterB.png");
            }
        }

        //轉跳到售票模組
        private void btn_toSaleSystem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();           
            this.Close();
        }
    }
}
