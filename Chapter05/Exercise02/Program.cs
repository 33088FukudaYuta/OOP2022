using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            //5.2
            Console.WriteLine("数字文字列の入力");
            var line = Console.ReadLine();
            int num;

            if (int.TryParse(line, out num)) {
                Console.WriteLine("{0:#,#}", num);//整数への変換成功
            } else {
                Console.WriteLine("変換に失敗しました");//変換失敗
            }
        }
    }
}
