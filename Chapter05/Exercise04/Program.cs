using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";


            var msg = line.Split(';');

            foreach (var item in msg) {
                var str = item.Split('=');
                var str1 = ToJapanese(str[0]);
                Console.WriteLine(str1 + ":" + str[1]);
            }
            
        }

        static string ToJapanese(string key) {
            switch (key) {
                case "Novelist":
                    return "作家　";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生年";
            }
            throw new ArgumentException("引数keyは、正しい値ではありません");
        }
    }
}
