using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            int num;
            Console.WriteLine("売上高の表示選択");
            Console.WriteLine("1店舗別");
            Console.WriteLine("2商品カテゴリー別");
            Console.Write(">");
            num = int.Parse(Console.ReadLine());
            var sales = new SalesCounter("sales.csv");
            var amountPerStore = sales.GetPerStoreSales();
            foreach (var obj in amountPerStore) {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }
            if (num == 1) {
                sales.GetPerStoreSales();
            }
            if(num == 2) {
                sales.GetPerCategorySales();
            }
        }
    }
}
