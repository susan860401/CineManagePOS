using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp2
{
    internal class Movie
    {
        public static int movieID = 0;
        public static string movieTitle = "";
        public static string movieRating = "";
        public static string movieGenre = "";
        public static int movieDuration = 0;
        public static string movieDesc = "";
        public static string movieImage = "";

        public static Dictionary<string, int> dict_movie = new Dictionary<string, int>();  //用來對應電影和電影ID
                                                                                           //可能不需要)


        //載入電影資訊(單純調資料用)
        public static void searchMovieInfo()
        {
            dict_movie.Clear();
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                conn.Open();
                string query = "select * from movie;";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dict_movie.Add((string)reader["title"], (int)reader["movieId"]);
                }
            }
        }

        //電影資訊管理-載入電影資訊(列表顯示資料)
        public static DataTable LoadMovieList()
        {
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    //查詢，這是不需要加入參數情況(載入全部資料)，所以不需要用sql command
                    string query = "SELECT movieID as id, title as 電影, genre as 類型, movieRating 分級, duration as 片長 FROM movie";

                    // SqlDataAdapter為資料來源(資料庫等)及資料集之間填充數據的橋樑
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return null;
                }
            }
        }

        //function 載入電影詳細資訊(可以看訂票模組是否也可用)
        public static void loadMovieDetail(int ID)
        {
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT movieID, title, movieRating, genre, duration, mdesc, mimage " +
                        "FROM movie " +
                        "WHERE movieID = @movieID";
                    // 讀取電影詳細資訊
                    SqlCommand cmd_movieDetail = new SqlCommand(query, conn);
                    cmd_movieDetail.Parameters.AddWithValue("@movieID", ID);

                    SqlDataReader reader_movieDetail = cmd_movieDetail.ExecuteReader();

                    reader_movieDetail.Read();
                    movieID = (int)reader_movieDetail["movieID"];
                    movieTitle = (string)reader_movieDetail["title"];
                    movieRating = (string)reader_movieDetail["movieRating"];
                    movieGenre = (string)reader_movieDetail["genre"];
                    movieDuration = (int)reader_movieDetail["duration"];
                    movieDesc = (string)reader_movieDetail["mdesc"];
                    movieImage = (string)reader_movieDetail["mimage"];
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"載入電影錯誤:{ex.Message}");
                }                
            }
        }
        
        //獲取新建movieID
        public static int generateMovieID()
        {
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString())) 
            {
                conn.Open();
                string query = "select max(movieID) from movie;";
                SqlCommand cmd = new SqlCommand(query, conn);
                int newMovieID = (int)cmd.ExecuteScalar() + 1;
                return newMovieID;
            }
        }

        //新增電影
        public static void addMovie()
        {
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO movie " +
                        "Values(@movieID, @title, @duration, @genre, @mimage, @mdesc, @rating)";
                    SqlCommand cmd_addMovie = new SqlCommand(query, conn);
                    cmd_addMovie.Parameters.AddWithValue("@movieID", movieID);
                    cmd_addMovie.Parameters.AddWithValue("@title", movieTitle);
                    cmd_addMovie.Parameters.AddWithValue("@duration", movieDuration);
                    cmd_addMovie.Parameters.AddWithValue("@genre", movieGenre);
                    cmd_addMovie.Parameters.AddWithValue("@mimage", movieImage);
                    cmd_addMovie.Parameters.AddWithValue("@mdesc", movieDesc);
                    cmd_addMovie.Parameters.AddWithValue("@rating", movieRating);
                    cmd_addMovie.ExecuteNonQuery();

                    MessageBox.Show("電影創建成功!");


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"電影創建失敗:{ex.Message}");
                }
            }
        }


        //修改電影資訊
        public static void ModifyMovie(string movieID, string title, string movieRating, string genre, string duration, string movieDesc, string mimage)
        {
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                try
                {
                    conn.Open();  //打開資料庫
                    //查詢語句-更改特定會員資料
                    string query = "UPDATE movie SET " +
                        "title = @title, movieRating = @movieRating, genre = @genre, mdesc = @mdesc, mimage = @mimage, duration = @duration " +
                        "WHERE movieID = @movieID";

                    SqlCommand cmd_modifyMovie = new SqlCommand(query, conn);
                    cmd_modifyMovie.Parameters.AddWithValue("@movieID", movieID);
                    cmd_modifyMovie.Parameters.AddWithValue("@title", title);
                    cmd_modifyMovie.Parameters.AddWithValue("@movieRating", movieRating);
                    cmd_modifyMovie.Parameters.AddWithValue("@genre", genre);
                    cmd_modifyMovie.Parameters.AddWithValue("@mdesc", movieDesc);
                    cmd_modifyMovie.Parameters.AddWithValue("@duration", duration);
                    cmd_modifyMovie.Parameters.AddWithValue("@mimage", mimage);

                    cmd_modifyMovie.ExecuteNonQuery(); //用於INSERT、UPDATE、DELETE 或 CREATE TABLE 等
                    MessageBox.Show("電影資訊修改成功!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("電影資訊修改失敗" + ex.Message);
                }
            }
        }


        //電影管理-場次管理
        //場次管理-載入所有電影場次
        public static DataTable LoadShowTimetList()
        {
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                try
                {
                    conn.Open();

                    //查詢，這是不需要加入參數情況(載入全部資料)，所以不需要用sql command
                    string query = "select s.showtimeID AS ID, m.title AS 電影, s.showDate AS 日期, s.showTime AS 時間, t.theaterName AS 影廳 " +
                        "From show_time s Join movie m on s.movieId = m.movieID Join theater t on s.TheaterID = t.TheaterID";                    

                    // SqlDataAdapter為資料來源(資料庫等)及資料集之間填充數據的橋樑
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return null;
                }
            }
        }

        //場次管理-依照電影名稱搜尋特定場次(模糊比對)
        public static DataTable searchMovieShowTime(string searchText)
        {
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                try
                {
                    conn.Open();  //打開資料庫
                                  //查詢語句
                    string query = "SELECT s.showtimeID AS ID, m.title AS 電影, s.showDate AS 日期, s.showTime AS 時間, t.theaterName AS 影廳 " +
                        "FROM show_time s Join movie m on s.movieId = m.movieID Join theater t on s.TheaterID = t.TheaterID " +
                        "WHERE m.title like @keyword;";  
                    SqlCommand cmd_searchShowTime = new SqlCommand(query, conn);
                    cmd_searchShowTime.Parameters.AddWithValue("@keyword", "%" + searchText + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd_searchShowTime);
                    DataTable dataTable = new DataTable(); //創建一個表格
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        return dataTable;
                    }
                    else
                    {
                        MessageBox.Show("查無場次");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return null;
                }
            }        
        }
        //產生新ShowTimeID
        public static int generateShowID()
        {
            int NewShowID = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
                {
                    conn.Open();
                    string query = "select max(ShowTimeID) FROM show_time";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    NewShowID = Convert.ToInt32(reader[0]) + 1;
                    return NewShowID;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"無法產生新id:{ ex.Message} ");
                return 0; 
            }
            
        }

        //場次管理-新增場次(★)  
        public static void addNewShowTime(int movieID, DateTime date, DateTime time, int theaterID)
        {
            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                conn.Open();  //打開資料庫
                SqlTransaction transaction = conn.BeginTransaction(); //★
                try
                {
                    //命令語句
                    string query_addShowTime = "INSERT INTO show_time " + 
                        "OUTPUT INSERTED.showtimeID " +
                        "values(@movieID, @theaterID, @date, @time);";

                    SqlCommand cmd_addShowTime = new SqlCommand(query_addShowTime, conn, transaction);
                    cmd_addShowTime.Parameters.AddWithValue("@movieID", movieID);
                    cmd_addShowTime.Parameters.AddWithValue("@theaterID", theaterID);
                    cmd_addShowTime.Parameters.AddWithValue("@date", date);
                    cmd_addShowTime.Parameters.AddWithValue("@time", time);


                    //對此命令執行查詢，並會返回查詢結果第一行第一列的值                                   
                    int newShowTimeID = Convert.ToInt32(cmd_addShowTime.ExecuteScalar());

                    string query_addSeat = "INSERT INTO seat " +
                        "Values(@theaterID, @showtimeID, @seatNum, 'false');";
                    
                    SqlCommand cmd_addSeat = new SqlCommand(query_addSeat, conn, transaction);
                    cmd_addSeat.Parameters.AddWithValue("@theaterID", theaterID);
                    cmd_addSeat.Parameters.AddWithValue("@showtimeID", newShowTimeID);

                    // ★使用 .Parameters.Add，讓 seatNum 參數可被更新
                    cmd_addSeat.Parameters.Add("@seatNum", SqlDbType.Int);
                    if(theaterID ==1 || theaterID == 3)  //A廳 or C廳
                    {
                        for (int seatNum = 1; seatNum <= 50; seatNum++)
                        {
                            cmd_addSeat.Parameters["@seatNum"].Value = seatNum;
                            cmd_addSeat.ExecuteNonQuery();
                        }
                    }else if (theaterID == 2)
                    {
                        for (int seatNum = 1; seatNum <= 45; seatNum++)
                        {
                            cmd_addSeat.Parameters["@seatNum"].Value = seatNum;
                            cmd_addSeat.ExecuteNonQuery();
                        }
                    }
                    

                    //提交交易
                    transaction.Commit();

                    MessageBox.Show("場次新增成功!");
                }
                catch (Exception ex)
                {
                    //回滾交易(有成功執行的部分也取消
                    transaction.Rollback();
                    MessageBox.Show("場次新增失敗" + ex.Message);
                }
            }
        }

    


    }

}
