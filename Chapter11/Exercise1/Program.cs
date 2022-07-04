using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);
        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var novelists = xdoc.Root.Elements().Select(x => new {
                Name = (string)x.Element("name"),
                Teammembers = (string)x.Element("teammembers")
            });
            foreach (var data in novelists) {
                Console.WriteLine("{0} {1}", data.Name, data.Teammembers);
            }
        }

        private static void Exercise1_2(string file) {
            //最初にプレーされた年の若い順と合わせて競技名を表示
            var xdoc = XDocument.Load(file);
            var novelists = xdoc.Root.Elements().Select(x => new {
                Name = (string)x.Element("name").Attribute("name"),
                Firstplayed = (string)x.Element("firstplayed")
            });
            foreach (var data in novelists) {
                Console.WriteLine("{0} {1}", data.Name, data.Firstplayed);
            }
        }
        private static void Exercise1_3(string file) {
        }

        private static void Exercise1_4(string file, string newfile) {
        }
    }
}
