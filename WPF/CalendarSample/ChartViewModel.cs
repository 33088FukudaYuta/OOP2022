using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;

namespace CalendarSample {
    internal class ChartViewModel : DataTableViewModel{
        public Chart chart1;
        Title title;
        ChartArea chartarea1;
        Series series1;

        //チャート用パラメータ
        int cnt = 0;
        Random rdm;

        //コマンド
        public ICommand AddBtn_Pushed { get; set; }
        public ICommand ClearBtn_Pushed { get; set; }

        public ChartViewModel() {
            //チャート関連
            chart1 = new Chart();
            title = new Title("グラフタイトル");
            chartarea1 = chart1.ChartAreas.Add("Area1");
            series1 = new Series();

            //チャート初期化
            ChartInitialize();

            //コマンド
            AddBtn_Pushed = new RelayCommand(Add_cmd);
            ClearBtn_Pushed = new RelayCommand(ChartClear_cmd);

            //他(要素生成用)
            rdm = new Random();
        }

        //チャート初期化
        private void ChartInitialize() {
            //ChartAreaの設定(グラフタイトル、軸ラベル)
            title.DockedToChartArea = "Area1";
            chartarea1.AxisX.Title = "年月日";
            chartarea1.AxisY.Title = "金額";
            

            //Seriesの初期設定(グラフの種類、線の太さ、凡例)
            series1.ChartType = SeriesChartType.Column;
            series1.BorderWidth = 2;
            //series1.LegendText = "Number:1";

            //ChartにTitle,Seriesを追加
            chart1.Titles.Add(title);
            chart1.Series.Add(series1);
        }

        //要素追加コマンド
        private void Add_cmd() {
            AddComponent();
        }

        //チャート要素クリアコマンド
        private void ChartClear_cmd() {
            series1.Points.Clear();
            cnt = 0;
        }

        //チャート要素追加するメソッド
        public void AddComponent() {
            //グラフ要素を追加する
            series1.Points.AddXY(Page3.choiceDay, Page3.total_Money);
            
            //series1.Points.AddXY(cnt, rdm.NextDouble());

            //x軸要素を増やす
            cnt++;
        }
    }
}
