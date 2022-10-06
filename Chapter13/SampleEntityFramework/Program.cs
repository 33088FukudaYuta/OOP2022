using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework {
    class Program {
        static void Main(string[] args) {
            //InsertBooks();
            //AddAuthors();
            //AddBooks();
            //Exercise1_2();
            //Exercise1_3();
            //Exercise1_4();

            //Exercise1_5();
            using (var db = new BooksDbContext()) {
                var authors = db.Authors
                         .OrderByDescending(b => b.Birthday)
                         .ToList();

                foreach (var author in authors) {
                    Console.WriteLine("{0} {1:yyyy/MM/dd}", author.Name, author.Birthday);
                    foreach (var book in author.Books) {
                        Console.WriteLine("{0} {1}",
                                book.Title, book.PublishedYear,
                                book.Author.Name, book.Author.Birthday);
                    }
                    Console.WriteLine();//改行
                }
                Console.ReadLine();//F5だけでも画面を閉じないようにする
            }
        }

        //List13-5
        static void InsertBooks() {
            using (var db = new BooksDbContext()) {
                var book1 = new Book {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };

                db.Books.Add(book1);

                var book2 = new Book {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add(book2);

                var book3 = new Book {
                    Title = "真珠夫人",
                    PublishedYear = 2002,
                    Author = new Author {
                        Birthday = new DateTime(1888, 12, 16),
                        Gender = "M",
                        Name = "菊池寛",
                    }
                };
                db.Books.Add(book3);

                var book4 = new Book {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1899, 6, 14),
                        Gender = "M",
                        Name = "川端康成",
                    }
                };
                db.Books.Add(book4);

                db.SaveChanges(); //データベースの更新
            }
        }

        // List 13-9
        private static void AddAuthors() {
            using (var db = new BooksDbContext()) {
                var author1 = new Author {
                    Birthday = new DateTime(1888, 12, 16),
                    Gender = "M",
                    Name = "菊池寛"
                };
                db.Authors.Add(author1);

                var author2 = new Author {
                    Birthday = new DateTime(1899, 6, 14),
                    Gender = "M",
                    Name = "川端康成"
                };
                db.Authors.Add(author2);

                db.SaveChanges();
            }
        }

        // List 13-10
        private static void AddBooks() {
            using (var db = new BooksDbContext()) {
                var author1 = db.Authors.Single(a => a.Name == "菊池寛");
                var book1 = new Book {
                    Title = "真珠夫人",
                    PublishedYear = 2002,
                    Author = author1,
                };
                db.Books.Add(book1);

                var author2 = db.Authors.Single(a => a.Name == "川端康成");
                var book2 = new Book {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = author2,
                };
                db.Books.Add(book2);

                var author3 = db.Authors.Single(a => a.Name == "夏目漱石");
                var book3 = new Book {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = author3,
                };
                db.Books.Add(book3);

                var author4 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book4 = new Book {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = author4,
                };
                db.Books.Add(book4);

                db.SaveChanges();
            }
        }

        //Exercise1_2()
        private static void Exercise1_2() {
            var books = GetAllBooks_2();
            foreach (var book in books) {
                Console.WriteLine("{0} {1} {2} {3:yyyy/MM/dd})",
                            book.Title, book.PublishedYear,
                            book.Author.Name, book.Author.Birthday);
            }
            Console.ReadLine();//F5だけでも画面を閉じないようにする
        }

        //Exercise1_3()
        private static void Exercise1_3() {
            var title = GetBooks_3();
            foreach (var titles in title) {
                Console.WriteLine("{0} {1} {2} {3:yyyy/MM/dd})",
                            titles.Title, titles.PublishedYear,
                            titles.Author.Name, titles.Author.Birthday);
            }
            Console.ReadLine();//F5だけでも画面を閉じないようにする
        }

        //Exercise1_4()
        private static void Exercise1_4() {
            var year = GetBooks_4();
            foreach (var items in year) {
                Console.WriteLine("{0} {1} {2} {3:yyyy/MM/dd})",
                            items.Title, items.PublishedYear,
                            items.Author.Name, items.Author.Birthday);
            }
            Console.ReadLine();//F5だけでも画面を閉じないようにする
        }

        static IEnumerable<Book> GetAllBooks_2() {
            using (var db = new BooksDbContext()) {
                return db.Books.Include(nameof(Author))
                         .ToList();
            }
        }

        static IEnumerable<Book> GetBooks_3() {
            using (var db = new BooksDbContext()) {
                return db.Books
                         .Include(nameof(Author))
                         .Where(book => book.Title.Length == db.Books.Max(b => b.Title.Length))
                         .ToList();
            }
        }

        static IEnumerable<Book> GetBooks_4() {
            using (var db = new BooksDbContext()) {
                return db.Books
                         .Include(nameof(Author))
                         .OrderBy(b => b.PublishedYear)
                         .Take(3)
                         .ToList();
            }
        }
    }
}


