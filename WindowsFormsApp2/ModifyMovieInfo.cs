using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace WindowsFormsApp2
{
    public partial class modifyMovieInfo : Form
    {
        public event Action MovieModify;

        //照片根目錄Application.StartupPath→bin/debug/image
        string img_dir = Path.Combine(Application.StartupPath, "image");

        public modifyMovieInfo()
        {
            InitializeComponent();
        }

        private void ModifyMovieInfo_Load(object sender, EventArgs e)
        {

            
            panel_moviePic.BackColor = ColorTranslator.FromHtml("#2F3645");  //左方有放照片的背景

            txt_id.Text = Movie.movieID.ToString();
            txt_title.Text = Movie.movieTitle;
            txt_rating.Text = Movie.movieRating;
            txt_genre.Text = Movie.movieGenre;
            txt_desc.Text = Movie.movieDesc;
            txt_duration.Text = Movie.movieDuration.ToString();
            string full_imgPath = Path.Combine(img_dir, Movie.movieImage);
            System.IO.FileStream fs = System.IO.File.OpenRead(full_imgPath);
            pbox_movie.Image = System.Drawing.Image.FromStream(fs);
            fs.Close();

        }
        
        //更改封面照
        private void btn_updatePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";  //可接受上傳圖片格式
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string newImagePath = openFileDialog.FileName;  //獲取圖片路徑
                pbox_movie.Image = System.Drawing.Image.FromFile(newImagePath);  //把照片換到pictureBox

                Movie.movieImage = System.IO.Path.GetFileName(newImagePath); // ★取得檔名，之後存回資料庫用
            }
        }

        //更改電影資訊
        private void btn_submitModify_Click(object sender, EventArgs e)
        {
            Movie.ModifyMovie(txt_id.Text, txt_title.Text, txt_rating.Text, txt_genre.Text, txt_duration.Text, txt_desc.Text, Movie.movieImage);
            MovieModify?.Invoke();
            this.Close();
        }

    }
}
