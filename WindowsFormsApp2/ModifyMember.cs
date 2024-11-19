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
    public partial class ModifyMember : Form  //修改會員表單
    {
        public event Action MemberModified;
        private string _memberID;
        private string _memberName;
        private string _gender;
        private DateTime _dateOfBirth;
        private string _phoneNumber;
        private int _bonusPoints;
        private DateTime _signupDate;


        //構造函數
        public ModifyMember(string memberID, string memberName, string gender, DateTime dateOfBirth, 
            string phoneNumber, int BonusPoints, DateTime signupDate)  
        {
            _memberID = memberID;
            _memberName = memberName;
            _gender = gender;
            _dateOfBirth = dateOfBirth;
            _phoneNumber = phoneNumber;
            _bonusPoints = BonusPoints; 
            _signupDate = signupDate;

            InitializeComponent();
        }

        //載入欲修改資料的原資料
        private void ModifyMember_Load(object sender, EventArgs e)
        {
            txt_modMemberID.Text = _memberID;
            txt_ModName.Text = _memberName;
            if (_gender == "M")
            {
                radio_modBoy.Checked = true;
            }
            else
            {
                radio_modGirl.Checked = true;
            }
            dtp_modBirthday.Value = _dateOfBirth;
            txt_Modphone.Text = _phoneNumber;
            txt_ModBonus.Text = _bonusPoints.ToString();
            dtp_modJoin.Value = _signupDate;
        }

        //事件:修改完畢送出修改
        private void btn_modifyMember_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radio_modBoy.Checked)
            {
                gender = "M";
            }
            else if (radio_modGirl.Checked)
            {
                gender = "F";
            }
            //把修改資料更新到資料庫
            Member.ModifyMember(txt_modMemberID.Text, txt_ModName.Text, gender, dtp_modBirthday.Value,
            txt_Modphone.Text, txt_ModBonus.Text, dtp_modJoin.Value);

            //觸發事件，通知主表單(會員資料管理系統表單)會員資料已修改
            MemberModified?.Invoke();

            //關閉此表單
            this.Close();

        }



    }
}
