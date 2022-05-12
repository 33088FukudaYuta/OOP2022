﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            int select = 0;
            var sales = new SalesCounter("sales.csv");

            Console.WriteLine("売上高の表示選択");
            Console.WriteLine("1店舗別");
            Console.WriteLine("2商品カテゴリー別");
            Console.Write(">");

            select = int.Parse(Console.ReadLine());
            IDictionary<string, int> amountPerStore = null;
            switch (select) {
                case 1:
                    amountPerStore = sales.GetPerStoreSales();
                    break;

                case 2:
                    amountPerStore = sales.GetPerCategorySales();
                    break;

            }
           
            foreach(var obj in amountPerStore) {
                Console.WriteLine("{0},{1}", obj.Key, obj.Value);
            }
        }
    }
}
