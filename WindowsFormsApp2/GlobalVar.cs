using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class GlobalVar
    {
        //定義全局變數:可以看到時候要定義在全局還是類別變數即可


        //連結資料庫字串
        public static string GetConnectionString() // 打開門的鑰匙(連接資料庫的鑰匙)
        {
            // 返回資料庫連接字串
            return "Data Source = LAPTOP-OG3MA3QC\\SQLEXPRESS;" +
                   "Initial Catalog = project1;" +
                   "Integrated Security = True;";
        }


        //訂單資訊、產生票根用
        public static int newBookingID = 0; //提交訂單才會抓出
        public static string SelectedDate = "";  //日期選擇    //已抓出
        public static string SelectedMovie = "";  //電影選擇    //已抓出
        public static string SelectedTime = ""; //場次(時刻選擇) //已抓出

        public static List<string> selectedTicketType = new List<string>(); //選擇票種
        public static List<int> selectedTicketCount = new List<int>();  //選擇票種數量(索引值與上方list對應)

        public static int selectedTicketNum; //購買總張數→用來決定選位數量 //已抓出
        public static string selectedTheaterName = "";  //選擇場次的影廳名稱   //已抓出 
        public static List<int> selectedSeatNum = new List<int>(); //選擇的座位號碼(1-10)      
        //價格相關
        public static double priceBeforeDiscount = 0; //折扣前總價
        public static double finalPrice = 0; //最終價格(折扣後)
        
        public static string memberID = ""; //最終輸入會員卡號  //已抓出
        public static int useBonusPoint = 0; //折抵的會員點數 //已抓出
        public static int newBonusPoint = 0;  //新紅利點數(最後要更新到欄位的)

        public static List<string> bookInfo = new List<string>();  //統整以上的資訊


        //對照用:主要為ID資訊
        //可以對照場次資訊，如影廳名稱等
        public static int selectedTimeID = 0; //選擇場次對應ID(再看是否放在類別變數即可   //已抓出
        public static List<int> selectedSeatID = new List<int>();  //選擇的座位id清單 //已抓出



        //價格方案
        public static List<string> priceScheme = new List<string>{"全票","學生票", "爆米花套票", "雙人爆米花套票"," 雙人吉拿套票"};
        public static List<int> schemePrice = new List<int> { 280, 240, 380, 750, 800 };



        



    }
    
}
