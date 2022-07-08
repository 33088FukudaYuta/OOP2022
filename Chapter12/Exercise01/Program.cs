using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {
    [XmlRoot("employee")]
    public class Employee {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "hiredate")]
        public DateTime HireDate { get; set; }
    }
    class Program {
        static void Main(string[] args) {

            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            //Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string outfie) {
            var emp = new Employee {
                Id = 123,
                Name = "出井　秀行",
                HireDate = new DateTime(2000, 5, 10)
            };
            using (var writer = XmlWriter.Create("employee.xml")) {
                var serializer = new XmlSerializer(emp.GetType());
                serializer.Serialize(writer, emp);
            }
            //シリアル化
            var settings = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "  ",
            };
            using (var writer = XmlWriter.Create("employee.xml", settings)) {
                var serializer = new DataContractSerializer(emp.GetType()); //P185
                serializer.WriteObject(writer, emp);
            }

            //逆シリアル化
            using (var reader = XmlReader.Create("employee.xml")) {
                var serializer = new DataContractSerializer(typeof(Employee));
                var novels = serializer.ReadObject(reader) as Employee;
                Console.WriteLine(novels);
            }
        }

        private static void Exercise1_2(string v) {
 
        }

        private static void Exercise1_3(string v) {

        }

        private static void Exercise1_4(string v) {

        }
    }
}
