using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AddMovie : Form
    {
        public event Action MovieAdded;
        public AddMovie()
        {
            InitializeComponent();
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {
            panel_moviePic.BackColor = ColorTranslator.FromHtml("#2F3645");  //左方有放照片的背景
            txt_id.Text = Movie.generateMovieID().ToString(); 
        }

        //上傳封面照
        private void btn_uploadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";  //可接受上傳圖片格式
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string newImagePath = openFileDialog.FileName;  //獲取圖片路徑
                pbox_movie.Image = Image.FromFile(newImagePath);  //把照片換到pictureBox

                Movie.movieImage = System.IO.Path.GetFileName(newImagePath); // ★取得檔名，之後存回資料庫用
            }
        }

        private void btn_addMovie_Click(object sender, EventArgs e)
        {
            Movie.movieID = Convert.ToInt32(txt_id.Text);
            Movie.movieTitle = txt_title.Text;
            Movie.movieDuration = Convert.ToInt32(txt_duration.Text);
            Movie.movieGenre = txt_genre.Text;
            Movie.movieDesc = txt_desc.Text;
            Movie.movieRating = cbox_rating.SelectedItem.ToString();
            Movie.addMovie();
            //能不能從這裡改變管理界面的清單
            // 觸發事件:通知電影已添加
            MovieAdded?.Invoke();

        }
    }
}
