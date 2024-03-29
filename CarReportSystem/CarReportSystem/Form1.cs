﻿using System;
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

        //カーレポート管理用リスト
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        int mode = 0;

        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReport;
        }

        //終了ボタンが押された時の処理
        private void btEnd_Click(object sender, EventArgs e) {

            //アプリケーションの終了
            Application.Exit();
        }

        //追加ボタンをクリックした時の処理
        private void btAdd_Click(object sender, EventArgs e) {

            if (String.IsNullOrWhiteSpace(cbRecorder.Text)) {
                //氏名が未入力なら登録しない
                MessageBox.Show("氏名が入力されていません");
                return;
            }
            CarReport newcarReport = new CarReport {
                Date = dtpRegistDate.Value,
                Auther = cbRecorder.Text,
                Maker = GetRadioButtonMakerType(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };
            listCarReport.Add(newcarReport);

            EnableCheck();
            SetCbRecorder(cbRecorder.Text);
            SetCbCarName(cbCarName.Text);
        }

        //データグリッドビューをクリックしたときのイベントハンドラ
        private void dgvCarReport_CellContentClick(object sender, EventArgs e) {

            //現在選択されているインデックスの取得
            int index = dgvCarReport.CurrentCell.RowIndex;

            dtpRegistDate.Value = listCarReport[index].Date;
            cbRecorder.Text = listCarReport[index].Auther;
            SetMakerType(index);
            cbCarName.Text = listCarReport[index].CarName;
            tbReport.Text = listCarReport[index].Report;
            pbPicture.Image = listCarReport[index].Picture;
        }

        private void SetMakerType(int index) {

            All_clear();

            switch (listCarReport[index].Maker) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外国車:
                    rbOutsideCar.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbforeignCars.Checked = true;
                    break;
                default:
                    break;
            }

        }

        //コンボボックスに社名を登録する(重複なし)
        private void SetCbCarName(string carname) {
            if (!cbCarName.Items.Contains(carname)) {

                //まだ登録されていなければ登録
                cbCarName.Items.Add(carname);
            }
        }

        //コンボボックスに記録者を登録する(重複なし)
        private void SetCbRecorder(string recorder) {
            if (!cbRecorder.Items.Contains(recorder)) {

                //まだ登録されていなければ登録
                cbRecorder.Items.Add(recorder);
            }
        }

        private void All_clear() {
            rbHonda.Checked = rbNissan.Checked = rbOutsideCar.Checked = rbSubaru.Checked = rbToyota.Checked = false;
        }

        private CarReport.MakerGroup GetRadioButtonMakerType() {

            CarReport.MakerGroup selectedMakerType = CarReport.MakerGroup.その他;

            if (rbHonda.Checked) {
                selectedMakerType = CarReport.MakerGroup.ホンダ;
            }
            if (rbNissan.Checked) {
                selectedMakerType = CarReport.MakerGroup.日産;
            }
            if (rbSubaru.Checked) {
                selectedMakerType = CarReport.MakerGroup.スバル;
            }
            if (rbToyota.Checked) {
                selectedMakerType = CarReport.MakerGroup.トヨタ;
            }
            if (rbOutsideCar.Checked) {
                selectedMakerType = CarReport.MakerGroup.外国車;
            }
            if (rbforeignCars.Checked) {
                selectedMakerType = CarReport.MakerGroup.その他;
            }
            return selectedMakerType;
        }

        //削除ボタンが押された時の処理
        private void btDelete_Click(object sender, EventArgs e) {

            //データグリッドビューがnullの時
            if (dgvCarReport.CurrentCell == null) return;

            //インデックスの取得
            int index = dgvCarReport.CurrentCell.RowIndex;

            listCarReport.RemoveAt(index);
            EnableCheck();
        }

        //修正・削除ボタンのマスク処理を行う(マスク判定を含む)
        private void EnableCheck() {
            btDelete.Enabled = btCorrect.Enabled = listCarReport.Count() > 0 ? true : false;
        }

        //修正ボタンが押された時の処理
        private void btCorrect_Click(object sender, EventArgs e) {

            //インデックスの取得
            int index = dgvCarReport.CurrentCell.RowIndex;

            listCarReport[index].Date = dtpRegistDate.Value;
            listCarReport[index].Auther = cbRecorder.Text;
            listCarReport[index].Maker = GetRadioButtonMakerType();
            listCarReport[index].CarName = cbCarName.Text;
            listCarReport[index].Report = tbReport.Text;
            listCarReport[index].Picture = pbPicture.Image;

            //データグリッドビューの更新
            dgvCarReport.Refresh();
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }

        private void dgvCarReport_Click(object sender, EventArgs e) {

            //データグリッドビューがnullの時
            if (dgvCarReport.CurrentCell == null) return;

            //現在選択されているインデックスの取得
            int index = dgvCarReport.CurrentCell.RowIndex;

            dtpRegistDate.Value = listCarReport[index].Date;
            cbRecorder.Text = listCarReport[index].Auther;
            SetMakerType(index);
            cbCarName.Text = listCarReport[index].CarName;
            tbReport.Text = listCarReport[index].Report;
            pbPicture.Image = listCarReport[index].Picture;
        }

        //保存ボタンを押したときの処理
        private void btSave_Click(object sender, EventArgs e) {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReport);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //開くボタンを押したときの処理
        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReport.DataSource = null;
                        dgvCarReport.DataSource = listCarReport;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                cbCarName.Items.Clear();//コンボボックスのアイテム消去
                cbRecorder.Items.Clear();//コンボボックスのアイテム消去
                //コンボボックスへ登録
                foreach (var item in listCarReport) {
                    SetCbCarName(item.CarName);//存在する車名を登録
                    SetCbRecorder(item.Auther);//存在する記録者を登録
                }
            }
            EnableCheck();
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
    }
}
    
