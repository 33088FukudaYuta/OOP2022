using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            /*var ym = new YearMonth(2002, 12);

            var check = ym.Is21Century;
            var test = ym.AddOneMonth();

            Console.WriteLine(test);*/

            //4.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1896,8),
                new YearMonth(1900,7),
                new YearMonth(1904,6),
                new YearMonth(2015,5),
                new YearMonth(2020,11),//P103
            };

            //4.2.2
            Exercise2_2(ymCollection);
            Console.WriteLine("------------------");
            
            //4.2.4
            Exercise2_4(ymCollection);
            Console.WriteLine("------------------");

            //4.2.5
            Exercise2_5(ymCollection);
            Console.WriteLine("------------------");

            Exercise2_6(ymCollection);
        }

        private static void Exercise2_6(YearMonth[] ymCollection) {
            //①月で昇順に出力 ②偶数年のみ昇順に出力 ③うるう年のみを出力　④すべての年から12月に一番近い月を出力
            foreach (var ym in ymCollection.Where(ym => DateTime.IsLeapYear(ym.Year))) {
                    Console.WriteLine(ym);
            }

            var data = ymCollection.Max(ym => ym.Month);
            Console.WriteLine(data);
        }

        //4.2.3
        //最初に見つかった21世紀オブジェクトを返す
        //見つからない場合はnullを返す
        static YearMonth FindFirst21C(YearMonth[] yms) {
           foreach (var year in yms) {
                if (year.Is21Century) {
                    return year;
                }
            }
            return null;
        }

        private static void Exercise2_2(YearMonth[] ymCollection) {
            foreach (var item in ymCollection) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise2_4(YearMonth[] ymCollection) {
            var yearmanth = FindFirst21C(ymCollection);//戻り値を受け取る

            if(yearmanth != null) {
                Console.WriteLine(yearmanth);
            } else {
                Console.WriteLine("21世紀のデータがありません");
            }

        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            var array = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach (var nextmonth in array) {
                Console.WriteLine(nextmonth);
            }
            
        }
    }
}
