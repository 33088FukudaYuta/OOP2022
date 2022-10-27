﻿using System;
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
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;

            red_Slider.Value = color.R;
            green_Slider.Value = color.G;
            blue_Slider.Value = color.B;

            ColorLabel.Background = new SolidColorBrush(Color.FromRgb(color.R, color.G, color.B));
        }

        private void red_Text_KeyUp(object sender, KeyEventArgs e) {
            SetColor();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            SetColor();
        }

        private void SetColor() {
            var r = byte.Parse(red_Text.Text);
            var g = byte.Parse(green_Text.Text);
            var b = byte.Parse(blue_Text.Text);
            ColorLabel.Background = new SolidColorBrush(Color.FromRgb(r, g, b));

            //ColorLabel.Background = new SolidColorBrush(Color.FromRgb((byte)int.Parse(red_Text.Text), (byte)int.Parse(green_Text.Text), (byte)int.Parse(blue_Text.Text)));
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            List<MyColor> colors = new List<MyColor>();
            //colors.Add();
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
