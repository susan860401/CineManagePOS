using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class MemberManagement : Form
    {
        public MemberManagement()
        {
            InitializeComponent();
        }

        private void MemberManagement_Load(object sender, EventArgs e)
        {
            dataView_member.DataSource = Member.LoadMemberList(); //加載會員資料
            lbl_count.Text = $"共 {Member.LoadMemberList().Rows.Count} 筆";
            cbox_search.SelectedIndex = 1;   //搜尋基準設定為以姓名搜尋

            //顏色設定
            dataView_member.BackgroundColor = Color.White;  //表格背景色
            panel_nav.BackColor = ColorTranslator.FromHtml("#2F3645");  //左側導覽列
            panel_top.BackColor = ColorTranslator.FromHtml("#939185");  //右側上方
            panel_top2.BackColor = ColorTranslator.FromHtml("#939185");  //右側上方
            //特殊色
            //dataView_member.DefaultCellStyle.BackColor = Color.White;
            //dataView_member.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            


            txt_memberID.Text = Member.GenerateMemberID();

        }

        //顯示全部的會員
        private void btn_showAllMember_Click(object sender, EventArgs e)
        {
            dataView_member.DataSource = Member.LoadMemberList();
            lbl_count.Text = $"共 {Member.LoadMemberList().Rows.Count} 筆";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //三種情況:使用id/姓名/手機搜尋                
            if (cbox_search.SelectedIndex == 0)
            {
                //以會員卡號搜尋
                var searchResult = Member.searchMember("卡號", txt_search.Text);
                dataView_member.DataSource = searchResult;
                lbl_count.Text = $"共 {searchResult.Rows.Count} 筆";
            }
            else if (cbox_search.SelectedIndex == 2)
            {
                //以手機搜尋
                var searchResult = Member.searchMember("手機", txt_search.Text);
                dataView_member.DataSource = searchResult;
                lbl_count.Text = $"共 {searchResult.Rows.Count} 筆";
            }
            
        }

        //按enter鍵搜尋
        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  //如果是按enter鍵
            {
                // 防止按下 Enter 鍵時，焦點離開 TextBox
                e.SuppressKeyPress = true;
                //三種情況:使用id/姓名/手機搜尋                
                if (cbox_search.SelectedIndex == 0)
                {
                    //以會員卡號搜尋
                    var searchResult = Member.searchMember("卡號", txt_search.Text);
                    dataView_member.DataSource = searchResult;
                    lbl_count.Text = $"共 {searchResult.Rows.Count} 筆";
                }
                else if (cbox_search.SelectedIndex == 2)
                {
                    //以手機搜尋
                    var searchResult = Member.searchMember("手機", txt_search.Text);
                    dataView_member.DataSource = searchResult;
                    lbl_count.Text = $"共 {searchResult.Rows.Count} 筆";
                }
            }
        }

        //如果搜尋的內容改變(當使用姓名搜尋)
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (cbox_search.SelectedIndex == 1)
            {
                var searchResult = Member.searchMemberUseName(txt_search.Text);
                dataView_member.DataSource = searchResult;
                lbl_count.Text = $"共 {searchResult} 筆";
            }
        }

        //當選擇日期改變
        private void dtp_signUp_ValueChanged(object sender, EventArgs e)
        {
            var searchResult = Member.searchMemberUseDate(dtp_signUp.Value.Date);
            dataView_member.DataSource = searchResult;
            lbl_count.Text = $"共 {searchResult.Rows.Count} 筆";
        }


        //function:清空會員輸入內容
        private void clearEnterContent()
        {
            txt_name.Text = ""; //姓名
                                //性別
            if (radio_boy.Checked)
            {
                radio_boy.Checked = false;
            }
            else if (radio_girl.Checked)
            {
                radio_girl.Checked = false;
            }
            txt_phone.Text = "";
            dtp_birthday.Value = DateTime.Now;
            dtp_join.Value = DateTime.Now;

        }


        //清空輸入欄位
        private void btn_clearContent_Click(object sender, EventArgs e)
        {
            clearEnterContent();
        }

        //創建會員
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (radio_boy.Checked)
            {
                Member.AddNewMember(txt_memberID.Text, txt_name.Text, "M", dtp_birthday.Value, txt_phone.Text, Convert.ToInt32(txt_bonus.Text), dtp_join.Value);
            }
            else if (radio_girl.Checked)
            {
                Member.AddNewMember(txt_memberID.Text, txt_name.Text, "F", dtp_birthday.Value, txt_phone.Text, Convert.ToInt32(txt_bonus.Text), dtp_join.Value);
            }
            //創建成功後，清空欄位，並換成新的會員卡號(可繼續創建)
            txt_memberID.Text = Member.GenerateMemberID();
            clearEnterContent();
            dataView_member.DataSource = Member.LoadMemberList(); //更新會員列表
            lbl_count.Text = $"共 {Member.LoadMemberList().Rows.Count} 筆";
                
        }



        //事件:刪除會員資料(可刪除多行)
        private void btn_deleteMember_Click(object sender, EventArgs e)
        {
            if (dataView_member.SelectedRows.Count > 0)  //如果有選取會員列表的某一行
            {                
                DialogResult result = MessageBox.Show("確定要刪除選中的會員嗎?", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)  //如果確認要刪除
                {
                    //遍歷所有選中的行
                    foreach (DataGridViewRow row in dataView_member.SelectedRows) 
                    {
                        // 假設MemberID是第一列
                        string memberId = row.Cells[0].Value.ToString();

                        // 執行刪除操作
                        Member.DeleteMember(memberId);
                    }
                    // 刷新會員列表
                    dataView_member.DataSource = Member.LoadMemberList();
                    lbl_count.Text = $"共 {Member.LoadMemberList().Rows.Count} 筆";
                }
            }
            else
            {
                MessageBox.Show("請選擇要刪除的會員。","提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        
        //進入修改會員資料頁面，
        private void btn_toModifyMember_Click(object sender, EventArgs e)
        {
            string memberID = dataView_member.SelectedRows[0].Cells[0].Value.ToString();
            string memberName = dataView_member.SelectedRows[0].Cells[1].Value.ToString();
            string gender = dataView_member.SelectedRows[0].Cells[2].Value.ToString();
            DateTime dateOfBirth = Convert.ToDateTime(dataView_member.SelectedRows[0].Cells[3].Value);
            string phoneNumber = dataView_member.SelectedRows[0].Cells[4].Value.ToString();
            int bonusPoint = Convert.ToInt32(dataView_member.SelectedRows[0].Cells[5].Value);
            DateTime signupDate = Convert.ToDateTime(dataView_member.SelectedRows[0].Cells[6].Value);
            ModifyMember ModifyMember = new ModifyMember(memberID, memberName, gender, dateOfBirth, phoneNumber, bonusPoint, signupDate);
            // 訂閱事件，當會員資料修改成功後，更新 DataGridView
            ModifyMember.MemberModified += ModifyMemberfForm_MemberModified;
            ModifyMember.ShowDialog();

           
        }

        //事件:ModifyMember Form的MemberModified綁定的事件
        private void ModifyMemberfForm_MemberModified()
        {
            dataView_member.DataSource = Member.LoadMemberList();
            lbl_count.Text = $"共 {Member.LoadMemberList().Rows.Count} 筆";
        }

        //跳轉到訂單管理頁面
        private void button2_Click(object sender, EventArgs e)
        {
            OrderManagement form_orderManage = new OrderManagement();
            this.Hide();
            form_orderManage.ShowDialog() ;
            this.Close();
        }
    }
}
