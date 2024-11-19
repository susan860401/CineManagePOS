namespace WindowsFormsApp2
{
    partial class OrderManagement
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_count = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ticketType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_seatNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ticket = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_theater = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_time = new System.Windows.Forms.DateTimePicker();
            this.btn_refund = new System.Windows.Forms.Button();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.btn_sup = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_movie = new System.Windows.Forms.TextBox();
            this.panel_top = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.cbox_search = new System.Windows.Forms.ComboBox();
            this.txt_SearchOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataView_orderList = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flow_tickets = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_top2 = new System.Windows.Forms.Panel();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_toMovieManage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_searchShowTime = new System.Windows.Forms.TextBox();
            this.btn_showList = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView_orderList)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(172, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1119, 812);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_count);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.panel_top);
            this.tabPage1.Controls.Add(this.dataView_orderList);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1111, 777);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "訂單管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.BackColor = System.Drawing.Color.LightGray;
            this.lbl_count.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_count.Location = new System.Drawing.Point(589, 86);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(55, 22);
            this.lbl_count.TabIndex = 26;
            this.lbl_count.Text = "共X筆";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.txt_ticketType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_seatNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_ticket);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_theater);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtp_time);
            this.groupBox1.Controls.Add(this.btn_refund);
            this.groupBox1.Controls.Add(this.dtp_date);
            this.groupBox1.Controls.Add(this.btn_sup);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_movie);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(707, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 605);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "訂單資訊";
            // 
            // txt_ticketType
            // 
            this.txt_ticketType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ticketType.Location = new System.Drawing.Point(124, 246);
            this.txt_ticketType.Multiline = true;
            this.txt_ticketType.Name = "txt_ticketType";
            this.txt_ticketType.ReadOnly = true;
            this.txt_ticketType.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ticketType.Size = new System.Drawing.Size(237, 63);
            this.txt_ticketType.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(6, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "票種：";
            // 
            // txt_seatNum
            // 
            this.txt_seatNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_seatNum.Location = new System.Drawing.Point(124, 374);
            this.txt_seatNum.Name = "txt_seatNum";
            this.txt_seatNum.ReadOnly = true;
            this.txt_seatNum.Size = new System.Drawing.Size(237, 34);
            this.txt_seatNum.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(6, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "座位編號：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "電影名稱：";
            // 
            // txt_ticket
            // 
            this.txt_ticket.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ticket.Location = new System.Drawing.Point(124, 329);
            this.txt_ticket.Name = "txt_ticket";
            this.txt_ticket.ReadOnly = true;
            this.txt_ticket.Size = new System.Drawing.Size(237, 34);
            this.txt_ticket.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(6, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "場次日期：";
            // 
            // txt_theater
            // 
            this.txt_theater.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_theater.Location = new System.Drawing.Point(124, 191);
            this.txt_theater.Name = "txt_theater";
            this.txt_theater.ReadOnly = true;
            this.txt_theater.Size = new System.Drawing.Size(237, 34);
            this.txt_theater.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(6, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "影廳：";
            // 
            // dtp_time
            // 
            this.dtp_time.CustomFormat = "HH:mm";
            this.dtp_time.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_time.Location = new System.Drawing.Point(125, 142);
            this.dtp_time.Name = "dtp_time";
            this.dtp_time.Size = new System.Drawing.Size(236, 34);
            this.dtp_time.TabIndex = 22;
            // 
            // btn_refund
            // 
            this.btn_refund.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_refund.Location = new System.Drawing.Point(75, 544);
            this.btn_refund.Name = "btn_refund";
            this.btn_refund.Size = new System.Drawing.Size(107, 49);
            this.btn_refund.TabIndex = 15;
            this.btn_refund.Text = "退票";
            this.btn_refund.UseVisualStyleBackColor = true;
            this.btn_refund.Click += new System.EventHandler(this.btn_refund_Click);
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_date.Location = new System.Drawing.Point(125, 95);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(236, 34);
            this.dtp_date.TabIndex = 21;
            // 
            // btn_sup
            // 
            this.btn_sup.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sup.Location = new System.Drawing.Point(202, 544);
            this.btn_sup.Name = "btn_sup";
            this.btn_sup.Size = new System.Drawing.Size(113, 49);
            this.btn_sup.TabIndex = 16;
            this.btn_sup.Text = "補票";
            this.btn_sup.UseVisualStyleBackColor = true;
            this.btn_sup.Click += new System.EventHandler(this.btn_sup_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(6, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "場次時間：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(6, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "購票張數：";
            // 
            // txt_movie
            // 
            this.txt_movie.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_movie.Location = new System.Drawing.Point(124, 49);
            this.txt_movie.Name = "txt_movie";
            this.txt_movie.ReadOnly = true;
            this.txt_movie.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_movie.Size = new System.Drawing.Size(237, 34);
            this.txt_movie.TabIndex = 18;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_top.Controls.Add(this.btn_showList);
            this.panel_top.Controls.Add(this.btn_search);
            this.panel_top.Controls.Add(this.cbox_search);
            this.panel_top.Controls.Add(this.txt_SearchOrder);
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(3, 3);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1105, 59);
            this.panel_top.TabIndex = 9;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_search.Location = new System.Drawing.Point(484, 16);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(92, 32);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "搜尋";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cbox_search
            // 
            this.cbox_search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox_search.FormattingEnabled = true;
            this.cbox_search.Items.AddRange(new object[] {
            "會員卡號",
            "訂單編號"});
            this.cbox_search.Location = new System.Drawing.Point(113, 15);
            this.cbox_search.Name = "cbox_search";
            this.cbox_search.Size = new System.Drawing.Size(123, 33);
            this.cbox_search.TabIndex = 4;
            // 
            // txt_SearchOrder
            // 
            this.txt_SearchOrder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_SearchOrder.Location = new System.Drawing.Point(248, 15);
            this.txt_SearchOrder.Name = "txt_SearchOrder";
            this.txt_SearchOrder.Size = new System.Drawing.Size(229, 34);
            this.txt_SearchOrder.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "查詢";
            // 
            // dataView_orderList
            // 
            this.dataView_orderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataView_orderList.BackgroundColor = System.Drawing.Color.White;
            this.dataView_orderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataView_orderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView_orderList.GridColor = System.Drawing.Color.Silver;
            this.dataView_orderList.Location = new System.Drawing.Point(20, 112);
            this.dataView_orderList.MultiSelect = false;
            this.dataView_orderList.Name = "dataView_orderList";
            this.dataView_orderList.ReadOnly = true;
            this.dataView_orderList.RowHeadersWidth = 51;
            this.dataView_orderList.RowTemplate.Height = 27;
            this.dataView_orderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView_orderList.Size = new System.Drawing.Size(652, 622);
            this.dataView_orderList.TabIndex = 1;
            this.dataView_orderList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_orderList_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flow_tickets);
            this.tabPage2.Controls.Add(this.panel_top2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1111, 777);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "票根補發";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flow_tickets
            // 
            this.flow_tickets.AutoScroll = true;
            this.flow_tickets.Location = new System.Drawing.Point(325, 108);
            this.flow_tickets.Name = "flow_tickets";
            this.flow_tickets.Size = new System.Drawing.Size(462, 627);
            this.flow_tickets.TabIndex = 11;
            // 
            // panel_top2
            // 
            this.panel_top2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_top2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top2.Location = new System.Drawing.Point(3, 3);
            this.panel_top2.Name = "panel_top2";
            this.panel_top2.Size = new System.Drawing.Size(1105, 59);
            this.panel_top2.TabIndex = 10;
            // 
            // panel_nav
            // 
            this.panel_nav.BackColor = System.Drawing.Color.White;
            this.panel_nav.Controls.Add(this.pictureBox1);
            this.panel_nav.Controls.Add(this.button6);
            this.panel_nav.Controls.Add(this.button4);
            this.panel_nav.Controls.Add(this.btn_toMovieManage);
            this.panel_nav.Controls.Add(this.button2);
            this.panel_nav.Controls.Add(this.button1);
            this.panel_nav.Controls.Add(this.button5);
            this.panel_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_nav.Location = new System.Drawing.Point(0, 0);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(172, 812);
            this.panel_nav.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 123);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.Location = new System.Drawing.Point(35, 682);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 46);
            this.button6.TabIndex = 19;
            this.button6.Text = "登出";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(16, 419);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 46);
            this.button4.TabIndex = 18;
            this.button4.Text = "報表中心";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_toMovieManage
            // 
            this.btn_toMovieManage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_toMovieManage.Location = new System.Drawing.Point(14, 354);
            this.btn_toMovieManage.Name = "btn_toMovieManage";
            this.btn_toMovieManage.Size = new System.Drawing.Size(144, 46);
            this.btn_toMovieManage.TabIndex = 17;
            this.btn_toMovieManage.Text = "電影管理";
            this.btn_toMovieManage.UseVisualStyleBackColor = true;
            this.btn_toMovieManage.Click += new System.EventHandler(this.btn_toMovieManage_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(14, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 46);
            this.button2.TabIndex = 16;
            this.button2.Text = "訂單管理";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(14, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 46);
            this.button1.TabIndex = 15;
            this.button1.Text = "電影售票";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(14, 222);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 46);
            this.button5.TabIndex = 14;
            this.button5.Text = "會員管理";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 2;
            // 
            // txt_searchShowTime
            // 
            this.txt_searchShowTime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_searchShowTime.Location = new System.Drawing.Point(153, 15);
            this.txt_searchShowTime.Name = "txt_searchShowTime";
            this.txt_searchShowTime.Size = new System.Drawing.Size(229, 34);
            this.txt_searchShowTime.TabIndex = 3;
            // 
            // btn_showList
            // 
            this.btn_showList.Location = new System.Drawing.Point(892, 13);
            this.btn_showList.Name = "btn_showList";
            this.btn_showList.Size = new System.Drawing.Size(185, 34);
            this.btn_showList.TabIndex = 6;
            this.btn_showList.Text = "顯示訂單列表";
            this.btn_showList.UseVisualStyleBackColor = true;
            this.btn_showList.Click += new System.EventHandler(this.btn_showList_Click);
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 812);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel_nav);
            this.Name = "OrderManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "訂單管理";
            this.Load += new System.EventHandler(this.OrderManagement_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView_orderList)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel_nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.TextBox txt_SearchOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataView_orderList;
        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_toMovieManage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_sup;
        private System.Windows.Forms.Button btn_refund;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ticket;
        private System.Windows.Forms.TextBox txt_theater;
        private System.Windows.Forms.DateTimePicker dtp_time;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_movie;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel_top2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_searchShowTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_seatNum;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txt_ticketType;
        private System.Windows.Forms.FlowLayoutPanel flow_tickets;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cbox_search;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Button btn_showList;
    }
}