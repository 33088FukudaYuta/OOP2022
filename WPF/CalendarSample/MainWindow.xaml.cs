using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using MessageBox = System.Windows.Forms.MessageBox;

namespace CalendarSample {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        List<Date> dateList = new List<Date>();

        public static int num = 0;

        public static string choiceDay;//選択した年月日を格納
        public static int total_Money;//入力した金額格納
        public static string categoryName;//入力したカテゴリ名格納

        int foodcost = 0; //食費の合計金額
        int fashioncost = 0; //衣類・ファッションの合計金額
        int utilitycost = 0; //光熱費の合計金額
        int travellingex = 0; //交通費の合計金額
        int comcost = 0; //通信費の合計金額
        int insurancecost = 0; //保険の合計金額
        int bookcost = 0; //本・雑誌の合計金額
        int rentcost = 0; //家賃の合計金額
        int everydayitemcost = 0; //日用品の合計金額
        int medicalcost = 0; //医療品・医療費の合計金額
        int travelcost = 0; //旅費交通費の合計金額
        int incidentalscost = 0; //雑費の合計金額

        int allcost = 0;//全てのカテゴリーの合計金額

        public MainWindow() {
            InitializeComponent();
            //DataTableViewModel viewModel = new DataTableViewModel();
            //DataContext = viewModel;
            //DataContext = new DataTableViewModel();

            ChartViewModel cvm = new ChartViewModel();
            DataContext = cvm;

            //Chart関連
            Chart1v.Child = cvm.chart1;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            SetCategoryName();
            tb_Money.Text = null;
            bt_registrarion.IsEnabled = false;
        }


        private void dp_day_SelectedDateChanged(object sender, SelectionChangedEventArgs e) {
            choiceDay = dp_day.Text;
        }

        //登録ボタンを押したときの処理
        private void Button_Click(object sender, RoutedEventArgs e) {
            //現在選択されいるインデックスの取得
            int index = cb_CategoryName.SelectedIndex;

            total_Money = int.Parse(tb_Money.Text);
            allcost += total_Money;
            lb_AllCost.Content = string.Format("{0:N0}円", allcost);

            Date newDate = new Date {
                day = choiceDay,
                money = total_Money,
                categoryName = cb_CategoryName.Text
            };

            dateList.Add(newDate);

            CategoryMoney(index);

            tb_Money.Text = null;
            cb_CategoryName.IsDropDownOpen = true;
            bt_registrarion.IsEnabled = false;
        }

        private void tb_Money_TextChanged(object sender, TextChangedEventArgs e) {
            EnableCheck();
        }
        //ComboBoxにカテゴリー名をセット
        private void SetCategoryName() {
            cb_CategoryName.Items.Add("食費");
            cb_CategoryName.Items.Add("衣服費");
            cb_CategoryName.Items.Add("水道光熱費");
            cb_CategoryName.Items.Add("交通費");
            cb_CategoryName.Items.Add("通信費");
            cb_CategoryName.Items.Add("保険料");
            cb_CategoryName.Items.Add("本・雑誌");
            cb_CategoryName.Items.Add("住宅費");
            cb_CategoryName.Items.Add("日用品");
            cb_CategoryName.Items.Add("医療費");
            cb_CategoryName.Items.Add("旅費交通費");
            cb_CategoryName.Items.Add("雑費");
        }

        private void EnableCheck() {
            if (tb_Money.Text != null && cb_CategoryName.Text != null) {
                bt_registrarion.IsEnabled = true;
            } else if (tb_Money.Text == null && cb_CategoryName.Text == null) {
                bt_registrarion.IsEnabled = false;
            }
        }

        //テキストボックスに数字のみ入力可能にする処理
        private void tb_Money_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            if (!char.IsDigit(e.Text, e.Text.Length - 1)) e.Handled = true;
        }

        //カテゴリーごとの合計金額を求める処理
        private void CategoryMoney(int num) {
            switch (num) {
                case 0:
                    foodcost += total_Money;
                    lb_foodcost.Content = string.Format("{0:N0}円", foodcost);
                    break;
                case 1:
                    fashioncost += total_Money;
                    lb_fashiocost.Content = string.Format("{0:N0}円", fashioncost);
                    break;
                case 2:
                    utilitycost += total_Money;
                    lb_utilitycost.Content = string.Format("{0:N0}円", utilitycost);
                    break;
                case 3:
                    travellingex += total_Money;
                    lb_travelingcost.Content = string.Format("{0:N0}円", travellingex);
                    break;
                case 4:
                    comcost += total_Money;
                    lb_comcost.Content = string.Format("{0:N0}円", comcost);
                    break;
                case 5:
                    insurancecost += total_Money;
                    lb_insurancecost.Content = string.Format("{0:N0}円", insurancecost);
                    break;
                case 6:
                    bookcost += total_Money;
                    lb_bookcost.Content = string.Format("{0:N0}円", bookcost);
                    break;
                case 7:
                    rentcost += total_Money;
                    lb_housecost.Content = string.Format("{0:N0}円", rentcost);
                    break;
                case 8:
                    everydayitemcost += total_Money;
                    lb_everyitemcost.Content = string.Format("{0:N0}円", everydayitemcost);
                    break;
                case 9:
                    medicalcost += total_Money;
                    lb_medicalcost.Content = string.Format("{0:N0}円", medicalcost);
                    break;
                case 10:
                    travelcost += total_Money;
                    lb_travelcost.Content = string.Format("{0:N0}円", travelcost);
                    break;
                case 11:
                    incidentalscost += total_Money;
                    lb_incidentalscost.Content = string.Format("{0:N0}円", incidentalscost);
                    break;
            }
        }

        private void ExportCSV(object sender, RoutedEventArgs e) {
            SaveFileDialog dlg = new SaveFileDialog();

            // デフォルトファイル名
            dlg.FileName = "cat.csv";

            // デフォルトディレクトリ
            dlg.InitialDirectory = @"c:\";

            // ファイルのフィルタ
            dlg.Filter = "CSVファイル|*.csv|すべてのファイル|*.*";

            // ファイルの種類
            dlg.FilterIndex = 0;
        }
    }

    public class Date {
        public string day { get; set; }
        public int money { get; set; }
        public string categoryName { get; set; }
    }
}

