using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {

        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReport;
        }

        private void btEnd_Click(object sender, EventArgs e) {

            //アプリケーションの終了
            Application.Exit();
        }

        private void btAdd_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(dtpRegistDate.Text)) {
                MessageBox.Show("氏名が入力されていません", "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else {
                CarReport newcarReport = new CarReport {
                    Date = dtpRegistDate.Value,
                    Auther = cbRecorder.Text,
                    Maker = CarReport.MakerGroup.トヨタ,
                    CarName = cbCarName.Text,
                    Report = tbReport.Text,
                    Picture = pbPicture.Image,
                };
                listCarReport.Add(newcarReport);

                setCbRecorder(cbRecorder.Text);
                setCbCarName(cbCarName.Text);
            }
        }

        //データグリッドビューをクリックしたときのイベントハンドラ
        private void dgvCarReport_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvCarReport.CurrentCell == null) return;

            //現在選択されているインデックスの取得
            int index = dgvCarReport.CurrentCell.RowIndex;

            dtpRegistDate.Value = listCarReport[index].Date;
            cbRecorder.Text = listCarReport[index].Report;
        }
        private void setMakerType(int index) {
            all_clear();
        }
        private void setCbCarName(string carname) {
            if (!cbCarName.Items.Contains(carname)) {

                //まだ登録されていなければ登録
                cbCarName.Items.Add(carname);
            }
        }

        private void setCbRecorder(string recorder) {
            if (!cbRecorder.Items.Contains(recorder)) {

                //まだ登録されていなければ登録
                cbRecorder.Items.Add(recorder);
            }
        }
        private void all_clear() {
            rbHonda.Checked = rbNissan.Checked = rbOutsideCar.Checked = rbSubaru.Checked = rbToyota.Checked = false;
        }

        
    }
}
