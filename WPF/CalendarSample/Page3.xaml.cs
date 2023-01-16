using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalendarSample {
    /// <summary>
    /// Page3.xaml の相互作用ロジック
    /// </summary>
    public partial class Page3 : Page {

        public static string choiceDay;//選択した日付を格納
        int total_Money;//入力した金額格納

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
        int phonecost = 0; //携帯電話・インターネットの合計金額



        public Page3() {
            InitializeComponent();
            DataContext = new DataTableViewModel();
        }

        private void page3_Loaded(object sender, RoutedEventArgs e) {
            SetCategoryName();
            tb_Money.Text = null;
            bt_registrarion.IsEnabled = false;
        }

        private void dp_day_SelectedDateChanged(object sender, SelectionChangedEventArgs e) {
            choiceDay = dp_day.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            //現在選択されいるインデックスの取得
            int index = cb_CategoryName.SelectedIndex;

            total_Money = int.Parse(tb_Money.Text);
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
            cb_CategoryName.Items.Add("衣類・ファッション");
            cb_CategoryName.Items.Add("光熱費");
            cb_CategoryName.Items.Add("交通費");
            cb_CategoryName.Items.Add("通信費");
            cb_CategoryName.Items.Add("保険");
            cb_CategoryName.Items.Add("本・雑誌");
            cb_CategoryName.Items.Add("家賃");
            cb_CategoryName.Items.Add("日用品");
            cb_CategoryName.Items.Add("医療品・医療費");
            cb_CategoryName.Items.Add("旅費交通費");
            cb_CategoryName.Items.Add("携帯・インターネット");
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
                    phonecost += total_Money;
                    lb_phonecost.Content = string.Format("{0:N0}円", phonecost);
                    break;
            }
        }
    }
}
