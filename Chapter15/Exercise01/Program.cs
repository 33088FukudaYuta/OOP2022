using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books.Max(b => b.Price);
            var books = Library.Books.Where(b => b.Price == max);
            foreach (var book in books) {
                Console.WriteLine(book);
            }
        }

        private static void Exercise1_3() {
            var groups = Library.Books.GroupBy(b => b.PublishedYear);
            foreach (var group in groups.OrderBy(b => b.Key)) {
                Console.WriteLine($"{group.Key}年:{group.Count()}冊");
            }
        }

        private static void Exercise1_4() {
            var selected = Library.Books
                .OrderByDescending(b => b.PublishedYear)
                .ThenByDescending(b => b.Price)
                .Join(Library.Categories,
                      book => book.CategoryId,
                      category => category.Id,
                      (book, category) => new {
                          PublishedYear = book.PublishedYear,
                          Category = category.Name,
                          Price = book.Price,
                          Title = book.Title
                      }
                 );
            foreach (var book in selected) {
                Console.WriteLine($"{book.PublishedYear} {book.Price}円 {book.Title} ({book.Category})");
            }
        }

        private static void Exercise1_5() {
            var categorys = Library.Books
                .Where(b => b.PublishedYear == 2016)
                .Join(Library.Categories,
                      book => book.CategoryId,
                      category => category.Id,
                      (book, category) => category.Name)
                      .Distinct();
            foreach (var book in categorys) {
                Console.WriteLine(book);
            }
        }

        private static void Exercise1_6() {
            var groups = Library.Books
                    .Join(Library.Categories,
                      book => book.CategoryId,
                      category => category.Id,
                      (book, category) => new {
                          PublishedYear = book.PublishedYear,
                          Price = book.Price,
                          Title = book.Title,
                          CategoryName = category.Name
                      })
                    .GroupBy(x => x.CategoryName)
                    .OrderBy(x => x.Key);

            foreach (var group in groups) {
                Console.WriteLine("#{0}", group.Key);
                foreach (var item in group) {
                    Console.WriteLine(item.Title);
                }
            }
        }

        private static void Exercise1_7() {
            var categiryId = Library.Categories.Single(c => c.Name == "Development").Id;
            var groups = Library.Books
                            .Where(b => b.CategoryId == categiryId)
                            .GroupBy(b => b.PublishedYear)
                            .OrderBy(b => b.Key);

            foreach (var group in groups) {
                Console.WriteLine($"#{group.Key}");
                foreach (var book in group) {
                    Console.WriteLine(book.Title);
                }
            }
        }

        private static void Exercise1_8() {

        }
    }
}
