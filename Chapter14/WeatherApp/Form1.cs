using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp { 

    public partial class Form1 : Form {

        string areaCode;
        string weatherCode;

        public Form1() {
            InitializeComponent();
        }

        private void btWeatherGet_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            /*https://qiita.com/michan06/items/48503631dd30275288f7

              概況（三日間）
              https://www.jma.go.jp/bosai/forecast/data/overview_forecast/130000.json

              概況（七日間）
              https://www.jma.go.jp/bosai/forecast/data/overview_week/130000.json

              エリアコード
              https://zenn.dev/inoue2002/articles/2e07da8d0ca9ca

              https://anko.education/apps/weather_api*/

            //選択した地域の天気予報
            //https://www.jma.go.jp/bosai/forecast/data/forecast/090000.json

            //画像取得等
            //https://qiita.com/michan06/items/48503631dd30275288f7

            //天気予報の画像URL
            //https://www.jma.go.jp/bosai/forecast/img/100.svg

            int index = cbArea.SelectedIndex;
            GetAreaCode(index);

            //概況
            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/" + areaCode + ".json");
            var djson = JsonConvert.DeserializeObject<Rootobject>(dString);

            //詳細
            var cString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/" + areaCode + ".json");
            var cjson = JsonConvert.DeserializeObject<Class1[]>(cString);
            weatherCode = cjson[0].timeSeries[0].areas[0].weatherCodes[0];

            //天気予報画像
            //var pWeather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/img/" + weatherCode + ".svg");

            tbPresenter.Text = cjson[0].publishingOffice.ToString();
            tbrDate.Text = cjson[0].reportDatetime.ToString();
            tbArea.Text = djson.targetArea;
            tbTodayWeather.Text = cjson[0].timeSeries[0].areas[0].weathers[0];
            tbTomorrowWeather.Text = cjson[0].timeSeries[0].areas[0].weathers[1];
            pbTodayWeather.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + weatherCode + ".svg";

            tbWeatherInfo.Text = djson.text;
        }

        //選択された地方のエリアコード取得
        private string GetAreaCode(int num) {
            switch (num) {
                case 0:
                    areaCode = "011000";
                    break;
                case 1:
                    areaCode = "012000";
                    break;
                case 2:
                    areaCode = "013000";
                    break;
                case 3:
                    areaCode = "014100";
                    break;
                case 4:
                    areaCode = "015000";
                    break;
                case 5:
                    areaCode = "016000";
                    break;
                case 6:
                    areaCode = "017000";
                    break;
                case 7:
                    areaCode = "020000";
                    break;
                case 8:
                    areaCode = "030000";
                    break;
                case 9:
                    areaCode = "040000";
                    break;
                case 10:
                    areaCode = "050000";
                    break;
                case 11:
                    areaCode = "060000";
                    break;
                case 12:
                    areaCode = "070000";
                    break;
                case 13:
                    areaCode = "080000";
                    break;
                case 14:
                    areaCode = "090000";
                    break;
                case 15:
                    areaCode = "100000";
                    break;
                case 16:
                    areaCode = "110000";
                    break;
                case 17:
                    areaCode = "120000";
                    break;
                case 18:
                    areaCode = "130000";
                    break;
                case 19:
                    areaCode = "140000";
                    break;
                case 20:
                    areaCode = "190000";
                    break;
                case 21:
                    areaCode = "200000";
                    break;
                case 22:
                    areaCode = "210000";
                    break;
                case 23:
                    areaCode = "220000";
                    break;
                case 24:
                    areaCode = "230000";
                    break;
                case 25:
                    areaCode = "240000";
                    break;
                case 26:
                    areaCode = "150000";
                    break;
                case 27:
                    areaCode = "160000";
                    break;
                case 28:
                    areaCode = "170000";
                    break;
                case 29:
                    areaCode = "180000";
                    break;
                case 30:
                    areaCode = "250000";
                    break;
                case 31:
                    areaCode = "260000";
                    break;
                case 32:
                    areaCode = "270000";
                    break;
                case 33:
                    areaCode = "280000";
                    break;
                case 34:
                    areaCode = "290000";
                    break;
                case 35:
                    areaCode = "300000";
                    break;
                case 36:
                    areaCode = "310000";
                    break;
                case 37:
                    areaCode = "320000";
                    break;
                case 38:
                    areaCode = "330000";
                    break;
                case 39:
                    areaCode = "340000";
                    break;
                case 40:
                    areaCode = "360000";
                    break;
                case 41:
                    areaCode = "370000";
                    break;
                case 42:
                    areaCode = "380000";
                    break;
                case 43:
                    areaCode = "390000";
                    break;
                case 44:
                    areaCode = "350000";
                    break;
                case 45:
                    areaCode = "400000";
                    break;
                case 46:
                    areaCode = "410000";
                    break;
                case 47:
                    areaCode = "420000";
                    break;
                case 48:
                    areaCode = "430000";
                    break;
                case 49:
                    areaCode = "440000";
                    break;
                case 50:
                    areaCode = "450000";
                    break;
                case 51:
                    areaCode = "460100";
                    break;
                case 52:
                    areaCode = "471000";
                    break;
                case 53:
                    areaCode = "472000";
                    break;
                case 54:
                    areaCode = "473000";
                    break;
                case 55:
                    areaCode = "474000";
                    break;
            }
            return areaCode;
        }

        //コンボボックスに地方名セット
        private void SetCdAreaName() {
            cbArea.Items.Add("宗谷地方");//011000
            cbArea.Items.Add("上川・留萌地方");//012000
            cbArea.Items.Add("網走・北見・紋別地方");//013000
            cbArea.Items.Add("釧路・根室地方");//014100
            cbArea.Items.Add("胆振・日高地方");//015000
            cbArea.Items.Add("石狩・空知・後志地方");//016000
            cbArea.Items.Add("渡島・檜山地方");//017000
            cbArea.Items.Add("青森県");//020000
            cbArea.Items.Add("岩手県");//030000
            cbArea.Items.Add("宮城県");//040000
            cbArea.Items.Add("秋田県");//050000  10
            cbArea.Items.Add("山形県");//060000
            cbArea.Items.Add("福島県");//070000
            cbArea.Items.Add("茨城県");//080000
            cbArea.Items.Add("栃木県");//090000
            cbArea.Items.Add("群馬県");//100000
            cbArea.Items.Add("埼玉県");//110000
            cbArea.Items.Add("千葉県");//120000
            cbArea.Items.Add("東京都");//130000
            cbArea.Items.Add("神奈川県");//140000
            cbArea.Items.Add("山梨県");//190000
            cbArea.Items.Add("長野県");//200000
            cbArea.Items.Add("岐阜県");//210000
            cbArea.Items.Add("静岡県");//220000
            cbArea.Items.Add("愛知県");//230000
            cbArea.Items.Add("三重県");//240000
            cbArea.Items.Add("新潟県");//150000
            cbArea.Items.Add("富山県");//160000
            cbArea.Items.Add("石川県");//170000
            cbArea.Items.Add("福井県");//180000
            cbArea.Items.Add("滋賀県");//250000
            cbArea.Items.Add("京都府");//260000
            cbArea.Items.Add("大阪府");//270000
            cbArea.Items.Add("兵庫県");//280000
            cbArea.Items.Add("奈良県");//290000
            cbArea.Items.Add("和歌山県");//300000
            cbArea.Items.Add("鳥取県");//310000
            cbArea.Items.Add("島根県");//320000
            cbArea.Items.Add("岡山県");//330000
            cbArea.Items.Add("広島県");//340000
            cbArea.Items.Add("徳島県");//360000
            cbArea.Items.Add("香川県");//370000
            cbArea.Items.Add("愛媛県");//380000
            cbArea.Items.Add("高知県");//390000
            cbArea.Items.Add("山口県");//350000
            cbArea.Items.Add("福岡県");//400000
            cbArea.Items.Add("佐賀県");//410000
            cbArea.Items.Add("長崎県");//420000
            cbArea.Items.Add("熊本県");//430000
            cbArea.Items.Add("大分県");//440000
            cbArea.Items.Add("宮崎県");//450000
            //cbArea.Items.Add("奄美地方");//460040
            cbArea.Items.Add("鹿児島県");//460100
            cbArea.Items.Add("沖縄本島地方");//471000
            cbArea.Items.Add("大東島地方");//472000
            cbArea.Items.Add("宮古島地方");//473000
            cbArea.Items.Add("八重山地方");//474000
        }

        private void EnableCheck() {
            btWeatherGet.Enabled = cbArea.Text == null ? true : false;
        }

        private void Form1_Load(object sender, EventArgs e) {
            SetCdAreaName();
        }
    }
}
