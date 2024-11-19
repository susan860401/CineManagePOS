namespace WindowsFormsApp2
{
    partial class Ticket
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.label44 = new System.Windows.Forms.Label();
            this.Pbox_qrcode = new System.Windows.Forms.PictureBox();
            this.label43 = new System.Windows.Forms.Label();
            this.lbl_memberID = new System.Windows.Forms.Label();
            this.lbl_bookingID = new System.Windows.Forms.Label();
            this.lbl_seatNum = new System.Windows.Forms.Label();
            this.lbl_ticketType = new System.Windows.Forms.Label();
            this.lbl_showtime = new System.Windows.Forms.Label();
            this.lbl_movieName = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbox_qrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label44);
            this.panel9.Controls.Add(this.Pbox_qrcode);
            this.panel9.Controls.Add(this.label43);
            this.panel9.Controls.Add(this.lbl_memberID);
            this.panel9.Controls.Add(this.lbl_bookingID);
            this.panel9.Controls.Add(this.lbl_seatNum);
            this.panel9.Controls.Add(this.lbl_ticketType);
            this.panel9.Controls.Add(this.lbl_showtime);
            this.panel9.Controls.Add(this.lbl_movieName);
            this.panel9.Controls.Add(this.label31);
            this.panel9.Location = new System.Drawing.Point(6, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(235, 378);
            this.panel9.TabIndex = 1;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label44.Location = new System.Drawing.Point(12, 168);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(71, 22);
            this.label44.TabIndex = 9;
            this.label44.Text = "[二維碼]";
            // 
            // Pbox_qrcode
            // 
            this.Pbox_qrcode.ErrorImage = null;
            this.Pbox_qrcode.InitialImage = null;
            this.Pbox_qrcode.Location = new System.Drawing.Point(42, 193);
            this.Pbox_qrcode.Name = "Pbox_qrcode";
            this.Pbox_qrcode.Size = new System.Drawing.Size(146, 142);
            this.Pbox_qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbox_qrcode.TabIndex = 8;
            this.Pbox_qrcode.TabStop = false;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label43.Location = new System.Drawing.Point(2, 347);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(231, 22);
            this.label43.TabIndex = 7;
            this.label43.Text = "備註：請保留此票根用於入場";
            // 
            // lbl_memberID
            // 
            this.lbl_memberID.AutoSize = true;
            this.lbl_memberID.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_memberID.Location = new System.Drawing.Point(12, 145);
            this.lbl_memberID.Name = "lbl_memberID";
            this.lbl_memberID.Size = new System.Drawing.Size(95, 22);
            this.lbl_memberID.TabIndex = 6;
            this.lbl_memberID.Text = "會員卡號：";
            // 
            // lbl_bookingID
            // 
            this.lbl_bookingID.AutoSize = true;
            this.lbl_bookingID.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_bookingID.Location = new System.Drawing.Point(12, 122);
            this.lbl_bookingID.Name = "lbl_bookingID";
            this.lbl_bookingID.Size = new System.Drawing.Size(95, 22);
            this.lbl_bookingID.TabIndex = 5;
            this.lbl_bookingID.Text = "訂單編號：";
            // 
            // lbl_seatNum
            // 
            this.lbl_seatNum.AutoSize = true;
            this.lbl_seatNum.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_seatNum.Location = new System.Drawing.Point(12, 99);
            this.lbl_seatNum.Name = "lbl_seatNum";
            this.lbl_seatNum.Size = new System.Drawing.Size(95, 22);
            this.lbl_seatNum.TabIndex = 4;
            this.lbl_seatNum.Text = "座位編號：";
            // 
            // lbl_ticketType
            // 
            this.lbl_ticketType.AutoSize = true;
            this.lbl_ticketType.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ticketType.Location = new System.Drawing.Point(12, 77);
            this.lbl_ticketType.Name = "lbl_ticketType";
            this.lbl_ticketType.Size = new System.Drawing.Size(61, 22);
            this.lbl_ticketType.TabIndex = 3;
            this.lbl_ticketType.Text = "票種：";
            // 
            // lbl_showtime
            // 
            this.lbl_showtime.AutoSize = true;
            this.lbl_showtime.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_showtime.Location = new System.Drawing.Point(12, 54);
            this.lbl_showtime.Name = "lbl_showtime";
            this.lbl_showtime.Size = new System.Drawing.Size(95, 22);
            this.lbl_showtime.TabIndex = 2;
            this.lbl_showtime.Text = "場次時間：";
            // 
            // lbl_movieName
            // 
            this.lbl_movieName.AutoSize = true;
            this.lbl_movieName.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_movieName.Location = new System.Drawing.Point(12, 31);
            this.lbl_movieName.Name = "lbl_movieName";
            this.lbl_movieName.Size = new System.Drawing.Size(95, 22);
            this.lbl_movieName.TabIndex = 1;
            this.lbl_movieName.Text = "電影名稱：";
            // 
            // label31
            // 
            this.label31.Dock = System.Windows.Forms.DockStyle.Top;
            this.label31.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label31.Location = new System.Drawing.Point(0, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(233, 32);
            this.label31.TabIndex = 0;
            this.label31.Text = "電影票根";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel9);
            this.Name = "Ticket";
            this.Size = new System.Drawing.Size(247, 385);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbox_qrcode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label31;
        public System.Windows.Forms.PictureBox Pbox_qrcode;
        public System.Windows.Forms.Label lbl_memberID;
        public System.Windows.Forms.Label lbl_bookingID;
        public System.Windows.Forms.Label lbl_seatNum;
        public System.Windows.Forms.Label lbl_ticketType;
        public System.Windows.Forms.Label lbl_showtime;
        public System.Windows.Forms.Label lbl_movieName;
    }
}
