﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class Program {
        //コマンドライン引数
        static void Main(string[] args) { 
            

            if (args.Length >= 1 && args[0] == "-tom") {
                PrintFeetToMeterList(1,10);
            }
            else {
                PrintMeterToFeetList(1,10);
            }
        }

        //フィートからメートルへの対応表を出力
        private static void PrintFeetToMeterList(int start, int stop) {
            for (int feet = start; feet <= stop; feet++) {
                double meter = FeetConverter.ToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }

        //メートルからフィートへの対応表を出力
        private static void PrintMeterToFeetList(int start,int stop) {
            for (int meter = 1; meter <= 10; meter++) { 
                double feet = FeetConverter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
            }
        }
    }
}
