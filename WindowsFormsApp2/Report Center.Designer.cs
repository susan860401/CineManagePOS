namespace WindowsFormsApp2
{
    partial class Report_Center
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
            this.panel_nav = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpage1 = new System.Windows.Forms.TabPage();
            this.lbl_movieSale = new System.Windows.Forms.Label();
            this.lbl_sale = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_topOne = new System.Windows.Forms.Label();
            this.lbl_saleInfo = new System.Windows.Forms.Label();
            this.lbl_rating = new System.Windows.Forms.Label();
            this.lbl_ratingTitle = new System.Windows.Forms.Label();
            this.lbl_saleTitle = new System.Windows.Forms.Label();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.Chart2 = new LiveCharts.Wpf.CartesianChart();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.Chart1 = new LiveCharts.Wpf.CartesianChart();
            this.panel_top = new System.Windows.Forms.Panel();
            this.cbox_date = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbox_year = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_month = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_top2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbox_topOne = new System.Windows.Forms.PictureBox();
            this.panel_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabpage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_topOne)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_nav
            // 
            this.panel_nav.BackColor = System.Drawing.Color.White;
            this.panel_nav.Controls.Add(this.pictureBox1);
            this.panel_nav.Controls.Add(this.button6);
            this.panel_nav.Controls.Add(this.button4);
            this.panel_nav.Controls.Add(this.button3);
            this.panel_nav.Controls.Add(this.button2);
            this.panel_nav.Controls.Add(this.button1);
            this.panel_nav.Controls.Add(this.button5);
            this.panel_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_nav.Location = new System.Drawing.Point(0, 0);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(212, 976);
            this.panel_nav.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 135);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.Location = new System.Drawing.Point(56, 769);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 46);
            this.button6.TabIndex = 19;
            this.button6.Text = "登出";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(16, 435);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 58);
            this.button4.TabIndex = 18;
            this.button4.Text = "報表中心";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(14, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 58);
            this.button3.TabIndex = 17;
            this.button3.Text = "電影管理";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(14, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 58);
            this.button2.TabIndex = 16;
            this.button2.Text = "訂單管理";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(14, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 58);
            this.button1.TabIndex = 15;
            this.button1.Text = "電影售票";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(14, 226);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 58);
            this.button5.TabIndex = 14;
            this.button5.Text = "會員管理";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(212, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1474, 976);
            this.tabControl1.TabIndex = 8;
            // 
            // tabpage1
            // 
            this.tabpage1.Controls.Add(this.lbl_movieSale);
            this.tabpage1.Controls.Add(this.lbl_sale);
            this.tabpage1.Controls.Add(this.panel1);
            this.tabpage1.Controls.Add(this.elementHost2);
            this.tabpage1.Controls.Add(this.elementHost1);
            this.tabpage1.Controls.Add(this.panel_top);
            this.tabpage1.Location = new System.Drawing.Point(4, 31);
            this.tabpage1.Name = "tabpage1";
            this.tabpage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage1.Size = new System.Drawing.Size(1466, 941);
            this.tabpage1.TabIndex = 0;
            this.tabpage1.Text = "統計圖表";
            this.tabpage1.UseVisualStyleBackColor = true;
            // 
            // lbl_movieSale
            // 
            this.lbl_movieSale.AutoSize = true;
            this.lbl_movieSale.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_movieSale.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_movieSale.ForeColor = System.Drawing.Color.White;
            this.lbl_movieSale.Location = new System.Drawing.Point(433, 522);
            this.lbl_movieSale.Name = "lbl_movieSale";
            this.lbl_movieSale.Size = new System.Drawing.Size(188, 29);
            this.lbl_movieSale.TabIndex = 15;
            this.lbl_movieSale.Text = "label_movieSale";
            // 
            // lbl_sale
            // 
            this.lbl_sale.AutoSize = true;
            this.lbl_sale.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_sale.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_sale.ForeColor = System.Drawing.Color.White;
            this.lbl_sale.Location = new System.Drawing.Point(465, 87);
            this.lbl_sale.Name = "lbl_sale";
            this.lbl_sale.Size = new System.Drawing.Size(118, 29);
            this.lbl_sale.TabIndex = 14;
            this.lbl_sale.Text = "label_sale";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_topOne);
            this.panel1.Controls.Add(this.lbl_saleInfo);
            this.panel1.Controls.Add(this.lbl_rating);
            this.panel1.Controls.Add(this.lbl_ratingTitle);
            this.panel1.Controls.Add(this.pbox_topOne);
            this.panel1.Controls.Add(this.lbl_saleTitle);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(1031, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 817);
            this.panel1.TabIndex = 13;
            // 
            // lbl_topOne
            // 
            this.lbl_topOne.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_topOne.Location = new System.Drawing.Point(86, 368);
            this.lbl_topOne.Name = "lbl_topOne";
            this.lbl_topOne.Size = new System.Drawing.Size(184, 29);
            this.lbl_topOne.TabIndex = 6;
            this.lbl_topOne.Text = "本月份票房冠軍";
            this.lbl_topOne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_saleInfo
            // 
            this.lbl_saleInfo.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_saleInfo.Location = new System.Drawing.Point(33, 57);
            this.lbl_saleInfo.Name = "lbl_saleInfo";
            this.lbl_saleInfo.Size = new System.Drawing.Size(310, 43);
            this.lbl_saleInfo.TabIndex = 5;
            this.lbl_saleInfo.Text = "label4";
            this.lbl_saleInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_rating
            // 
            this.lbl_rating.AutoSize = true;
            this.lbl_rating.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_rating.Location = new System.Drawing.Point(72, 186);
            this.lbl_rating.Name = "lbl_rating";
            this.lbl_rating.Size = new System.Drawing.Size(152, 25);
            this.lbl_rating.TabIndex = 4;
            this.lbl_rating.Text = "本月份票房排名";
            // 
            // lbl_ratingTitle
            // 
            this.lbl_ratingTitle.AutoSize = true;
            this.lbl_ratingTitle.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ratingTitle.Location = new System.Drawing.Point(28, 116);
            this.lbl_ratingTitle.Name = "lbl_ratingTitle";
            this.lbl_ratingTitle.Size = new System.Drawing.Size(174, 29);
            this.lbl_ratingTitle.TabIndex = 3;
            this.lbl_ratingTitle.Text = "本月份票房排名";
            // 
            // lbl_saleTitle
            // 
            this.lbl_saleTitle.AutoSize = true;
            this.lbl_saleTitle.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_saleTitle.Location = new System.Drawing.Point(28, 22);
            this.lbl_saleTitle.Name = "lbl_saleTitle";
            this.lbl_saleTitle.Size = new System.Drawing.Size(136, 29);
            this.lbl_saleTitle.TabIndex = 1;
            this.lbl_saleTitle.Text = "lbl_saleInfo";
            // 
            // elementHost2
            // 
            this.elementHost2.Location = new System.Drawing.Point(42, 567);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(965, 327);
            this.elementHost2.TabIndex = 11;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.Chart2;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(42, 135);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(965, 327);
            this.elementHost1.TabIndex = 10;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.Chart1;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_top.Controls.Add(this.cbox_date);
            this.panel_top.Controls.Add(this.label3);
            this.panel_top.Controls.Add(this.cbox_year);
            this.panel_top.Controls.Add(this.label2);
            this.panel_top.Controls.Add(this.cbox_month);
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(3, 3);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1460, 59);
            this.panel_top.TabIndex = 9;
            // 
            // cbox_date
            // 
            this.cbox_date.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbox_date.DropDownHeight = 120;
            this.cbox_date.DropDownWidth = 61;
            this.cbox_date.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox_date.FormattingEnabled = true;
            this.cbox_date.IntegralHeight = false;
            this.cbox_date.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14 ",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbox_date.Location = new System.Drawing.Point(297, 13);
            this.cbox_date.Name = "cbox_date";
            this.cbox_date.Size = new System.Drawing.Size(61, 33);
            this.cbox_date.TabIndex = 9;
            this.cbox_date.SelectedIndexChanged += new System.EventHandler(this.cbox_date_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(364, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "日";
            // 
            // cbox_year
            // 
            this.cbox_year.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox_year.FormattingEnabled = true;
            this.cbox_year.Items.AddRange(new object[] {
            "2024"});
            this.cbox_year.Location = new System.Drawing.Point(51, 13);
            this.cbox_year.Name = "cbox_year";
            this.cbox_year.Size = new System.Drawing.Size(97, 33);
            this.cbox_year.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(154, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "年";
            // 
            // cbox_month
            // 
            this.cbox_month.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox_month.FormattingEnabled = true;
            this.cbox_month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbox_month.Location = new System.Drawing.Point(192, 13);
            this.cbox_month.Name = "cbox_month";
            this.cbox_month.Size = new System.Drawing.Size(61, 33);
            this.cbox_month.TabIndex = 4;
            this.cbox_month.SelectedIndexChanged += new System.EventHandler(this.cbox_month_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(259, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "月";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel_top2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1466, 856);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "無";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel_top2
            // 
            this.panel_top2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_top2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top2.Location = new System.Drawing.Point(3, 3);
            this.panel_top2.Name = "panel_top2";
            this.panel_top2.Size = new System.Drawing.Size(1460, 59);
            this.panel_top2.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.crown;
            this.pictureBox2.Location = new System.Drawing.Point(13, 351);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pbox_topOne
            // 
            this.pbox_topOne.ErrorImage = null;
            this.pbox_topOne.InitialImage = null;
            this.pbox_topOne.Location = new System.Drawing.Point(59, 428);
            this.pbox_topOne.Name = "pbox_topOne";
            this.pbox_topOne.Size = new System.Drawing.Size(293, 358);
            this.pbox_topOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_topOne.TabIndex = 2;
            this.pbox_topOne.TabStop = false;
            // 
            // Report_Center
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1686, 976);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel_nav);
            this.Name = "Report_Center";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_Center";
            this.Load += new System.EventHandler(this.Report_Center_Load);
            this.panel_nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabpage1.ResumeLayout(false);
            this.tabpage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_topOne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpage1;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.ComboBox cbox_month;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private LiveCharts.Wpf.CartesianChart Chart2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel_top2;
        private System.Windows.Forms.ComboBox cbox_year;
        private System.Windows.Forms.Label label2;
        private LiveCharts.Wpf.CartesianChart Chart1;
        private System.Windows.Forms.ComboBox cbox_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_sale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_movieSale;
        private System.Windows.Forms.Label lbl_saleTitle;
        private System.Windows.Forms.PictureBox pbox_topOne;
        private System.Windows.Forms.Label lbl_ratingTitle;
        private System.Windows.Forms.Label lbl_rating;
        private System.Windows.Forms.Label lbl_saleInfo;
        private System.Windows.Forms.Label lbl_topOne;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}