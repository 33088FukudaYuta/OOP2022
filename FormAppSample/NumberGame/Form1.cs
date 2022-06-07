using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame {
    public partial class Form1 : Form {

        //乱数
        private int randomNumber;

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            //入力した値とあらかじめ取得した乱数を比較し結果を表示
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            //乱数取得
            randomNumber = 2;
        }
    }
}
