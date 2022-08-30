using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TextFileProcessor;

namespace Exercise1 {
    class NumberReplacedProcessor : TextProcessor{
        private static Dictionary<char, char> dictionary = new Dictionary<char, char>() {
            {'０','0' },{'１','1' },{'２','2' },{'３','3' },{'４','4' },
            {'５','5' },{'６','6' },{'７','7' },{'８','8' },{'９','9' }
        };

        protected override void Execute(string line) {
            String s = Regex.Replace(line, "[0-9]", p => ((char)(p.Value[0] - '０' + '0')).ToString());
            Console.WriteLine(s);
        }
    }
}
