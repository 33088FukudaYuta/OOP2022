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
    /// Page1.xaml の相互作用ロジック
    /// </summary>
    ///

    public partial class Page1 : Page {

        public static int allsum; //すべてのカテゴリの合計金額
        int totalMoney; //入力した金額

        public static int total_foodex = 0; //食費の合計金額
        public static int total_fashion = 0; //衣類・ファッションの合計金額
        public static int total_photothermalfee = 0; //光熱費の合計金額
        public static int total_travellingex = 0; //交通費の合計金額
        public static int total_communicationscost = 0; //通信費の合計金額
        public static int total_insurance = 0; //保険の合計金額
        public static int total_book = 0; //本・雑誌の合計金額
        public static int total_rent = 0; //家賃の合計金額
        public static int total_everydayitem = 0; //日用品の合計金額
        public static int total_medicalex = 0; //医療品・医療費の合計金額
        public static int total_travelex = 0; //旅費交通費の合計金額
        public static int total_phone = 0; //携帯電話・インターネットの合計金額


        string categoryName;

        public Page1() {
            InitializeComponent();

        }

        //登録ボタンを押したときの処理
        private void button_registration_Click(object sender, RoutedEventArgs e) {
            try {
                totalMoney = int.Parse(Text_money.Text);
                allsum += totalMoney;
                CategorySum();
                dg_moneydata.Items.Insert(0, string.Format("{0}   {1}：{2:N0}円", dp_day.Text, categoryName, totalMoney));

                categoryName = null;

                Text_money.Text = null;

                button_registration.IsEnabled = false;
            }
            catch (OverflowException ex) {
                MessageBox.Show(ex.Message);
                Text_money.Text = null;
            }
        }

        private void Text_money_TextChanged(object sender, TextChangedEventArgs e) {
            EnableCheck();
        }

        private void EnableCheck() {
            if (Text_money.Text != null) {
                button_registration.IsEnabled = true;
            }else if(Text_money.Text == null) {
                button_registration.IsEnabled = false;
            }
        }

        //カテゴリごとの合計金額とカテゴリ名を求める処理
        private void CategorySum() {
            if(tbutton_foodex.IsChecked == true) {
                total_foodex += totalMoney;
                tbutton_foodex.IsChecked = false;
                categoryName = tbutton_foodex.Content.ToString();

            }else if (tbutton_fashion.IsChecked == true) {
                total_fashion += totalMoney;
                tbutton_fashion.IsChecked = false;
                categoryName = tbutton_fashion.Content.ToString();

            } else if(tbutton_photothermalfee.IsChecked == true) {
                total_photothermalfee += totalMoney;
                tbutton_photothermalfee.IsChecked = false;
                categoryName = tbutton_photothermalfee.Content.ToString();


            } else if(tbutton_travellingex.IsChecked == true) {
                total_travellingex += totalMoney;
                tbutton_travellingex.IsChecked = false;
                categoryName=tbutton_travellingex.Content.ToString();

            } else if(tbutton_communicationscost.IsChecked == true) {
                total_communicationscost += totalMoney;
                tbutton_communicationscost.IsChecked = false;
                categoryName = tbutton_communicationscost.Content.ToString();

            } else if(tbutton_insurance.IsChecked == true) {
                total_insurance += totalMoney;
                tbutton_insurance.IsChecked = false;
                categoryName = tbutton_insurance.Content.ToString();

            } else if(tbutton_book.IsChecked == true) {
                total_book += totalMoney;
                tbutton_book.IsChecked = false;
                categoryName = tbutton_book.Content.ToString();

            } else if(tbutton_rent.IsChecked == true) {
                total_rent += totalMoney;
                tbutton_rent.IsChecked = false;
                categoryName = tbutton_rent.Content.ToString();

            } else if (tbutton_everydayitem.IsChecked == true) {
                total_everydayitem += totalMoney;
                tbutton_everydayitem.IsChecked = false;
                categoryName = tbutton_everydayitem.Content.ToString();

            } else if(tbutton_medicalex.IsChecked == true) {
                total_medicalex += totalMoney;
                tbutton_medicalex.IsChecked = false;
                categoryName = tbutton_medicalex.Content.ToString();

            } else if(tbutton_travelex.IsChecked == true) {
                total_travelex += totalMoney;
                tbutton_travelex.IsChecked = false;
                categoryName = tbutton_travelex.Content.ToString();

            } else if(tbutton_phone.IsChecked == true) {
                total_phone += totalMoney;
                tbutton_phone.IsChecked = false;
                categoryName = tbutton_phone.Content.ToString();
            }
        }

        private void tbutton_foodex_Checked(object sender, RoutedEventArgs e) {
            tbutton_book.IsChecked = tbutton_communicationscost.IsChecked = tbutton_everydayitem.IsChecked = tbutton_fashion.IsChecked
            = tbutton_insurance.IsChecked = tbutton_medicalex.IsChecked = tbutton_phone.IsChecked = tbutton_photothermalfee.IsChecked
            = tbutton_rent.IsChecked = tbutton_travelex.IsChecked = tbutton_travellingex.IsChecked = false;
        }

        private void tbutton_fashion_Checked(object sender, RoutedEventArgs e) {
            tbutton_book.IsChecked = tbutton_communicationscost.IsChecked = tbutton_everydayitem.IsChecked = tbutton_foodex.IsChecked
            = tbutton_insurance.IsChecked = tbutton_medicalex.IsChecked = tbutton_phone.IsChecked = tbutton_photothermalfee.IsChecked
            = tbutton_rent.IsChecked = tbutton_travelex.IsChecked = tbutton_travellingex.IsChecked = false;
        }

        private void tbutton_photothermalfee_Checked(object sender, RoutedEventArgs e) {
            tbutton_book.IsChecked = tbutton_communicationscost.IsChecked = tbutton_everydayitem.IsChecked = tbutton_foodex.IsChecked
            = tbutton_insurance.IsChecked = tbutton_medicalex.IsChecked = tbutton_phone.IsChecked = tbutton_fashion.IsChecked
            = tbutton_rent.IsChecked = tbutton_travelex.IsChecked = tbutton_travellingex.IsChecked = false;
        }

        private void tbutton_travellingex_Checked(object sender, RoutedEventArgs e) {
            tbutton_book.IsChecked = tbutton_communicationscost.IsChecked = tbutton_everydayitem.IsChecked = tbutton_fashion.IsChecked
            = tbutton_insurance.IsChecked = tbutton_medicalex.IsChecked = tbutton_phone.IsChecked = tbutton_photothermalfee.IsChecked
            = tbutton_rent.IsChecked = tbutton_travelex.IsChecked = tbutton_foodex.IsChecked = false;
        }

        private void tbutton_communicationscost_Checked(object sender, RoutedEventArgs e) {
            tbutton_book.IsChecked = tbutton_foodex.IsChecked = tbutton_everydayitem.IsChecked = tbutton_fashion.IsChecked
            = tbutton_insurance.IsChecked = tbutton_medicalex.IsChecked = tbutton_phone.IsChecked = tbutton_photothermalfee.IsChecked
            = tbutton_rent.IsChecked = tbutton_travelex.IsChecked = tbutton_travellingex.IsChecked = false;
        }

        private void tbutton_insurance_Checked(object sender, RoutedEventArgs e) {
            tbutton_book.IsChecked = tbutton_communicationscost.IsChecked = tbutton_everydayitem.IsChecked = tbutton_fashion.IsChecked
            = tbutton_foodex.IsChecked = tbutton_medicalex.IsChecked = tbutton_phone.IsChecked = tbutton_photothermalfee.IsChecked
            = tbutton_rent.IsChecked = tbutton_travelex.IsChecked = tbutton_travellingex.IsChecked = false;
        }

        private void tbutton_book_Checked(object sender, RoutedEventArgs e) {
            tbutton_foodex.IsChecked = tbutton_communicationscost.IsChecked = tbutton_everydayitem.IsChecked = tbutton_fashion.IsChecked
            = tbutton_insurance.IsChecked = tbutton_medicalex.IsChecked = tbutton_phone.IsChecked = tbutton_photothermalfee.IsChecked
            = tbutton_rent.IsChecked = tbutton_travelex.IsChecked = tbutton_travellingex.IsChecked = false;
        }

        private void tbutton_rent_Checked(object sender, RoutedEventArgs e) {
            tbutton_book.IsChecked = tbutton_communicationscost.IsChecked = tbutton_everydayitem.IsChecked = tbutton_fashion.IsChecked
            = tbutton_insurance.IsChecked = tbutton_medicalex.IsChecked = tbutton_phone.IsChecked = tbutton_photothermalfee.IsChecked
            = tbutton_foodex.IsChecked = tbutton_travelex.IsChecked = tbutton_travellingex.IsChecked = false;
        }

        private void tbutton_everydayitem_Checked(object sender, RoutedEventArgs e) {
            tbutton_book.IsChecked = tbutton_communicationscost.IsChecked = tbutton_foodex.IsChecked = tbutton_fashion.IsChecked
            = tbutton_insurance.IsChecked = tbutton_medicalex.IsChecked = tbutton_phone.IsChecked = tbutton_photothermalfee.IsChecked
            = tbutton_rent.IsChecked = tbutton_travelex.IsChecked = tbutton_travellingex.IsChecked = false;
        }

        private void tbutton_medicalex_Checked(object sender, RoutedEventArgs e) {
            tbutton_book.IsChecked = tbutton_communicationscost.IsChecked = tbutton_everydayitem.IsChecked = tbutton_fashion.IsChecked
            = tbutton_insurance.IsChecked = tbutton_foodex.IsChecked = tbutton_phone.IsChecked = tbutton_photothermalfee.IsChecked
            = tbutton_rent.IsChecked = tbutton_travelex.IsChecked = tbutton_travellingex.IsChecked = false;
        }

        private void tbutton_travelex_Checked(object sender, RoutedEventArgs e) {
            tbutton_book.IsChecked = tbutton_communicationscost.IsChecked = tbutton_everydayitem.IsChecked = tbutton_fashion.IsChecked
            = tbutton_insurance.IsChecked = tbutton_medicalex.IsChecked = tbutton_phone.IsChecked = tbutton_photothermalfee.IsChecked
            = tbutton_rent.IsChecked = tbutton_foodex.IsChecked = tbutton_travellingex.IsChecked = false;
        }

        private void tbutton_phone_Checked(object sender, RoutedEventArgs e) {
            tbutton_book.IsChecked = tbutton_communicationscost.IsChecked = tbutton_everydayitem.IsChecked = tbutton_fashion.IsChecked
            = tbutton_insurance.IsChecked = tbutton_medicalex.IsChecked = tbutton_foodex.IsChecked = tbutton_photothermalfee.IsChecked
            = tbutton_rent.IsChecked = tbutton_travelex.IsChecked = tbutton_travellingex.IsChecked = false;
        }

        private void dp_day_SelectedDateChanged(object sender, SelectionChangedEventArgs e) {
            tbutton_book.IsEnabled = tbutton_communicationscost.IsEnabled = tbutton_everydayitem.IsEnabled = tbutton_fashion.IsEnabled
            = tbutton_insurance.IsEnabled = tbutton_medicalex.IsEnabled = tbutton_foodex.IsEnabled = tbutton_photothermalfee.IsEnabled
            = tbutton_rent.IsEnabled = tbutton_travelex.IsEnabled = tbutton_travellingex.IsEnabled = tbutton_phone.IsEnabled = true;

            if(Text_money.Text == null) {
                button_registration.IsEnabled = false;
            }
        }

        //テキストボックスに数字のみ入力可能
        private void Text_money_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            if (!char.IsDigit(e.Text, e.Text.Length - 1)) e.Handled = true;
        }

    }
}
