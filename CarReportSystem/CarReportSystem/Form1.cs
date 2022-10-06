using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //設定情報保存用オブジェクト(シングルトン)
        //Singleton：インスタンスが1個しかできないことを保証するパターン
        Settings setting = Settings.getInstance();

        int mode = 0;

        public Form1() {
            InitializeComponent();
        }

        private string GetRadioButtonMakerType() {

            if (rbHonda.Checked) {
                return "ホンダ";
            }
            if (rbNissan.Checked) {
                return "日産";
            }
            if (rbSubaru.Checked) {
                return "スバル";
            }
            if (rbToyota.Checked) {
                return "トヨタ";
            }
            if (rbOutsideCar.Checked) {
                return "外国車";
            }
            return "その他";
        }

        //更新・削除ボタンのマスク処理を行う(マスク判定を含む)
        private void EnableCheck() {
            btDelete.Enabled = btUpdate.Enabled = infosys202208DataSet.CarReportDB.Rows.Count > 0 ? true : false;
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            ofdFileOpenDialog.Filter = "画像ファイル(*.jpg; *.png; *bmp)| *.jpg; *.png; *bmp";
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {

            //色設定ダイアログ表示
            if (cdColorSelect.ShowDialog() == DialogResult.OK) {
                BackColor = cdColorSelect.Color;
                setting.MainFormColor = cdColorSelect.Color.ToArgb();
            }
        }

        //ボタンを押すごとにPictureBoxのサイズ変更
        private void btPictureExchange_Click(object sender, EventArgs e) {
            pbPicture.SizeMode = (PictureBoxSizeMode)mode;
            mode = mode < 4 ? ++mode : 0;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルをシリアル化
            using (var writer = XmlWriter.Create("setting.xml")) {
                var serializer = new XmlSerializer(setting.GetType());
                serializer.Serialize(writer, setting);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            //設定ファイルを逆シリアル化して背景の色を設定
            try {
                using (var reader = XmlReader.Create("setting.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    setting = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(setting.MainFormColor);//ARGBからColorオブジェクトへ変換
                }
            }
            catch (Exception) {
            }
            EnableCheck(); //マスク処理呼び出し
        }

        private void btPictureDelete_Click_1(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void carReportDBBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202208DataSet);
        }

        private void 接続ToolStripMenuItem_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202208DataSet.CarReportDB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202208DataSet.CarReportDB);
            EnableCheck();
        }

        //終了ボタンが押された時の処理
        private void btEnd_Click(object sender, EventArgs e) {

            //アプリケーションの終了
            Application.Exit();
        }

        //追加ボタンをクリックした時の処理
        private void btAdd_Click(object sender, EventArgs e) {

            DataRow newRow = infosys202208DataSet.CarReportDB.NewRow();
            newRow[1] = dtpRegistDate.Value;
            newRow[2] = cbRecorder.Text;
            newRow[3] = GetRadioButtonMakerType();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = ImageToByteArray(pbPicture.Image);
            EnableCheck();
            //データセットへ新しいレコードを追加
            infosys202208DataSet.CarReportDB.Rows.Add(newRow);
            //データベース更新
            this.carReportDBTableAdapter.Update(this.infosys202208DataSet.CarReportDB);
        }

        //更新ボタンが押された時の処理
        private void btUpdate_Click(object sender, EventArgs e) {
            carReportDBDataGridView.CurrentRow.Cells[1].Value = dtpRegistDate.Value;
            carReportDBDataGridView.CurrentRow.Cells[2].Value = cbRecorder.Text;
            carReportDBDataGridView.CurrentRow.Cells[3].Value = GetRadioButtonMakerType();
            carReportDBDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
            carReportDBDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;
            carReportDBDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);

            //データセットの中をデータベースへ反映(保存処理)  
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202208DataSet);
        }

        //削除ボタンが押された時の処理
        private void btDelete_Click(object sender, EventArgs e) {

            //データグリッドビューがnullの時
            if (carReportDBDataGridView.CurrentRow == null) return;

            //インデックスの取得
            int index = carReportDBDataGridView.CurrentCell.RowIndex;

            carReportDBDataGridView.Rows.RemoveAt(index);
            EnableCheck();

            //データセットの中をデータベースへ反映(保存処理)  
            this.Validate();
            this.carReportDBDataGridView.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202208DataSet);
        }

        private void SetMakerTypeDB() {
            switch (carReportDBDataGridView.CurrentRow.Cells[3].Value.ToString()) {
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "外国車":
                    rbOutsideCar.Checked = true;
                    break;
                case "その他":
                    rbforeignCars.Checked = true;
                    break;
            }
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
        private void carReportDBDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }

        private void carReportDBDataGridView_Click(object sender, EventArgs e) {
            if (carReportDBDataGridView.CurrentRow == null)
                return;

            //データグリッドビューの選択レコードを各テキストボックスへ設定
            dtpRegistDate.Text = carReportDBDataGridView.CurrentRow.Cells[1].Value.ToString();
            cbRecorder.Text = carReportDBDataGridView.CurrentRow.Cells[2].Value.ToString();
            SetMakerTypeDB();
            cbCarName.Text = carReportDBDataGridView.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = carReportDBDataGridView.CurrentRow.Cells[5].Value.ToString();
            try {
                pbPicture.Image = ByteArrayToImage((byte[])carReportDBDataGridView.CurrentRow.Cells[6].Value);
            }
            catch (Exception d) {
                pbPicture.Image = null;
            }
        }

        //クリアボタンを押したときの処理
        private void btClear_Click(object sender, EventArgs e) {
            cbRecorder.Text = null;
            rbToyota.Checked = rbHonda.Checked = rbNissan.Checked = rbOutsideCar.Checked = rbSubaru.Checked = rbforeignCars.Checked = false;
            cbCarName.Text = null;
            tbReport.Text = null;
            tbNameSearch.Text = null;
        }

        private void btName_Click(object sender, EventArgs e) {
            this.carReportDBTableAdapter.FillByName(this.infosys202208DataSet.CarReportDB, tbNameSearch.Text);
        }
    }
}


