namespace WindowsFormsApp2
{
    partial class AddMovie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_moviePic = new System.Windows.Forms.Panel();
            this.btn_uploadPic = new System.Windows.Forms.Button();
            this.pbox_movie = new System.Windows.Forms.PictureBox();
            this.btn_addMovie = new System.Windows.Forms.Button();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_duration = new System.Windows.Forms.TextBox();
            this.txt_genre = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cbox_rating = new System.Windows.Forms.ComboBox();
            this.panel_moviePic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_movie)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_moviePic
            // 
            this.panel_moviePic.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader;
            this.panel_moviePic.Controls.Add(this.btn_uploadPic);
            this.panel_moviePic.Controls.Add(this.pbox_movie);
            this.panel_moviePic.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_moviePic.Location = new System.Drawing.Point(0, 0);
            this.panel_moviePic.Name = "panel_moviePic";
            this.panel_moviePic.Size = new System.Drawing.Size(342, 520);
            this.panel_moviePic.TabIndex = 30;
            // 
            // btn_uploadPic
            // 
            this.btn_uploadPic.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_uploadPic.Location = new System.Drawing.Point(91, 467);
            this.btn_uploadPic.Name = "btn_uploadPic";
            this.btn_uploadPic.Size = new System.Drawing.Size(152, 35);
            this.btn_uploadPic.TabIndex = 18;
            this.btn_uploadPic.Text = "上傳封面照";
            this.btn_uploadPic.UseVisualStyleBackColor = true;
            this.btn_uploadPic.Click += new System.EventHandler(this.btn_uploadPic_Click);
            // 
            // pbox_movie
            // 
            this.pbox_movie.BackColor = System.Drawing.Color.LightGray;
            this.pbox_movie.ErrorImage = null;
            this.pbox_movie.InitialImage = null;
            this.pbox_movie.Location = new System.Drawing.Point(24, 29);
            this.pbox_movie.Name = "pbox_movie";
            this.pbox_movie.Size = new System.Drawing.Size(294, 424);
            this.pbox_movie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_movie.TabIndex = 17;
            this.pbox_movie.TabStop = false;
            // 
            // btn_addMovie
            // 
            this.btn_addMovie.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_addMovie.Location = new System.Drawing.Point(701, 467);
            this.btn_addMovie.Name = "btn_addMovie";
            this.btn_addMovie.Size = new System.Drawing.Size(122, 41);
            this.btn_addMovie.TabIndex = 29;
            this.btn_addMovie.Text = "送出";
            this.btn_addMovie.UseVisualStyleBackColor = true;
            this.btn_addMovie.Click += new System.EventHandler(this.btn_addMovie_Click);
            // 
            // txt_desc
            // 
            this.txt_desc.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_desc.Location = new System.Drawing.Point(404, 302);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_desc.Size = new System.Drawing.Size(389, 151);
            this.txt_desc.TabIndex = 28;
            // 
            // txt_duration
            // 
            this.txt_duration.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_duration.Location = new System.Drawing.Point(480, 216);
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(305, 34);
            this.txt_duration.TabIndex = 27;
            // 
            // txt_genre
            // 
            this.txt_genre.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_genre.Location = new System.Drawing.Point(480, 167);
            this.txt_genre.Name = "txt_genre";
            this.txt_genre.Size = new System.Drawing.Size(305, 34);
            this.txt_genre.TabIndex = 26;
            // 
            // txt_title
            // 
            this.txt_title.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_title.Location = new System.Drawing.Point(480, 73);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(305, 34);
            this.txt_title.TabIndex = 24;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_id.Location = new System.Drawing.Point(480, 26);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(305, 34);
            this.txt_id.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(399, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "電影描述：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(399, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "片長：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(399, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "類型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(399, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "分級：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(399, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "電影：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(399, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID：";
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_clear.Location = new System.Drawing.Point(561, 467);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(122, 41);
            this.btn_clear.TabIndex = 31;
            this.btn_clear.Text = "清空內容";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // cbox_rating
            // 
            this.cbox_rating.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox_rating.FormattingEnabled = true;
            this.cbox_rating.Items.AddRange(new object[] {
            "普遍級(0+)",
            "保護級(6+)",
            "輔導級(12+)",
            "輔導級(15+)",
            "限制級(18+)"});
            this.cbox_rating.Location = new System.Drawing.Point(480, 120);
            this.cbox_rating.Name = "cbox_rating";
            this.cbox_rating.Size = new System.Drawing.Size(305, 33);
            this.cbox_rating.TabIndex = 32;
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 520);
            this.Controls.Add(this.cbox_rating);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.panel_moviePic);
            this.Controls.Add(this.btn_addMovie);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_duration);
            this.Controls.Add(this.txt_genre);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMovie";
            this.Load += new System.EventHandler(this.AddMovie_Load);
            this.panel_moviePic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_movie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_moviePic;
        private System.Windows.Forms.Button btn_uploadPic;
        private System.Windows.Forms.PictureBox pbox_movie;
        private System.Windows.Forms.Button btn_addMovie;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_duration;
        private System.Windows.Forms.TextBox txt_genre;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox cbox_rating;
    }
}