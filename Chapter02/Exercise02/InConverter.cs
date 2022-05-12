using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class InConverter {
        private const double ratio = 0.0254;//定数rarioを定義

        //メートルからフィートを求める(静的メソッド)
        public static double FromMeter(double meter) {
            return meter / ratio;
        }

        //インチからメートルを求める(静的メソッド)
        public static double ToMeter(int inch) {
            return inch * ratio;
        }
    }
}
