﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook {
    public class Person {
        //プロパティ
        [System.ComponentModel.DisplayName("名前")]
        public String Name { get; set; }
        [System.ComponentModel.DisplayName("メールアドレス")]
        public String MailAddress { get; set; }
        [System.ComponentModel.DisplayName("住所")]
        public String Address { get; set; }
        [System.ComponentModel.DisplayName("会社")]
        public String Company { get; set; }
        public List<GroupType> listGroup { get; set; }
        [System.ComponentModel.DisplayName("画像")]
        public Image Picture { get; set; }

        public enum GroupType {
        友人,家族,仕事,その他,
        }
    }
}