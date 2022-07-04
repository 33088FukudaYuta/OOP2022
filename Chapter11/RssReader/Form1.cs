using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace RssReader {
    public partial class Form1 : Form {

        List<string> linkList = new List<string>();
        List<string> titleList = new List<string>();

        public Form1() {
            InitializeComponent();
        }

        private void btRSSGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var stream = wc.OpenRead(cbRSSUrl.Text);

                var xdoc = XDocument.Load(stream);

                var xTitle = xdoc.Root.Descendants("item").Select(x => (string)x.Element("title"));

                foreach (var titles in xTitle) {
                    titleList.Add(titles);
                    if (!lbRSSTitle.Items.Contains(titles)) { // タイトルの表示(重複なし)
                        lbRSSTitle.Items.Add(titles);
                    }
                }

                var xlink = xdoc.Root.Descendants("item").Select(x => (string)x.Element("link"));

                foreach (var links in xlink) {
                    linkList.Add(links);
                }
            }
        }

        private void lbRSSTitle_Click(object sender, EventArgs e) {
            
            var index = lbRSSTitle.SelectedIndex; //選択した個所のインデックスを取得(0～）
            if (index == -1) return;
            wvBrowser.Navigate(linkList[index]);
        }

        private void btBack_Click(object sender, EventArgs e) {
            wvBrowser.GoBack();
        }

        private void btNext_Click(object sender, EventArgs e) {
            wvBrowser.GoForward();
        }

        private void Form1_Load(object sender, EventArgs e) {
            BackForwardButtonMaskCheck();
        }
        private void BackForwardButtonMaskCheck() {
            //進む・戻るボタンのマスク処理を行う
            btNext.Enabled = wvBrowser.CanGoForward;
            btBack.Enabled = wvBrowser.CanGoBack;
        }

        private void wvBrowser_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e) {
            BackForwardButtonMaskCheck();
        }
    }
}
