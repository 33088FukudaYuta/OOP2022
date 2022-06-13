﻿using System;
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

        private void btAddPerson_Click(object sender, EventArgs e) {

            Person newPerson = new Person {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
            };

            listParsen.Add(newPerson);
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

            //現在選択されているインデックスの取得
            int currentRow = dgvPersons.CurrentCell.RowIndex;

            tbName.Text = listParsen[currentRow].Name;
            tbMailAddress.Text = listParsen[currentRow].MailAddress;
            tbAddress.Text = listParsen[currentRow].Address;
            tbCompany.Text = listParsen[currentRow].Company;
            pbPicture.Image = listParsen[currentRow].Picture;

            all_clear();

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
        private void all_clear() {
            cbFamily.Checked = false;
            cbFriend.Checked = false;
            cbWork.Checked = false;
            cbOther.Checked = false;
        }
    }
}