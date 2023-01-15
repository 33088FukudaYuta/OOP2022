using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CalendarSample {
    internal class DataTableViewModel : INotifyPropertyChanged{

        public DataTableViewModel() {
            AddRowCommand = new AddRowCommand(this);
            InitializeDataTable();
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private readonly DataTable dataTable = new DataTable();

        public ICommand AddRowCommand { get; }

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
            get => Page3.date;
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
            dataTable.Columns.Add("カテゴリ");
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
    }
}
