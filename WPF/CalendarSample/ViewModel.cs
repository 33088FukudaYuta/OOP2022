using GalaSoft.MvvmLight.Command;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;

namespace CalendarSample {
    internal class ViewModel : INotifyPropertyChanged {

        //チャート関連
        public Chart chart1;
        ChartArea chartarea1;
        Series series1;

        //X軸の要素数
        int cnt = 0;

        public ViewModel() {
            AddRowCommand = new AddRowCommand(this);
            InitializeDataTable();

            //チャート関連
            chart1 = new Chart();
            chartarea1 = chart1.ChartAreas.Add("Area1");
            series1 = new Series();

            //チャート初期化
            ChartInitialize();

            //コマンド
            ClearBtn_Pushed = new RelayCommand(ChartClear_cmd);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private readonly DataTable dataTable = new DataTable();

        //登録コマンド
        public ICommand AddRowCommand { get; set; }

        //グラフクリアコマンド
        public ICommand ClearBtn_Pushed { get; set; }

        private DataRowView selectedRow;

        public DataRowView SelectedRow {
            get => selectedRow;
            set {
                selectedRow = value;
                OnPropertyChanged(nameof(SelectedRow));
            }
        }

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

        //DataGrid行追加
        public void AddRow(string day, int money, string categoryName) {
            var row = dataTable.NewRow();
            row[0] = day;
            row[1] = money;
            row[2] = categoryName;
            dataTable.Rows.Add(row);
            NotifyTableUpdate();
        }


        //チャート初期化
        private void ChartInitialize() {
            //ChartAreaの設定(軸ラベル)
            chartarea1.AxisX.Title = "年月日";
            chartarea1.AxisY.Title = "金額";


            //Seriesの初期設定(グラフの種類、線の太さ)
            series1.ChartType = SeriesChartType.Column;
            series1.BorderWidth = 2;

            //ChartにSeriesを追加
            chart1.Series.Add(series1);
        }

        //要素追加コマンド
        public void Add_cmd() {
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
            series1.Points.AddXY(MainWindow.choiceDay, MainWindow.total_Money);

            //x軸要素を増やす
            cnt++;
        }
    }
    internal class AddRowCommand : ICommand {
        private readonly ViewModel vm;

        public AddRowCommand(ViewModel vm) {
            this.vm = vm;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) {
            vm.AddRow(vm.InputDay, vm.InputMoney, vm.InputCategoryName);
            vm.Add_cmd();
        }

        public event EventHandler CanExecuteChanged;
    }
}

