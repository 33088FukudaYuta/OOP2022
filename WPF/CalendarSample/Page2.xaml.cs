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
    /// Page2.xaml の相互作用ロジック
    /// </summary>
    public partial class Page2 : Page {
        public Page2() {
            InitializeComponent();
            
        }

        private void page_Loaded(object sender, RoutedEventArgs e) {
            lb_bookcost.Content = string.Format("{0:N0}円",Page1.total_book);
            lb_comcost.Content = string.Format("{0:N0}円", Page1.total_communicationscost);
            lb_everyitemcost.Content = string.Format("{0:N0}円", Page1.total_everydayitem);
            lb_fashiocost.Content = string.Format("{0:N0}円", Page1.total_fashion);
            lb_foodcost.Content = string.Format("{0:N0}円", Page1.total_foodex);
            lb_insurancecost.Content = string.Format("{0:N0}円", Page1.total_insurance);
            lb_medicalcost.Content = string.Format("{0:N0}円", Page1.total_medicalex);
            lb_phonecost.Content = string.Format("{0:N0}円", Page1.total_phone);
            lb_utilitycost.Content = string.Format("{0:N0}円", Page1.total_photothermalfee);
            lb_housecost.Content = string.Format("{0:N0}円", Page1.total_rent);
            lb_travelcost.Content = string.Format("{0:N0}円", Page1.total_travelex);
            lb_travelingcost.Content = string.Format("{0:N0}円", Page1.total_travellingex);

        }

        private void page_closing(object sender, ContextMenuEventArgs e) {
            //Properties.Settings.Default.Total_foodcost = int.Parse(lb_foodcost.Content.ToString());
            Properties.Settings.Default.Total_foodcost = Page1.total_foodex;
            Properties.Settings.Default.Save();
        }

        private void page_open(object sender, ContextMenuEventArgs e) {
            lb_foodcost.Content = Properties.Settings.Default.Total_foodcost;
        }
    }
}
