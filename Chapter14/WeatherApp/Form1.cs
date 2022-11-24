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

        string areaCode; //エリアコード
        string todayWeatherCode; //今日の天気コード
        string tomorrowWeatherCode; //明日の天気コード

        string oneDayWeatherCode; //1日後の天気コード
        string twoDayWeatherCode; //2日後の天気コード
        string therrDayWeatherCode; //3日後の天気コード
        string fourDayWeatherCode; //4日後の天気コード
        string fiveDayWeatherCode; //5日後の天気コード
        string sixDayWeatherCode; //6日後の天気コード

        public Form1() {
            InitializeComponent();
        }

        //取得ボタン押したときの処理
        private void btWeatherGet_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            //エリアコード取得
            GetAreaCode(cbRegions.Text);

            try {
                //概況
                var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/" + areaCode + ".json");
                var djson = JsonConvert.DeserializeObject<Rootobject>(dString);

                //詳細
                var cString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/" + areaCode + ".json");
                var cjson = JsonConvert.DeserializeObject<Class1[]>(cString);

                tbPresenter.Text = cjson[0].publishingOffice.ToString();
                tbrDate.Text = cjson[0].reportDatetime.ToString();
                tbArea.Text = djson.targetArea;
                tbTodayWeather.Text = cjson[0].timeSeries[0].areas[0].weathers[0];
                tbTomorrowWeather.Text = cjson[0].timeSeries[0].areas[0].weathers[1];

                //今日、明日の最高気温、最低気温
                tbTodayMaxTemp.Text = string.Format("{0}°", cjson[1].tempAverage.areas[0].max);
                tbTodayMinTemp.Text = string.Format("{0}°", cjson[1].tempAverage.areas[0].min);
                tbTrMaxTemp.Text = string.Format("{0}°", cjson[1].timeSeries[1].areas[0].tempsMax[1]);
                tbTrMinTemp.Text = string.Format("{0}°", cjson[1].timeSeries[1].areas[0].tempsMin[1]);

                //今日の天気マーク
                todayWeatherCode = cjson[0].timeSeries[0].areas[0].weatherCodes[0];
                pbTodayWeather.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + todayWeatherCode + ".png";

                //明日の天気マーク
                tomorrowWeatherCode = cjson[0].timeSeries[0].areas[0].weatherCodes[1];
                pbTomorrowWeather.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + tomorrowWeatherCode + ".png";

                //選択した地方の概況
                tbWeatherInfo.Text = djson.text;

                //1週間の天気予報ラベルに日付表示
                lbTodayTemp.Text = string.Format("{0}月{1}日", cjson[0].reportDatetime.Month.ToString(), cjson[0].reportDatetime.Day.ToString()); //今日
                lbOneDay.Text = string.Format("{0}月{1}日", cjson[1].timeSeries[0].timeDefines[0].Month, cjson[1].timeSeries[0].timeDefines[0].Day); //1日後
                lbTwoDayLater.Text = string.Format("{0}月{1}日", cjson[1].timeSeries[0].timeDefines[0].Month, cjson[1].timeSeries[0].timeDefines[1].Day); //2日後
                lbThreeDayLater.Text = string.Format("{0}月{1}日", cjson[1].timeSeries[0].timeDefines[0].Month, cjson[1].timeSeries[0].timeDefines[2].Day); //3日後
                lbFourDayLater.Text = string.Format("{0}月{1}日", cjson[1].timeSeries[0].timeDefines[0].Month, cjson[1].timeSeries[0].timeDefines[3].Day); //4日後
                lbFiveDayLater.Text = string.Format("{0}月{1}日", cjson[1].timeSeries[0].timeDefines[0].Month, cjson[1].timeSeries[0].timeDefines[4].Day); //5日後
                lbSixDayLater.Text = string.Format("{0}月{1}日", cjson[1].timeSeries[0].timeDefines[0].Month, cjson[1].timeSeries[0].timeDefines[5].Day); //6日後
                
                //1週間の天気予報最高気温、最低気温表示
                tbTodayTemp.Text = string.Format("{0} / {1}",cjson[1].tempAverage.areas[0].max,cjson[1].tempAverage.areas[0].min); //今日
                tbOneDayLaterTemp.Text = string.Format("{0} / {1}", cjson[1].timeSeries[1].areas[0].tempsMax[1], cjson[1].timeSeries[1].areas[0].tempsMin[1]); //1日後
                tbTwoDayLaterTemp.Text = string.Format("{0} / {1}", cjson[1].timeSeries[1].areas[0].tempsMax[2], cjson[1].timeSeries[1].areas[0].tempsMin[2]); //2日後
                tbThreeDayLaterTemp.Text = string.Format("{0} / {1}", cjson[1].timeSeries[1].areas[0].tempsMax[3], cjson[1].timeSeries[1].areas[0].tempsMin[3]); //3日後
                tbFourDayLaterTemp.Text = string.Format("{0} / {1}", cjson[1].timeSeries[1].areas[0].tempsMax[4], cjson[1].timeSeries[1].areas[0].tempsMin[4]); //4日後
                tbFiveDayLaterTemp.Text = string.Format("{0} / {1}", cjson[1].timeSeries[1].areas[0].tempsMax[5], cjson[1].timeSeries[1].areas[0].tempsMin[5]); //5日後
                tbSixDayLaterTemp.Text = string.Format("{0} / {1}", cjson[1].timeSeries[1].areas[0].tempsMax[6], cjson[1].timeSeries[1].areas[0].tempsMin[6]); //6日後

                //1週間の天気予報天気マーク表示
                //今日
                pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + todayWeatherCode + ".png";

                //1日後
                oneDayWeatherCode = cjson[1].timeSeries[0].areas[0].weatherCodes[0];
                pbOneDayLater.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + oneDayWeatherCode + ".png";

                //2日後
                twoDayWeatherCode = cjson[1].timeSeries[0].areas[0].weatherCodes[1];
                pbTwoDayLater.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + twoDayWeatherCode + ".png";

                //3日後
                therrDayWeatherCode = cjson[1].timeSeries[0].areas[0].weatherCodes[2];
                pbThreeDayLater.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + therrDayWeatherCode + ".png";

                //4日後
                fourDayWeatherCode = cjson[1].timeSeries[0].areas[0].weatherCodes[3];
                pbFourDayLater.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + fourDayWeatherCode + ".png";

                //5日後
                fiveDayWeatherCode = cjson[1].timeSeries[0].areas[0].weatherCodes[4];
                pbFiveDayLater.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + fiveDayWeatherCode + ".png";

                //6日後
                sixDayWeatherCode = cjson[1].timeSeries[0].areas[0].weatherCodes[5];
                pbSixDayLater.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + sixDayWeatherCode + ".png";

            }
            catch (WebException ex) {
                MessageBox.Show("error：" + ex);
                Application.Exit();           
            }
        }

        //選択された地方の地方(地域)名セット
        private void SetCbRegionName(int num) {
            cbRegions.Items.Clear();
            switch (num) {
                case 0:
                    cbRegions.Items.Add("宗谷地方");//011000
                    cbRegions.Items.Add("上川・留萌地方");//012000
                    cbRegions.Items.Add("網走・北見・紋別地方");//013000
                    cbRegions.Items.Add("釧路・根室地方");//014100
                    cbRegions.Items.Add("胆振・日高地方");//015000
                    cbRegions.Items.Add("石狩・空知・後志地方");//016000
                    cbRegions.Items.Add("渡島・檜山地方");//017000
                    break;
                case 1:
                    cbRegions.Items.Add("青森県");//020000
                    cbRegions.Items.Add("岩手県");//030000
                    cbRegions.Items.Add("宮城県");//040000
                    cbRegions.Items.Add("秋田県");//050000
                    cbRegions.Items.Add("山形県");//060000
                    cbRegions.Items.Add("福島県");//070000
                    break;
                case 2:
                    cbRegions.Items.Add("茨城県");//080000
                    cbRegions.Items.Add("栃木県");//090000
                    cbRegions.Items.Add("群馬県");//100000
                    cbRegions.Items.Add("埼玉県");//110000
                    cbRegions.Items.Add("千葉県");//120000
                    cbRegions.Items.Add("東京都");//130000
                    cbRegions.Items.Add("神奈川県");//140000
                    cbRegions.Items.Add("山梨県");//190000
                    cbRegions.Items.Add("長野県");//200000
                    break;
                case 3:
                    cbRegions.Items.Add("岐阜県");//210000
                    cbRegions.Items.Add("静岡県");//220000
                    cbRegions.Items.Add("愛知県");//230000
                    cbRegions.Items.Add("三重県");//240000
                    break;
                case 4:
                    cbRegions.Items.Add("新潟県");//150000
                    cbRegions.Items.Add("富山県");//160000
                    cbRegions.Items.Add("石川県");//170000
                    cbRegions.Items.Add("福井県");//180000
                    break;
                case 5:
                    cbRegions.Items.Add("滋賀県");//250000
                    cbRegions.Items.Add("京都府");//260000
                    cbRegions.Items.Add("大阪府");//270000
                    cbRegions.Items.Add("兵庫県");//280000
                    cbRegions.Items.Add("奈良県");//290000
                    cbRegions.Items.Add("和歌山県");//300000
                    break;
                case 6:
                    cbRegions.Items.Add("鳥取県");//310000
                    cbRegions.Items.Add("島根県");//320000
                    cbRegions.Items.Add("岡山県");//330000
                    cbRegions.Items.Add("広島県");//340000
                    break;
                case 7:
                    cbRegions.Items.Add("徳島県");//360000
                    cbRegions.Items.Add("香川県");//370000
                    cbRegions.Items.Add("愛媛県");//380000
                    cbRegions.Items.Add("高知県");//390000
                    break;
                case 8:
                    cbRegions.Items.Add("山口県");//350000
                    cbRegions.Items.Add("福岡県");//400000
                    cbRegions.Items.Add("佐賀県");//410000
                    cbRegions.Items.Add("長崎県");//420000
                    cbRegions.Items.Add("熊本県");//430000
                    cbRegions.Items.Add("大分県");//440000
                    break;
                case 9:
                    cbRegions.Items.Add("宮崎県");//450000
                    cbRegions.Items.Add("鹿児島県");//460100
                    break;
                case 10:
                    cbRegions.Items.Add("沖縄本島地方");//471000
                    cbRegions.Items.Add("大東島地方");//472000
                    cbRegions.Items.Add("宮古島地方");//473000
                    cbRegions.Items.Add("八重山地方");//474000
                    break;
            }
        }

        //コンボボックスに地方名セット
        private void SetCdPrefectureName() {
            cbPrefecture.Items.Add("北海道地方");
            cbPrefecture.Items.Add("東北地方");
            cbPrefecture.Items.Add("関東甲信地方");
            cbPrefecture.Items.Add("東海地方");
            cbPrefecture.Items.Add("北陸地方");
            cbPrefecture.Items.Add("近畿地方");
            cbPrefecture.Items.Add("中国地方（山口県を除く)");
            cbPrefecture.Items.Add("四国地方");
            cbPrefecture.Items.Add("九州北部地方（山口県を含む)");
            cbPrefecture.Items.Add("九州南部・奄美地方");
            cbPrefecture.Items.Add("沖縄地方");
        }

        private void Form1_Load(object sender, EventArgs e) {
            //実行時に地方名セット
            SetCdPrefectureName();
            EnableCheck();
        }

        private void cbPrefecture_TextChanged(object sender, EventArgs e) {
            int index = cbPrefecture.SelectedIndex;
            SetCbRegionName(index);
            EnableCheck();
        }

        private void cbRegions_TextChanged(object sender, EventArgs e) {
            EnableCheck();
        }

        //選択された地方のエリアコード取得
        private string GetAreaCode(string regions) {
            switch (regions) {
                case "宗谷地方":
                    areaCode = "011000";
                    break;
                case "上川・留萌地方":
                    areaCode = "012000";
                    break;
                case "網走・北見・紋別地方":
                    areaCode = "013000";
                    break;
                case "釧路・根室地方":
                    areaCode = "014100";
                    break;
                case "胆振・日高地方":
                    areaCode = "015000";
                    break;
                case "石狩・空知・後志地方":
                    areaCode = "016000";
                    break;
                case "渡島・檜山地方":
                    areaCode = "017000";
                    break;
                case "青森県":
                    areaCode = "020000";
                    break;
                case "岩手県":
                    areaCode = "030000";
                    break;
                case "宮城県":
                    areaCode = "040000";
                    break;
                case "秋田県":
                    areaCode = "050000";
                    break;
                case "山形県":
                    areaCode = "060000";
                    break;
                case "福島県":
                    areaCode = "070000";
                    break;
                case "茨城県":
                    areaCode = "080000";
                    break;
                case "栃木県":
                    areaCode = "090000";
                    break;
                case "群馬県":
                    areaCode = "100000";
                    break;
                case "埼玉県":
                    areaCode = "110000";
                    break;
                case "千葉県":
                    areaCode = "120000";
                    break;
                case "東京都":
                    areaCode = "130000";
                    break;
                case "神奈川県":
                    areaCode = "140000";
                    break;
                case "山梨県":
                    areaCode = "190000";
                    break;
                case "長野県":
                    areaCode = "200000";
                    break;
                case "岐阜県":
                    areaCode = "210000";
                    break;
                case "静岡県":
                    areaCode = "220000";
                    break;
                case "愛知県":
                    areaCode = "230000";
                    break;
                case "三重県":
                    areaCode = "240000";
                    break;
                case "新潟県":
                    areaCode = "150000";
                    break;
                case "富山県":
                    areaCode = "160000";
                    break;
                case "石川県":
                    areaCode = "170000";
                    break;
                case "福井県":
                    areaCode = "180000";
                    break;
                case "滋賀県":
                    areaCode = "250000";
                    break;
                case "京都府":
                    areaCode = "260000";
                    break;
                case "大阪府":
                    areaCode = "270000";
                    break;
                case "兵庫県":
                    areaCode = "280000";
                    break;
                case "奈良県":
                    areaCode = "290000";
                    break;
                case "和歌山県":
                    areaCode = "300000";
                    break;
                case "鳥取県":
                    areaCode = "310000";
                    break;
                case "島根県":
                    areaCode = "320000";
                    break;
                case "岡山県":
                    areaCode = "330000";
                    break;
                case "広島県":
                    areaCode = "340000";
                    break;
                case "徳島県":
                    areaCode = "360000";
                    break;
                case "香川県":
                    areaCode = "370000";
                    break;
                case "愛媛県":
                    areaCode = "380000";
                    break;
                case "高知県":
                    areaCode = "390000";
                    break;
                case "山口県":
                    areaCode = "350000";
                    break;
                case "福岡県":
                    areaCode = "400000";
                    break;
                case "佐賀県":
                    areaCode = "410000";
                    break;
                case "長崎県":
                    areaCode = "420000";
                    break;
                case "熊本県":
                    areaCode = "430000";
                    break;
                case "大分県":
                    areaCode = "440000";
                    break;
                case "宮崎県":
                    areaCode = "450000";
                    break;
                case "鹿児島県":
                    areaCode = "460100";
                    break;
                case "沖縄本島地方":
                    areaCode = "471000";
                    break;
                case "大東島地方":
                    areaCode = "472000";
                    break;
                case "宮古島地方":
                    areaCode = "473000";
                    break;
                case "八重山地方":
                    areaCode = "474000";
                    break;
            }
            return areaCode;
        }


        //取得ボタンのマスク処理
        private void EnableCheck() {
            btWeatherGet.Enabled = cbRegions.Text.Count() > 0 ? true : false;
        }
    }
}
