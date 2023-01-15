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

        public static string date;

        public Page3() {
            InitializeComponent();
            DataContext = new DataTableViewModel();
        }

        private void page3_Loaded(object sender, RoutedEventArgs e) {
            SetCategoryName();
            tb_Money.Text = null;
        }

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

        private void dp_day_SelectedDateChanged(object sender, SelectionChangedEventArgs e) {
            date = dp_day.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            tb_Money.Text = null;
            cb_CategoryName.IsDropDownOpen = true;
        }
    }
}
