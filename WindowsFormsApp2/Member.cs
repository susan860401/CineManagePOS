using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class Member  //會員相關
    {
        //靜態變數(所有實例共享)
        public static string memberName = "";
        public static int bonusPoint = 0;

        //加載會員資料
        public static DataTable LoadMemberList()
        {
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                try
                {
                    conn.Open();

                    //查詢，這是不需要加入參數情況(載入全部資料)，所以不需要用sql command
                    string query = "SELECT memberID AS 卡號, memberName AS 姓名, Gender As 性別, DateOfBirth AS 生日, phoneNumber AS 電話, BonusPoints AS 紅利, signUpDate AS 加入日期 FROM Members";
                    // SqlDataAdapter為資料來源(資料庫等)及資料集之間填充數據的橋樑
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return new DataTable(); // 返回空的 DataTable，為了要有東西return

                }
            }
        }

        //驗證會員卡號輸入格式是否正確(售票系統、會員管理系統皆會使用)

        private static bool IsInputFormatValid(string input) 
        {
            // 正則表達式：驗證格式是否為 M + 10 位數字
            string pattern = @"^M\d{10}$";
            Regex regex = new Regex(pattern);

            // 檢查輸入是否符合正則表達式
            return regex.IsMatch(input);
        }

        //驗證是否為有效會員-透過"會員卡號"查詢((售票系統確認會員身分使用)
        public static bool IsValidMember(string memberID)
        {
            //若格式正確
            if (IsInputFormatValid(memberID))
            {
                using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
                {
                    conn.Open();  //打開資料庫
                                  //創建命令--搜尋會員              
                    SqlCommand cmd_searchMember = new SqlCommand();
                    cmd_searchMember.Connection = conn;
                    // 添加參數
                    cmd_searchMember.Parameters.AddWithValue("@memberID", memberID);
                    //使用參數查詢
                    cmd_searchMember.CommandText = "SELECT memberID, memberName, BonusPoints FROM members " + "Where memberID = @memberID;";

                    SqlDataReader reader_searchMember = cmd_searchMember.ExecuteReader();


                    if (reader_searchMember.HasRows)
                    {
                        //如果有查詢結果
                        reader_searchMember.Read();
                        memberName = reader_searchMember.GetValue(1).ToString();
                        bonusPoint = Convert.ToInt32(reader_searchMember.GetValue(2));
                        return true;                       
                    }
                    else
                    {
                        MessageBox.Show("查無此人");
                        return false;
                    }
                }
            }
            else
            {
               ///若輸入格式不正確
                MessageBox.Show("輸入格式錯誤，請重新輸入");
                return false;
            }


            
        }

        //會員查詢-(可依照卡號、手機查詢-精確比對) -會員管理系統使用
        public static DataTable searchMember(string searchWay, string searchText)
        {
            if (searchWay == "卡號")
            {
                if (!IsInputFormatValid(searchText))
                {
                    ///卡號輸入格式不正確
                    MessageBox.Show("輸入格式錯誤，請重新輸入");
                    return LoadMemberList();
                }
            }
            //查詢語句，隨著查詢方法不同而不同(有以卡號/姓名/手機查詢三種方法)
            string query = "SELECT * FROM Members WHERE ";
            using (SqlCommand cmd_searchMember = new SqlCommand())
            {
                switch (searchWay)
                {
                    case "卡號":
                        query += "memberID = @searchText";
                        cmd_searchMember.CommandText = query;
                        break;
                    case "手機":
                        query += "phoneNumber = @searchText";
                        cmd_searchMember.CommandText = query;
                        break;
                }

                using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
                {
                    try
                    {
                        conn.Open();  //打開資料庫
                                      //查詢語句
                        cmd_searchMember.Parameters.AddWithValue("@searchText", searchText);
                        cmd_searchMember.Connection = conn;

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd_searchMember);
                        DataTable dataTable = new DataTable(); //創建一個表格
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {                            
                            return dataTable;
                        }
                        else
                        {
                            MessageBox.Show("查無此人");
                            return LoadMemberList();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                        return null;
                    }
                }
            }

        }

        //會員查詢-依照姓名(模糊比對) -會員管理系統使用
        public static DataTable searchMemberUseName(string searchText)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
                {
                    conn.Open();
                    string query = "SELECT * FROM Members WHERE memberName LIKE @searchText";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable(); //創建一個表格
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        return dataTable;
                    }
                    else
                    {
                        MessageBox.Show("查無此人");
                        return LoadMemberList();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"錯誤:{ex.Message}");
                return null;
            }           

        }

        //會員查詢-依照申辦日期查詢
        public static DataTable searchMemberUseDate(DateTime signUpDate)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
                {
                    conn.Open();
                    string query = "SELECT memberID AS 卡號, memberName AS 姓名, Gender As 性別, " +
                        "DateOfBirth AS 生日, phoneNumber AS 電話, BonusPoints AS 紅利, signUpDate AS 加入日期 " +
                        "FROM Members WHERE signUpDate = @signUpDate";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@signUpDate", signUpDate.Date);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable(); //創建一個表格
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        return dataTable;
                    }
                    else
                    {
                        MessageBox.Show("沒有資料");
                        return LoadMemberList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"錯誤:{ex.Message}");
                return null;
            }

        }



        //創建會員資料-生成卡號(格式-M+年(4碼)+月(4碼)+4碼數字(0001-9999)
        public static string GenerateMemberID()
        {
            DateTime currentTime = DateTime.Now;
            string newMemberID = $"M{currentTime:yyyyMM}";
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                try
                {
                    conn.Open();  //打開資料庫
                                  //查詢語句
                    string query = "Select MAX(memberID) From members;";
                    SqlCommand searchMaxMemberID = new SqlCommand(query, conn);
                    SqlDataReader reader_MaxMemberID = searchMaxMemberID.ExecuteReader();
                    reader_MaxMemberID.Read();
                    int currentMaxID = Convert.ToInt32(reader_MaxMemberID.GetValue(0).ToString().Substring(7));  //取後4碼
                    int newNumber = currentMaxID + 1;
                    newMemberID += newNumber.ToString("D4");
                    return newMemberID;  //將memberID返回到method
                }
                catch (Exception ex)
                {
                    MessageBox.Show("生成會員卡號時發生錯誤: " + ex.Message);
                    return null;
                }
            }

        }

        //創建會員-會員管理系統直接創建
        public static void AddNewMember(string memberID, string memberName, string gender, DateTime DateOfBirth,
            string phoneNumber, int BonusPoints, DateTime SignupDate)
        {
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                try
                {
                    conn.Open();  //打開資料庫
                    //查詢語句
                    string query = "INSERT INTO members(MemberID, MemberName, Gender, DateOfBirth, PhoneNumber, " +
                        "BonusPoints, SignupDate) Values(@memberID, @MemberName, @Gender, @DateOfBirth, @PhoneNumber, " +
                        "@BonusPoints, @SignupDate); ";
                    SqlCommand cmd_AddNewMember = new SqlCommand(query, conn);
                    cmd_AddNewMember.Parameters.AddWithValue("@MemberID", memberID);
                    cmd_AddNewMember.Parameters.AddWithValue("@MemberName", memberName);
                    cmd_AddNewMember.Parameters.AddWithValue("@Gender", gender);
                    cmd_AddNewMember.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    cmd_AddNewMember.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd_AddNewMember.Parameters.AddWithValue("@BonusPoints", BonusPoints);
                    cmd_AddNewMember.Parameters.AddWithValue("@SignupDate", SignupDate);
                    cmd_AddNewMember.ExecuteNonQuery(); //用於INSERT、UPDATE、DELETE 或 CREATE TABLE 等
                    MessageBox.Show("會員創建成功!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("會員創建失敗" + ex.Message);
                }
            }
        }

        //創建會員-從購票系統加入(只自動產生會員卡號)
        public static void AddNewMemberFromSaleSys(string newMemberID)
        {
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                try
                {
                    conn.Open();  //打開資料庫
                    //查詢語句
                    string query = "INSERT INTO members(MemberID, BonusPoints) "+
                        "Values(@memberID, 50)";
                    SqlCommand cmd_AddNewMemberFromSaleSys = new SqlCommand(query, conn);
                    cmd_AddNewMemberFromSaleSys.Parameters.AddWithValue("@MemberID", newMemberID);

                    cmd_AddNewMemberFromSaleSys.ExecuteNonQuery(); //用於INSERT、UPDATE、DELETE 或 CREATE TABLE 等
                    bonusPoint = 50;  //贈送的紅利
                    MessageBox.Show($"申請會員成功!\n您的會員卡號是：{newMemberID}\n請至櫃台填寫會員資料以完成註冊。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("會員創建失敗" + ex.Message);
                }
            }


        }

        //刪除會員(高權限)
        public static void DeleteMember(string memberID)
        {
            //刪除所選的(有分一個及多個)
            //刪除為要顯示刪除成功，及新的會員列表
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                try
                {
                    conn.Open();  //打開資料庫
                    //命令語句:刪除特定會員(透由memberID)
                    string query = "Delete From members WHERE memberID = @memberID;";
                    SqlCommand cmd_deleteMember = new SqlCommand(query, conn);
                    cmd_deleteMember.Parameters.AddWithValue("@MemberID", memberID);
                    cmd_deleteMember.ExecuteNonQuery();
                    MessageBox.Show("會員已成功刪除");                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("刪除會員時發生錯誤: " + ex.Message);
                    return;
                }
            }
        }

        //修改會員資料
        public static void ModifyMember(string memberID, string memberName, string gender, DateTime DateOfBirth,
            string phoneNumber, string BonusPoints, DateTime SignupDate)
        {
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                try
                {
                    conn.Open();  //打開資料庫
                    //查詢語句-更改特定會員資料
                    string query = "Update members set MemberName = @memberName, Gender = @gender, DateOfBirth = @DateOfBirth, " +
                        "PhoneNumber = @phoneNumber, BonusPoints = @bonusPoints, SignupDate = @signupDate " +
                        "WHERE memberID = @memberID";
                    SqlCommand cmd_ModifyMember = new SqlCommand(query, conn);
                    cmd_ModifyMember.Parameters.AddWithValue("@MemberID", memberID);
                    cmd_ModifyMember.Parameters.AddWithValue("@MemberName", memberName);
                    cmd_ModifyMember.Parameters.AddWithValue("@Gender", gender);
                    cmd_ModifyMember.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    cmd_ModifyMember.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd_ModifyMember.Parameters.AddWithValue("@BonusPoints", BonusPoints);
                    cmd_ModifyMember.Parameters.AddWithValue("@SignupDate", SignupDate);
                    cmd_ModifyMember.ExecuteNonQuery(); //用於INSERT、UPDATE、DELETE 或 CREATE TABLE 等
                    MessageBox.Show("會員修改成功!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("會員修改失敗" + ex.Message);
                }
            }
        }


    }
}
