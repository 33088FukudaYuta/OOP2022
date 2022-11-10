using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        List<MyColor> colorList = new List<MyColor>();

        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        private void red_Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            SetColor();
        }

        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {

            red_Slider.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.R;
            green_Slider.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.G;
            blue_Slider.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.B;
            SetColor();

        }

        private void red_Text_KeyUp(object sender, KeyEventArgs e) {
            SetColor();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            SetColor();
        }

        //テキストボックスの値を元に色を設定
        private void SetColor() {
            var r = byte.Parse(red_Text.Text);
            var g = byte.Parse(green_Text.Text);
            var b = byte.Parse(blue_Text.Text);
            ColorLabel.Background = new SolidColorBrush(Color.FromRgb(r, g, b));

            //ColorLabel.Background = new SolidColorBrush(Color.FromRgb((byte)int.Parse(red_Text.Text), (byte)int.Parse(green_Text.Text), (byte)int.Parse(blue_Text.Text)));
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

            MyColor stColor = new MyColor();
            var r = byte.Parse(red_Text.Text);
            var g = byte.Parse(green_Text.Text);
            var b = byte.Parse(blue_Text.Text);
            stColor.Color = Color.FromRgb(r, g, b);

            //テキストボックスのRGB値から色名称があるかチェック
            var colorName = ((IEnumerable<MyColor>)DataContext)
                                .Where(c => c.Color.R == stColor.Color.R &&
                                            c.Color.G == stColor.Color.G &&
                                            c.Color.B == stColor.Color.B).FirstOrDefault();

            stockList.Items.Insert(0,colorName?.Name ?? "R：" + r + "  G：" + g + "  B：" + b);
            colorList.Insert(0,stColor);
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (stockList.SelectedIndex == -1) return;

                red_Slider.Value = colorList[stockList.SelectedIndex].Color.R;
                green_Slider.Value = colorList[stockList.SelectedIndex].Color.G;
                blue_Slider.Value = colorList[stockList.SelectedIndex].Color.B;
                SetColor();
        }

        //DELETEボタンクリック
        private void Delete_Click(object sender, RoutedEventArgs e) {
            var delIndex = stockList.SelectedIndex;

            if (delIndex == -1) return;
                stockList.Items.RemoveAt(delIndex);
                colorList.RemoveAt(delIndex);
        }
    }

    /// <summary>
    /// 色と色名を保持するクラス
    /// </summary>
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
