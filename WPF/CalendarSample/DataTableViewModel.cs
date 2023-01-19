using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Input;

namespace CalendarSample {
    public class DataTableViewModel : INotifyPropertyChanged{

        public DataTableViewModel() {
            AddRowCommand = new AddRowCommand(this);
            InitializeDataTable();
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private readonly DataTable dataTable = new DataTable();

        public ICommand AddRowCommand { get;}

        private DataRowView selectedRow;

        public DataRowView SelectedRow {
            get => selectedRow;
            set {
                selectedRow = value;
                OnPropertyChanged(nameof(SelectedRow));
            }
        }

        //private string inputDay;
        private string inputDay;
        public string InputDay {
            get => MainWindow.choiceDay;
            set {
                inputDay = value;
                OnPropertyChanged(nameof(InputDay));
            }
        }

        private int inputMoney;
        public int InputMoney {
            get => inputMoney;
            set {
                inputMoney = value;
                OnPropertyChanged(nameof(InputMoney));
            }
        }

        private string inputcategoryName;
        public string InputCategoryName {
            get => inputcategoryName;
            set {
                inputcategoryName = value;
                OnPropertyChanged(nameof(InputCategoryName));
            }
        }

        public DataView DataTableView => new DataView(dataTable);

        private void NotifyTableUpdate() {
            OnPropertyChanged(nameof(DataTableView));
        }

        private void InitializeDataTable() { 
            dataTable.Columns.Clear();
            dataTable.Rows.Clear();
            dataTable.Columns.Add("年月日");
            dataTable.Columns.Add("金額");
            dataTable.Columns.Add("内訳");
            NotifyTableUpdate();
        }

        public void AddRow(string day, int money,string categoryName) {
            var row = dataTable.NewRow();
            row[0] = day;
            row[1] = money;
            row[2] = categoryName;
            dataTable.Rows.Add(row);
            NotifyTableUpdate();
        }
    }
    internal class AddRowCommand : ICommand {
        private readonly DataTableViewModel vm;

        public AddRowCommand(DataTableViewModel vm) {
            this.vm = vm;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) {
            vm.AddRow(vm.InputDay,vm.InputMoney,vm.InputCategoryName);
        }

        public event EventHandler CanExecuteChanged;

        /*public Chart chart1;
        Title title;
        ChartArea chartarea1;
        Series series1;

        //チャート用パラメータ
        int cnt = 0;
        Random rdm;

        //コマンド
        public ICommand AddBtn_Pushed { get; set; }
        public ICommand ClearBtn_Pushed { get; set; }

        public void DataTableViewModel() {
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
            chartarea1.AxisX.Title = "X軸ラベル";
            chartarea1.AxisY.Title = "Y軸ラベル";

            //Seriesの初期設定(グラフの種類、線の太さ、凡例)
            series1.ChartType = SeriesChartType.Column;
            series1.BorderWidth = 2;
            series1.LegendText = "Number:1";

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

        //チャート要素追加
        private void AddComponent() {
            //グラフ要素を追加する
            series1.Points.AddXY(cnt, rdm.NextDouble());

            //x軸要素を増やす
            cnt++;
        }
    }
    /*public class ChartViewModel {
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
            chartarea1.AxisX.Title = "X軸ラベル";
            chartarea1.AxisY.Title = "Y軸ラベル";

            //Seriesの初期設定(グラフの種類、線の太さ、凡例)
            series1.ChartType = SeriesChartType.Column;
            series1.BorderWidth = 2;
            series1.LegendText = "Number:1";

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

        //チャート要素追加
        private void AddComponent() {
            //グラフ要素を追加する
            series1.Points.AddXY(cnt, rdm.NextDouble());

            //x軸要素を増やす
            cnt++;
        }*/
    }
}
