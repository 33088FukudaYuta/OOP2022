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

        private int randomNumber;//乱数保存用
        Random rand = new Random();//乱数オブジェクト生成

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            //入力した値とあらかじめ取得した乱数を比較し結果を表示
            if(nudNum.Value == randomNumber) {
                tbAns.Text = "正解";
            }else if(nudNum.Value > randomNumber) {
                tbAns.Text = "入力した値より低いです";
            }else if(nudNum.Value < randomNumber) {
                tbAns.Text = "入力した値より大きい値です";
            }
        }
        //アプリケーション起動時に一度だけ呼ばれるイベントハンドラ
        private void Form1_Load(object sender, EventArgs e) {
            //乱数取得
            getRandom();
        }

        private void nudNum2_ValueChanged(object sender, EventArgs e) {
            //randomNumber = rand.Next(1, maxValue: (int)nudNum2.Value);
            //tbRand.Text = randomNumber.ToString();
            getRandom();
        }

        //乱数取得
        private void getRandom() {
            randomNumber = rand.Next(1, maxValue: (int)nudNum2.Value);
            tbRand.Text = randomNumber.ToString();
        }
    }
}
