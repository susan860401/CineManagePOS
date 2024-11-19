using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Definitions.Charts;
using LiveCharts.WinForms;
using LiveCharts.Wpf; // 如果需要使用 WPF 控件

namespace WindowsFormsApp2
{
    public partial class Report_Center : Form
    {
        
        int sales = 0;
        List<string> movieList = new List<string>();
        
        //照片根目錄Application.StartupPath→bin/debug/image
        string imageDir = Path.Combine(Application.StartupPath, "image");

        public Report_Center()
        {
            InitializeComponent();
            
        }

        private void Report_Center_Load(object sender, EventArgs e)
        {
            panel_nav.BackColor = ColorTranslator.FromHtml("#2F3645");  //左側導覽列
            panel_top.BackColor = ColorTranslator.FromHtml("#939185");  //右側上方()
            panel_top2.BackColor = ColorTranslator.FromHtml("#939185"); //右側上方()

            cbox_year.SelectedIndex = 0;  //設置在2024年
            cbox_month.SelectedIndex = 7;  //設置在8月(現在的月份)
            
            loadSaleData((string)cbox_month.SelectedItem);  //載入當月銷售額
            loadSaleDataByMovie((string)cbox_month.SelectedItem);
        }
        
        //當選擇月份改變
        private void cbox_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            sales = 0;
            movieList.Clear();

            if (cbox_date.SelectedItem == "" || cbox_date.SelectedIndex == -1)
            {//沒有選日期，以當月顯示
                sales = loadSaleData((string)cbox_month.SelectedItem);
                movieList = loadSaleDataByMovie((string)cbox_month.SelectedItem);
                lbl_sale.Text = $"{cbox_month.SelectedItem.ToString()} 月票房";
                lbl_movieSale.Text = $"{cbox_month.SelectedItem.ToString()} 月電影票房分布";
                lbl_saleTitle.Text = $"{cbox_month.SelectedItem.ToString()} 月票房：";  //N0表像是1,000這種格式
                lbl_saleInfo.Text = $"{sales:N0}";
                lbl_ratingTitle.Text = $"{cbox_month.SelectedItem.ToString()} 月份電影票房排名";
                if (movieList.Count == 1)
                {
                    lbl_rating.Text = $"TOP 1 {movieList[0]}";
                }
                else if (movieList.Count == 2)
                {
                    lbl_rating.Text = $"TOP 1 {movieList[0]}\n\nTOP 2 {movieList[1]}";
                }
                else if ((movieList.Count >= 3))
                {
                    lbl_rating.Text = $"TOP 1 {movieList[0]}\n\nTOP 2 {movieList[1]}\n\nTOP 3 {movieList[2]}";
                }
                else
                {//沒有資料
                    lbl_rating.Text = "";
                }
                lbl_topOne.Text = $"{cbox_month.SelectedItem.ToString()} 月票房冠軍";
                if (movieList.Count > 0)
                {
                    pbox_topOne.ImageLocation = Path.Combine(imageDir, movieList[0] + ".png");
                }
                else
                {
                    pbox_topOne.Image = null;
                }
            }
            else
            {//如果有選擇日期，以日顯示
                sales = loadDaySaleData((string)cbox_month.SelectedItem, (string)cbox_date.SelectedItem);  //顯示選擇的日銷售額
                movieList = loadDayMovieSale((string)cbox_month.SelectedItem, (string)cbox_date.SelectedItem); //顯示選擇的日各電影票房
                lbl_sale.Text = $"{cbox_month.SelectedItem.ToString()} 月 {cbox_date.SelectedItem.ToString()} 日票房";
                lbl_movieSale.Text = $"{cbox_month.SelectedItem.ToString()} 月 {cbox_date.SelectedItem.ToString()} 日電影票房分布";
                lbl_saleTitle.Text = $"{cbox_month.SelectedItem.ToString()} 月 {cbox_date.SelectedItem.ToString()} 日票房：";  //N0表像是1,000這種格式
                lbl_saleInfo.Text = $"{sales:N0}";
                lbl_ratingTitle.Text = $"{cbox_month.SelectedItem.ToString()} 月 {cbox_date.SelectedItem.ToString()} 日電影票房排名";
                if (movieList.Count == 1)
                {
                    lbl_rating.Text = $"TOP 1 {movieList[0]}";
                }
                else if (movieList.Count == 2)
                {
                    lbl_rating.Text = $"TOP 1 {movieList[0]}\n\nTOP 2 {movieList[1]}";
                }
                else if ((movieList.Count >= 3))
                {
                    lbl_rating.Text = $"TOP 1 {movieList[0]}\n\nTOP 2 {movieList[1]}\n\nTOP 3 {movieList[2]}";
                }
                else
                {//沒有資料
                    lbl_rating.Text = "";
                }
                lbl_topOne.Text = $"{cbox_month.SelectedItem.ToString()} 月 {cbox_date.SelectedItem.ToString()} 日票房冠軍";
                if (movieList.Count > 0)
                {

                    pbox_topOne.ImageLocation = Path.Combine(imageDir, movieList[0] + ".png");
                }
                else
                {
                    pbox_topOne.Image = null;
                }
            }
            
        }

        //當選擇日期改變
        private void cbox_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            sales = 0;
            movieList.Clear();

            if (cbox_date.SelectedItem != "")
            {
                sales = loadDaySaleData((string)cbox_month.SelectedItem, (string)cbox_date.SelectedItem);  //顯示選擇的日銷售額
                movieList = loadDayMovieSale((string)cbox_month.SelectedItem, (string)cbox_date.SelectedItem); //顯示選擇的日各電影票房
                lbl_sale.Text = $"{cbox_month.SelectedItem.ToString()} 月 {cbox_date.SelectedItem.ToString()} 日票房";
                lbl_movieSale.Text = $"{cbox_month.SelectedItem.ToString()} 月 {cbox_date.SelectedItem.ToString()} 日電影票房分布";
                lbl_saleTitle.Text = $"{cbox_month.SelectedItem.ToString()} 月 {cbox_date.SelectedItem.ToString()} 日票房：";  //N0表像是1,000這種格式
                lbl_saleInfo.Text = $"{sales:N0}";
                lbl_ratingTitle.Text = $"{cbox_month.SelectedItem.ToString()} 月 {cbox_date.SelectedItem.ToString()} 日電影票房排名";
                if (movieList.Count == 1)
                {
                    lbl_rating.Text = $"TOP 1 {movieList[0]}";
                }
                else if (movieList.Count == 2)
                {
                    lbl_rating.Text = $"TOP 1 {movieList[0]}\n\nTOP 2 {movieList[1]}";
                }
                else if ((movieList.Count >= 3))
                {
                    lbl_rating.Text = $"TOP 1 {movieList[0]}\n\nTOP 2 {movieList[1]}\n\nTOP 3 {movieList[2]}";
                }
                else
                {//沒有資料
                    lbl_rating.Text = "";
                }
                lbl_topOne.Text = $"{cbox_month.SelectedItem.ToString()} 月 {cbox_date.SelectedItem.ToString()} 日票房冠軍";
                if (movieList.Count > 0){
                    pbox_topOne.ImageLocation = Path.Combine(imageDir, movieList[0] + ".png");
                }
                else
                {
                    pbox_topOne.Image = null;
                }
            }
            else
            {//如果沒有選擇日，則顯示整月
                sales = loadSaleData((string)cbox_month.SelectedItem);
                movieList = loadSaleDataByMovie((string)cbox_month.SelectedItem);
                lbl_sale.Text = $"{cbox_month.SelectedItem.ToString()} 月票房";
                lbl_movieSale.Text = $"{cbox_month.SelectedItem.ToString()} 月電影票房分布";
                lbl_saleTitle.Text = $"{cbox_month.SelectedItem.ToString()} 月票房：";  //N0表像是1,000這種格式
                lbl_saleInfo.Text = $"{sales:N0}";
                lbl_ratingTitle.Text = $"{cbox_month.SelectedItem.ToString()} 月份電影票房排名";
                if (movieList.Count == 1)
                {
                    lbl_rating.Text = $"TOP 1 {movieList[0]}";
                }
                else if (movieList.Count == 2)
                {
                    lbl_rating.Text = $"TOP 1 {movieList[0]}\n\nTOP 2 {movieList[1]}";
                }
                else if ((movieList.Count >= 3))
                {
                    lbl_rating.Text = $"TOP 1 {movieList[0]}\n\nTOP 2 {movieList[1]}\n\nTOP 3 {movieList[2]}";
                }
                else
                {//沒有資料
                    lbl_rating.Text = "";
                }
                lbl_topOne.Text = $"{cbox_month.SelectedItem.ToString()} 月票房冠軍";
                if (movieList.Count > 0)
                {
                    pbox_topOne.ImageLocation = Path.Combine(imageDir, movieList[0] + ".png");
                }
                else
                {
                    pbox_topOne.Image = null;
                }
            }
            
        }

        //某一月的銷售額
        private int loadSaleData(string month)
        {
            Chart1.Series.Clear(); //清空所有系列中的數據
            Chart1.AxisX.Clear(); //清空x軸
            Chart1.AxisY.Clear(); //清空y軸


            var chartValues = new ChartValues<int>();
            var labels = new List<string>();

            string query = "SELECT orderDate, SUM(totalPrice) AS totalPrice FROM booking " +
                "WHERE DATEPART(MONTH, orderdate) = @month " +
                "GROUP BY orderDate";


            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                try
                {
                    int totalSale = 0; //計算總銷售額
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@month", month);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        labels.Add(((DateTime)reader["orderDate"]).ToString("dd"));
                        chartValues.Add((int)reader["totalPrice"]);
                        totalSale += (int)reader["totalPrice"]; 
                    }

                    var lineSeries = new LineSeries
                    {
                        Title = "日銷售額",
                        Values = chartValues,
                        PointGeometrySize = 10
                    };

                    Chart1.Series = new SeriesCollection { lineSeries };
                    Chart1.AxisX.Add(new Axis
                    {
                        Title = "日期",
                        Labels = labels.ToArray(),
                        Separator = new Separator { Step = 1, IsEnabled = true }
                    });
                    Chart1.AxisY.Add(new Axis
                    {
                        Title = "銷售額"
                    });

                    return totalSale;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"錯誤{ex.Message}");
                    return 0;
                }
            }
        }


        private List<string> loadSaleDataByMovie(string month)
        {
            Chart2.Series.Clear(); //清空所有系列中的數據
            Chart2.AxisX.Clear(); //清空x軸
            Chart2.AxisY.Clear(); //清空y軸

            var chartValues = new ChartValues<int>();
            var labels = new List<string>();

            string query = "SELECT m.title, sum(b.totalPrice) as MovieSales " +
                           "FROM booking b JOIN show_time s on b.ShowTimeID = s.ShowTimeID " +
                           "JOIN movie m on s.MovieID = m.MovieID " +
                           "WHERE DATEPART(MONTH, orderdate) = @month " +
                           "GROUP BY m.title " +
                           "ORDER BY MovieSales DESC";

            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                try
                {
                    List<string> getTop3Movie = new List<string>();  //要抓出排行前三的電影

                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@month", month);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        labels.Add((string)reader["title"]);
                        chartValues.Add((int)reader["MovieSales"]);
                        getTop3Movie.Add((string)reader["title"]);
                    }

                    var Series = new ColumnSeries
                    {
                        Title = "月票房",
                        Values = chartValues,
                    };

                    Chart2.Series = new SeriesCollection { Series };
                    Chart2.AxisX.Add(new Axis
                    {
                        Title = "電影",
                        Labels = labels.ToArray(),
                        Separator = new Separator { Step = 1, IsEnabled = true }
                    });
                    Chart2.AxisY.Add(new Axis
                    {
                        Title = "票房"
                    });
                    return getTop3Movie;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"錯誤{ex.Message}");
                    return null;
                }
            }

        }


        //當日的銷售額
        private int loadDaySaleData(string month, string date)
        {
            Chart1.Series.Clear(); //清空所有系列中的數據
            Chart1.AxisX.Clear(); //清空x軸
            Chart1.AxisY.Clear(); //清空y軸


            var chartValues = new ChartValues<int>();
            var labels = new List<string>();

            string query = "SELECT orderDate, SUM(totalPrice) AS totalPrice FROM booking " +
                "WHERE DATEPART(MONTH, orderdate) = @month AND DATEPART(DAY, orderdate) = @date " +
                "GROUP BY orderDate";


            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                try
                {
                    int totalSale = 0;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@date", date);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        labels.Add(((DateTime)reader["orderDate"]).ToString("yyyy-MM-dd"));
                        chartValues.Add((int)reader["totalPrice"]);
                        totalSale += (int)reader["totalPrice"];
                    }

                    var Series = new ColumnSeries
                    {
                        Title = "日票房",
                        Values = chartValues,
                    };

                    Chart1.Series = new SeriesCollection { Series };
                    Chart1.AxisX.Add(new Axis
                    {
                        Title = "日期",
                        Labels = labels.ToArray(),
                        Separator = new Separator { Step = 1, IsEnabled = true }
                    });
                    Chart1.AxisY.Add(new Axis
                    {
                        Title = "票房"
                    });
                    return totalSale;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"錯誤{ex.Message}");
                    return 0;
                }
            }
        }

        //某日的電影票房情況
        private List<string> loadDayMovieSale(string month, string date)
        {
            Chart2.Series.Clear(); //清空所有系列中的數據
            Chart2.AxisX.Clear(); //清空x軸
            Chart2.AxisY.Clear(); //清空y軸

            var chartValues = new ChartValues<int>();
            var labels = new List<string>();

            string query = "SELECT m.title, sum(totalPrice) as MovieSales " +
                           "FROM booking b JOIN show_time s on b.ShowTimeID = s.ShowTimeID " +
                           "JOIN movie m on s.MovieID = m.MovieID " +
                           "WHERE DATEPART(MONTH, orderdate) = @month AND DATEPART(DAY, orderdate) = @date " +
                           "GROUP BY m.title " +
                           "ORDER BY MovieSales DESC";

            using (SqlConnection conn = new SqlConnection(GlobalVar.GetConnectionString()))
            {
                try
                {

                    List<string> getTop3Movie = new List<string>();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@date", date);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        labels.Add((string)reader["title"]);
                        chartValues.Add((int)reader["MovieSales"]);
                        getTop3Movie.Add((string)reader["title"]);
                    }

                    var Series = new ColumnSeries
                    {
                        Title = "日票房",
                        Values = chartValues,
                    };

                    Chart2.Series = new SeriesCollection { Series };
                    Chart2.AxisX.Add(new Axis
                    {
                        Title = "電影",
                        Labels = labels.ToArray(),
                        Separator = new Separator { Step = 1, IsEnabled = true }
                    });
                    Chart2.AxisY.Add(new Axis
                    {
                        Title = "票房"
                    });
                    return getTop3Movie;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"錯誤{ex.Message}");
                    return null;
                }
            }
        }
    }
}
