using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

        }

        private void addressTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.addressTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202208DataSet);

        }

        private void Form1_Load(object sender, EventArgs e) {
                pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            
        }

        private void addressTableDataGridView_Click(object sender, EventArgs e) {
            if (addressTableDataGridView.CurrentRow == null)
                return;
            //データグリッドビューの選択レコードを各テキストボックスへ設定
            tbName.Text = addressTableDataGridView.CurrentRow.Cells[1].Value.ToString();
            tbAddress.Text = addressTableDataGridView.CurrentRow.Cells[2].Value.ToString();
            tbTel.Text = addressTableDataGridView.CurrentRow.Cells[3].Value.ToString();
            tbMail.Text = addressTableDataGridView.CurrentRow.Cells[4].Value.ToString();
            tbMemo.Text = addressTableDataGridView.CurrentRow.Cells[5].Value.ToString();
            //画像表示処理
            try {
                pbImage.Image = ByteArrayToImage((byte[])addressTableDataGridView.CurrentRow.Cells[6].Value);
            }catch(Exception d) {
                pbImage.Image = null;
            }
            //if(!(addressTableDataGridView.CurrentRow.Cells[6] == null)) {
            //    pbImage.Image = ByteArrayToImage((byte[])addressTableDataGridView.CurrentRow.Cells[6].Value);
            //} else {
            //    pbImage.Image = null;
            //}
        }

        //更新ボタンが押された時の処理
        private void btUpdate_Click(object sender, EventArgs e) {
            //各テキストボックスからデータグリッドビューへ設定
            addressTableDataGridView.CurrentRow.Cells[1].Value = tbName.Text;
            addressTableDataGridView.CurrentRow.Cells[2].Value = tbAddress.Text;
            addressTableDataGridView.CurrentRow.Cells[3].Value = tbTel.Text;
            addressTableDataGridView.CurrentRow.Cells[4].Value = tbMail.Text;
            addressTableDataGridView.CurrentRow.Cells[5].Value = tbMemo.Text;
            addressTableDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbImage.Image);


            //データセットの中をデータベースへ反映(保存処理)  
            this.Validate();
            this.addressTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202208DataSet);
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdImage.Filter = "画像ファイル(*.jpg; *.png; *bmp)| *.jpg; *.png; *bmp";
            if (ofdImage.ShowDialog() == DialogResult.OK) {
                pbImage.Image = System.Drawing.Image.FromFile(ofdImage.FileName);
            }
        }

        private void btImageClear_Click(object sender, EventArgs e) {
            pbImage.Image = null;
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        //エラー回避
        private void addressTableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }

        private void btNameSearch_Click(object sender, EventArgs e) {
            this.addressTableTableAdapter.FillByNameSearch(this.infosys202208DataSet.AddressTable, tbNameSearch.Text);
        }

        //追加ボタンが押された時の処理(新規の追加処理)
        private void btAdd_Click(object sender, EventArgs e) {
            DataRow newRow = infosys202208DataSet.AddressTable.NewRow();
            newRow[1] = tbName.Text;
            newRow[2] = tbAddress.Text;
            newRow[3] = tbTel.Text;
            newRow[4] = tbMail.Text;
            newRow[5] = tbMemo.Text;
            newRow[6] = ImageToByteArray(pbImage.Image);
            //データセットへ新しいレコードを追加
            infosys202208DataSet.AddressTable.Rows.Add(newRow);
            //データベース更新
            this.addressTableTableAdapter.Update(this.infosys202208DataSet.AddressTable);
        }

        private void tbClear_Click(object sender, EventArgs e) {
            //int index = addressTableDataGridView.CurrentCell.RowIndex;
            //addressTableDataGridView.Rows.RemoveAt(index);

            tbName.Text = null;
            tbAddress.Text = null;
            tbTel.Text = null;
            tbMail.Text = null;
            tbMemo.Text = null;
        }

        private void 接続ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.addressTableTableAdapter.Fill(this.infosys202208DataSet.AddressTable);
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            new Version().ShowDialog();
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            //アプリケーションの終了
            Application.Exit();
        }
    }
}
