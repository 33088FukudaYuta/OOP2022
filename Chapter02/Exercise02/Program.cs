using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                PrintInToMeterList(1, 10);
            }
            else {
                PrintMeterToInList(1, 10);
            }
        }

        //インチからメートルへの対応表を出力
        private static void PrintInToMeterList(int start, int stop) {
            for (int inti = start; inti <= stop; inti++) {
                double meter = InConverter.ToMeter(inti);
                Console.WriteLine("{0} in = {1:0.0000} m", inti, meter);
            }
        }

        //メートルからインチへの対応表を出力
        private static void PrintMeterToInList(int start, int stop) {
            for (int meter = 1; meter <= 10; meter++) {
                double inti = InConverter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} in", meter, inti);
            }
        }
    }
 }

