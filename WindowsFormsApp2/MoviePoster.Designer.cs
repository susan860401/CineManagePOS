namespace WindowsFormsApp2
{
    partial class MoviePoster
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_movie = new System.Windows.Forms.Panel();
            this.cbox_showTime = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_MovieLength = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pbox_movie = new System.Windows.Forms.PictureBox();
            this.Pbox_movieRating = new System.Windows.Forms.PictureBox();
            this.panel_movie.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_movie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbox_movieRating)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_movie
            // 
            this.panel_movie.BackColor = System.Drawing.Color.Transparent;
            this.panel_movie.Controls.Add(this.cbox_showTime);
            this.panel_movie.Controls.Add(this.panel2);
            this.panel_movie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_movie.Location = new System.Drawing.Point(0, 0);
            this.panel_movie.Name = "panel_movie";
            this.panel_movie.Size = new System.Drawing.Size(252, 377);
            this.panel_movie.TabIndex = 0;
            // 
            // cbox_showTime
            // 
            this.cbox_showTime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox_showTime.FormattingEnabled = true;
            this.cbox_showTime.Items.AddRange(new object[] {
            "------請選擇場次-----"});
            this.cbox_showTime.Location = new System.Drawing.Point(13, 339);
            this.cbox_showTime.Name = "cbox_showTime";
            this.cbox_showTime.Size = new System.Drawing.Size(228, 33);
            this.cbox_showTime.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Pbox_movieRating);
            this.panel2.Controls.Add(this.lbl_MovieLength);
            this.panel2.Controls.Add(this.lbl_title);
            this.panel2.Controls.Add(this.pbox_movie);
            this.panel2.Location = new System.Drawing.Point(7, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 323);
            this.panel2.TabIndex = 6;
            // 
            // lbl_MovieLength
            // 
            this.lbl_MovieLength.AutoSize = true;
            this.lbl_MovieLength.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_MovieLength.Location = new System.Drawing.Point(13, 293);
            this.lbl_MovieLength.Name = "lbl_MovieLength";
            this.lbl_MovieLength.Size = new System.Drawing.Size(58, 22);
            this.lbl_MovieLength.TabIndex = 2;
            this.lbl_MovieLength.Text = "label1";
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_title.Location = new System.Drawing.Point(12, 268);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(153, 25);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "label1";
            // 
            // pbox_movie
            // 
            this.pbox_movie.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbox_movie.ErrorImage = null;
            this.pbox_movie.InitialImage = null;
            this.pbox_movie.Location = new System.Drawing.Point(13, 7);
            this.pbox_movie.Name = "pbox_movie";
            this.pbox_movie.Size = new System.Drawing.Size(212, 258);
            this.pbox_movie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_movie.TabIndex = 0;
            this.pbox_movie.TabStop = false;
            // 
            // Pbox_movieRating
            // 
            this.Pbox_movieRating.ErrorImage = null;
            this.Pbox_movieRating.InitialImage = null;
            this.Pbox_movieRating.Location = new System.Drawing.Point(171, 268);
            this.Pbox_movieRating.Name = "Pbox_movieRating";
            this.Pbox_movieRating.Size = new System.Drawing.Size(54, 25);
            this.Pbox_movieRating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbox_movieRating.TabIndex = 3;
            this.Pbox_movieRating.TabStop = false;
            // 
            // MoviePoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_movie);
            this.Name = "MoviePoster";
            this.Size = new System.Drawing.Size(252, 377);
            this.Load += new System.EventHandler(this.MoviePoster_Load);
            this.panel_movie.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_movie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbox_movieRating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel_movie;
        public System.Windows.Forms.ComboBox cbox_showTime;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lbl_MovieLength;
        public System.Windows.Forms.Label lbl_title;
        public System.Windows.Forms.PictureBox pbox_movie;
        public System.Windows.Forms.PictureBox Pbox_movieRating;
    }
}
