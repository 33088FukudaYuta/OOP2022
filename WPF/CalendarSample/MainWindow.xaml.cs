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
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        private NavigationService navi;
        public MainWindow() {
            InitializeComponent();

            navi = this.frame.NavigationService;
        }

        private List<Uri> uriList = new List<Uri>() {
            new Uri("Page1.xaml",UriKind.Relative),
            new Uri("Page2.xaml",UriKind.Relative),
        };

        private void frame_Loaded(object sender, RoutedEventArgs e) {
            navi.Navigate(uriList[0]);
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            Button bt = (Button)sender;

            navi.Navigate(uriList[int.Parse((string)bt.Tag)-1]);

        }
    }
}
