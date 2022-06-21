using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Form1 : Form {

        //住所データ管理用リスト
        BindingList<Person> listParsen = new BindingList<Person>();

        public Form1() {
            InitializeComponent();
            dgvPersons.DataSource = listParsen;
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if(ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }            
        }

        //追加ボタンが押された時の処理
        private void btAddPerson_Click(object sender, EventArgs e) {

            //氏名が未入力なら登録しない
            if(String.IsNullOrWhiteSpace(tbName.Text)) {
                MessageBox.Show("氏名が入力されていません", "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else {
                Person newPerson = new Person {
                    Name = tbName.Text,
                    MailAddress = tbMailAddress.Text,
                    Address = tbAddress.Text,
                    Company = cbCompany.Text,
                    Picture = pbPicture.Image,
                    listGroup = GetCheckBoxGroup(),
                };
                listParsen.Add(newPerson);

                EnabledCheck();

                //コンボボックスに会社名を登録する(重複なし)
                setCbCompany(cbCompany.Text);
            }
        }

        private void setCbCompany(string company) {
            if (!cbCompany.Items.Contains(company)){

                //まだ登録されていなければ登録処理
                cbCompany.Items.Add(company);
            }
        }

        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> GetCheckBoxGroup() {
            var listGroup = new List<Person.GroupType>();
            if(cbFamily.Checked) {
                listGroup.Add(Person.GroupType.家族);
            }

            if (cbFriend.Checked) {
                listGroup.Add(Person.GroupType.友人);
            }

            if (cbWork.Checked) {
                listGroup.Add(Person.GroupType.仕事);
            }

            if (cbOther.Checked) {
                listGroup.Add(Person.GroupType.その他);
            }
            return listGroup;
        }

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //データグリッドビューをクリックしたときのイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e) {
           
            if (dgvPersons.CurrentCell == null) return;

            //現在選択されているインデックスの取得
            int currentRow = dgvPersons.CurrentCell.RowIndex;

            tbName.Text = listParsen[currentRow].Name;
            tbMailAddress.Text = listParsen[currentRow].MailAddress;
            tbAddress.Text = listParsen[currentRow].Address;
            cbCompany.Text = listParsen[currentRow].Company;
            pbPicture.Image = listParsen[currentRow].Picture;

            all_clear();//グループチェックボックスを一旦初期化

            foreach (var group in listParsen[currentRow].listGroup) {
                switch (group) {
                    case Person.GroupType.友人:
                        cbFriend.Checked = true;
                        break;
                    case Person.GroupType.家族:
                        cbFamily.Checked = true;
                        break;
                    case Person.GroupType.仕事:
                        cbWork.Checked = true;
                        break;
                    case Person.GroupType.その他:
                        cbOther.Checked = true;
                        break;
                    default:
                        break;
                }
            }            
        }

        //グループチェックボックスオールクリア
        private void all_clear() {
            cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
        }

        //更新ボタンが押された時の処理
        private void btUpdate_Click(object sender, EventArgs e) {

            //インデックス取得
            int rowindex = dgvPersons.CurrentCell.RowIndex;

            listParsen[rowindex].Name = tbName.Text;
            listParsen[rowindex].MailAddress = tbMailAddress.Text;
            listParsen[rowindex].Address = tbAddress.Text;
            listParsen[rowindex].Company = cbCompany.Text;
            listParsen[rowindex].Picture = pbPicture.Image;
            listParsen[rowindex].listGroup = GetCheckBoxGroup();

            dgvPersons.Refresh();//データグリッドビュー更新
        }

        //削除ボタンが押された時の処理
        private void btdelete_Click(object sender, EventArgs e) {

            //インデックス取得
            int rowindex = dgvPersons.CurrentCell.RowIndex;
            listParsen.RemoveAt(rowindex);
            EnabledCheck();//マスク処理呼び出し
        }

        //更新・削除ボタンのマスク処理を行う(マスク判定を含む)
        private void EnabledCheck() {
            btDelete.Enabled = btDelete.Enabled = listParsen.Count() > 0 ? true : false;
        }

        private void Form1_Load(object sender, EventArgs e) {
            EnabledCheck();//マスク処理呼び出し
        }

        //保存ボタンのイベントハンドラ
        private void btSave_Click(object sender, EventArgs e) {
            if(sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)){
                        bf.Serialize(fs, listParsen);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listParsen = (BindingList<Person>)bf.Deserialize(fs);
                        dgvPersons.DataSource = null;
                        dgvPersons.DataSource = listParsen;
                        cbCompany.Items.Clear();
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                //コンボボックスへ登録
                foreach (var item in listParsen) {
                    setCbCompany(item.Company);//存在する会社を登録
                }
            }
            EnabledCheck();//マスク処理呼び出し
        }
    }
}
