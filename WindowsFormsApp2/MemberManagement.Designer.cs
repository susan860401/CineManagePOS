namespace WindowsFormsApp2
{
    partial class MemberManagement
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.cbox_search = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_showAllMember = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.dtp_signUp = new System.Windows.Forms.DateTimePicker();
            this.btn_deleteMember = new System.Windows.Forms.Button();
            this.btn_toModifyMember = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataView_member = new System.Windows.Forms.DataGridView();
            this.page_createMember = new System.Windows.Forms.TabPage();
            this.panel_top2 = new System.Windows.Forms.Panel();
            this.btn_clearContent = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.group_addMember = new System.Windows.Forms.GroupBox();
            this.dtp_join = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_bonus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.radio_girl = new System.Windows.Forms.RadioButton();
            this.radio_boy = new System.Windows.Forms.RadioButton();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_memberID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView_member)).BeginInit();
            this.page_createMember.SuspendLayout();
            this.group_addMember.SuspendLayout();
            this.panel_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.page_createMember);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1119, 812);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_count);
            this.tabPage1.Controls.Add(this.panel_top);
            this.tabPage1.Controls.Add(this.dtp_signUp);
            this.tabPage1.Controls.Add(this.btn_deleteMember);
            this.tabPage1.Controls.Add(this.btn_toModifyMember);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataView_member);
            this.tabPage1.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1111, 777);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "會員管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.BackColor = System.Drawing.Color.LightGray;
            this.lbl_count.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_count.Location = new System.Drawing.Point(934, 110);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(55, 22);
            this.lbl_count.TabIndex = 14;
            this.lbl_count.Text = "共X筆";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_top.Controls.Add(this.cbox_search);
            this.panel_top.Controls.Add(this.txt_search);
            this.panel_top.Controls.Add(this.btn_showAllMember);
            this.panel_top.Controls.Add(this.btn_search);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(3, 3);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1105, 59);
            this.panel_top.TabIndex = 13;
            // 
            // cbox_search
            // 
            this.cbox_search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox_search.FormattingEnabled = true;
            this.cbox_search.Items.AddRange(new object[] {
            "卡號",
            "姓名",
            "手機"});
            this.cbox_search.Location = new System.Drawing.Point(68, 14);
            this.cbox_search.Name = "cbox_search";
            this.cbox_search.Size = new System.Drawing.Size(83, 33);
            this.cbox_search.TabIndex = 2;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_search.Location = new System.Drawing.Point(178, 13);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(208, 34);
            this.txt_search.TabIndex = 3;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            // 
            // btn_showAllMember
            // 
            this.btn_showAllMember.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_showAllMember.Location = new System.Drawing.Point(924, 5);
            this.btn_showAllMember.Name = "btn_showAllMember";
            this.btn_showAllMember.Size = new System.Drawing.Size(160, 47);
            this.btn_showAllMember.TabIndex = 11;
            this.btn_showAllMember.Text = "顯示會員列表";
            this.btn_showAllMember.UseVisualStyleBackColor = true;
            this.btn_showAllMember.Click += new System.EventHandler(this.btn_showAllMember_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_search.Location = new System.Drawing.Point(438, 14);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(99, 34);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "搜尋";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dtp_signUp
            // 
            this.dtp_signUp.Location = new System.Drawing.Point(181, 76);
            this.dtp_signUp.Name = "dtp_signUp";
            this.dtp_signUp.Size = new System.Drawing.Size(207, 31);
            this.dtp_signUp.TabIndex = 8;
            this.dtp_signUp.ValueChanged += new System.EventHandler(this.dtp_signUp_ValueChanged);
            // 
            // btn_deleteMember
            // 
            this.btn_deleteMember.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_deleteMember.Location = new System.Drawing.Point(877, 580);
            this.btn_deleteMember.Name = "btn_deleteMember";
            this.btn_deleteMember.Size = new System.Drawing.Size(130, 34);
            this.btn_deleteMember.TabIndex = 7;
            this.btn_deleteMember.Text = "刪除資料";
            this.btn_deleteMember.UseVisualStyleBackColor = true;
            this.btn_deleteMember.Click += new System.EventHandler(this.btn_deleteMember_Click);
            // 
            // btn_toModifyMember
            // 
            this.btn_toModifyMember.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_toModifyMember.Location = new System.Drawing.Point(717, 580);
            this.btn_toModifyMember.Name = "btn_toModifyMember";
            this.btn_toModifyMember.Size = new System.Drawing.Size(130, 34);
            this.btn_toModifyMember.TabIndex = 6;
            this.btn_toModifyMember.Text = "修改資料";
            this.btn_toModifyMember.UseVisualStyleBackColor = true;
            this.btn_toModifyMember.Click += new System.EventHandler(this.btn_toModifyMember_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(66, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "申辦日期";
            // 
            // dataView_member
            // 
            this.dataView_member.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataView_member.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataView_member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView_member.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataView_member.Location = new System.Drawing.Point(73, 138);
            this.dataView_member.Name = "dataView_member";
            this.dataView_member.RowHeadersWidth = 51;
            this.dataView_member.RowTemplate.Height = 27;
            this.dataView_member.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView_member.Size = new System.Drawing.Size(934, 406);
            this.dataView_member.TabIndex = 0;
            // 
            // page_createMember
            // 
            this.page_createMember.BackColor = System.Drawing.Color.White;
            this.page_createMember.Controls.Add(this.panel_top2);
            this.page_createMember.Controls.Add(this.btn_clearContent);
            this.page_createMember.Controls.Add(this.btn_submit);
            this.page_createMember.Controls.Add(this.group_addMember);
            this.page_createMember.Location = new System.Drawing.Point(4, 31);
            this.page_createMember.Name = "page_createMember";
            this.page_createMember.Padding = new System.Windows.Forms.Padding(3);
            this.page_createMember.Size = new System.Drawing.Size(1111, 777);
            this.page_createMember.TabIndex = 1;
            this.page_createMember.Text = "會員創建";
            // 
            // panel_top2
            // 
            this.panel_top2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_top2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top2.Location = new System.Drawing.Point(3, 3);
            this.panel_top2.Name = "panel_top2";
            this.panel_top2.Size = new System.Drawing.Size(1105, 59);
            this.panel_top2.TabIndex = 18;
            // 
            // btn_clearContent
            // 
            this.btn_clearContent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_clearContent.Location = new System.Drawing.Point(481, 596);
            this.btn_clearContent.Name = "btn_clearContent";
            this.btn_clearContent.Size = new System.Drawing.Size(125, 48);
            this.btn_clearContent.TabIndex = 17;
            this.btn_clearContent.Text = "清空內容";
            this.btn_clearContent.UseVisualStyleBackColor = true;
            this.btn_clearContent.Click += new System.EventHandler(this.btn_clearContent_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_submit.Location = new System.Drawing.Point(612, 596);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(125, 48);
            this.btn_submit.TabIndex = 16;
            this.btn_submit.Text = "確認送出";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // group_addMember
            // 
            this.group_addMember.BackColor = System.Drawing.Color.WhiteSmoke;
            this.group_addMember.Controls.Add(this.dtp_join);
            this.group_addMember.Controls.Add(this.label9);
            this.group_addMember.Controls.Add(this.txt_bonus);
            this.group_addMember.Controls.Add(this.label7);
            this.group_addMember.Controls.Add(this.dtp_birthday);
            this.group_addMember.Controls.Add(this.radio_girl);
            this.group_addMember.Controls.Add(this.radio_boy);
            this.group_addMember.Controls.Add(this.txt_phone);
            this.group_addMember.Controls.Add(this.label8);
            this.group_addMember.Controls.Add(this.label6);
            this.group_addMember.Controls.Add(this.label5);
            this.group_addMember.Controls.Add(this.txt_name);
            this.group_addMember.Controls.Add(this.label4);
            this.group_addMember.Controls.Add(this.txt_memberID);
            this.group_addMember.Controls.Add(this.label3);
            this.group_addMember.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.group_addMember.Location = new System.Drawing.Point(309, 124);
            this.group_addMember.Name = "group_addMember";
            this.group_addMember.Size = new System.Drawing.Size(430, 440);
            this.group_addMember.TabIndex = 15;
            this.group_addMember.TabStop = false;
            this.group_addMember.Text = "會員創建";
            // 
            // dtp_join
            // 
            this.dtp_join.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_join.Location = new System.Drawing.Point(182, 381);
            this.dtp_join.Name = "dtp_join";
            this.dtp_join.Size = new System.Drawing.Size(201, 34);
            this.dtp_join.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(64, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "加入日期：";
            // 
            // txt_bonus
            // 
            this.txt_bonus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_bonus.Location = new System.Drawing.Point(182, 323);
            this.txt_bonus.Name = "txt_bonus";
            this.txt_bonus.ReadOnly = true;
            this.txt_bonus.Size = new System.Drawing.Size(201, 34);
            this.txt_bonus.TabIndex = 27;
            this.txt_bonus.Text = "50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(64, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "紅利點數：";
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_birthday.Location = new System.Drawing.Point(182, 216);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(201, 34);
            this.dtp_birthday.TabIndex = 25;
            // 
            // radio_girl
            // 
            this.radio_girl.AutoSize = true;
            this.radio_girl.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radio_girl.Location = new System.Drawing.Point(258, 168);
            this.radio_girl.Name = "radio_girl";
            this.radio_girl.Size = new System.Drawing.Size(53, 29);
            this.radio_girl.TabIndex = 24;
            this.radio_girl.TabStop = true;
            this.radio_girl.Text = "女";
            this.radio_girl.UseVisualStyleBackColor = true;
            // 
            // radio_boy
            // 
            this.radio_boy.AutoSize = true;
            this.radio_boy.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radio_boy.Location = new System.Drawing.Point(182, 168);
            this.radio_boy.Name = "radio_boy";
            this.radio_boy.Size = new System.Drawing.Size(53, 29);
            this.radio_boy.TabIndex = 23;
            this.radio_boy.TabStop = true;
            this.radio_boy.Text = "男";
            this.radio_boy.UseVisualStyleBackColor = true;
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_phone.Location = new System.Drawing.Point(182, 267);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(201, 34);
            this.txt_phone.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(64, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "手機號碼：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(64, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "性別：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(64, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "生日：";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_name.Location = new System.Drawing.Point(182, 111);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(201, 34);
            this.txt_name.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(64, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "姓名：";
            // 
            // txt_memberID
            // 
            this.txt_memberID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_memberID.Location = new System.Drawing.Point(182, 64);
            this.txt_memberID.Name = "txt_memberID";
            this.txt_memberID.ReadOnly = true;
            this.txt_memberID.Size = new System.Drawing.Size(201, 34);
            this.txt_memberID.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(64, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "會員卡號：";
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
            this.panel_nav.Size = new System.Drawing.Size(172, 812);
            this.panel_nav.TabIndex = 5;
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
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(14, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 46);
            this.button3.TabIndex = 17;
            this.button3.Text = "電影管理";
            this.button3.UseVisualStyleBackColor = true;
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(172, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 812);
            this.panel1.TabIndex = 6;
            // 
            // MemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 812);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_nav);
            this.Name = "MemberManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "會員管理系統";
            this.Load += new System.EventHandler(this.MemberManagement_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView_member)).EndInit();
            this.page_createMember.ResumeLayout(false);
            this.group_addMember.ResumeLayout(false);
            this.group_addMember.PerformLayout();
            this.panel_nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage page_createMember;
        private System.Windows.Forms.DataGridView dataView_member;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cbox_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_deleteMember;
        private System.Windows.Forms.Button btn_toModifyMember;
        private System.Windows.Forms.DateTimePicker dtp_signUp;
        private System.Windows.Forms.Button btn_showAllMember;
        private System.Windows.Forms.GroupBox group_addMember;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.RadioButton radio_girl;
        private System.Windows.Forms.RadioButton radio_boy;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_memberID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_join;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_bonus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_clearContent;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Panel panel_top2;
    }
}