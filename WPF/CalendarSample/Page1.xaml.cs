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

        int allsum; //すべてのカテゴリの合計金額
        int countnumber; //個数
        int totalMoney; //入力した金額

        int multisum; //個数と入力した金額を掛け算した合計

        int total_foodex = 0; //食費の合計金額
        int total_fashion = 0; //衣類・ファッションの合計金額
        int total_photothermalfee = 0; //光熱費の合計金額
        int total_travellingex = 0; //交通費の合計金額
        int total_communicationscost = 0; //通信費の合計金額
        int total_insurance = 0; //保険の合計金額
        int total_book = 0; //本・雑誌の合計金額
        int total_rent = 0; //家賃の合計金額
        int total_everydayitem = 0; //日用品の合計金額
        int total_medicalex = 0; //医療品・医療費の合計金額
        int total_travelex = 0; //旅費交通費の合計金額
        int total_phone = 0; //携帯電話・インターネットの合計金額


        public Page1() {
            InitializeComponent();
        }

        private void button_numplus_Click(object sender, RoutedEventArgs e) {
            countnumber = int.Parse(Text_num.Text);
            countnumber++;
            Text_num.Text = countnumber.ToString();
            Enable();
        }

        private void button_minus_Click(object sender, RoutedEventArgs e) {
            countnumber = int.Parse(Text_num.Text);
            countnumber--;
            Text_num.Text = countnumber.ToString();
            Enable();
        }

        //ボタンのマスク処理
        private void Enable() {
            if(int.Parse(Text_num.Text) > 1) {
                button_minus.IsEnabled = true;
            } else {
                button_minus.IsEnabled = false;
            }
        }

        private void button_registration_Click(object sender, RoutedEventArgs e) {
            totalMoney = int.Parse(Text_money.Text);
            countnumber = int.Parse(Text_num.Text);

            multisum = totalMoney * countnumber;

            allsum += multisum; 
            CategorySum(); 
            moneyList.Items.Insert(0,multisum);

            Text_money.Text = null;
            Text_num.Text = "1";
            Enable();
            button_registration.IsEnabled = false;
        }

        private void Text_money_TextChanged(object sender, TextChangedEventArgs e) {
            if (Text_money.Text != null) {
                button_registration.IsEnabled = true;
            } else if (Text_money.Text == null) {
                button_registration.IsEnabled = false;
            }
        }

        //カテゴリごとの合計金額を求める処理
        private void CategorySum() {
            if(tbutton_foodex.IsChecked == true) {
                total_foodex += multisum;
                tbutton_foodex.IsChecked = false;

            }else if (tbutton_fashion.IsChecked == true) {
                total_fashion += multisum;
                tbutton_fashion.IsChecked = false;

            } else if(tbutton_photothermalfee.IsChecked == true) {
                total_photothermalfee += multisum;
                tbutton_photothermalfee.IsChecked = false;

            } else if(tbutton_travellingex.IsChecked == true) {
                total_travellingex += multisum;
                tbutton_travellingex.IsChecked = false;

            } else if(tbutton_communicationscost.IsChecked == true) {
                total_communicationscost += multisum;
                tbutton_communicationscost.IsChecked = false;

            } else if(tbutton_insurance.IsChecked == true) {
                total_insurance += multisum;
                tbutton_insurance.IsChecked = false;

            } else if(tbutton_book.IsChecked == true) {
                total_book += multisum;
                tbutton_book.IsChecked = false;

            } else if(tbutton_rent.IsChecked == true) {
                total_rent += multisum;
                tbutton_rent.IsChecked = false;

            } else if (tbutton_everydayitem.IsChecked == true) {
                total_everydayitem += multisum;
                tbutton_everydayitem.IsChecked = false;

            } else if(tbutton_medicalex.IsChecked == true) {
                total_medicalex += multisum;
                tbutton_medicalex.IsChecked = false;

            } else if(tbutton_travelex.IsChecked == true) {
                total_travelex += multisum;
                tbutton_travelex.IsChecked = false;

            } else if(tbutton_phone.IsChecked == true) {
                total_phone += multisum;
                tbutton_phone.IsChecked = false;
            }
        }
    }
}
