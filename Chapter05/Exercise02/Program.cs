using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            //5.2
            int num;
            Console.WriteLine("数字文字列の入力");
            var inputstring3 = Console.ReadLine();

            if (int.TryParse(inputstring3, out num)) {
                Console.WriteLine("{0:00,000}", num);
            } else {
                Console.WriteLine("変換に失敗しました");
            }
        }
    }
}
