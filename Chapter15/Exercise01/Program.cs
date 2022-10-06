﻿using System;
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
                Console.WriteLine($"発行年:{book.Price},カテゴリ:{book.CategoryId},価格:{book.Price}円,タイトル:{book.Title}");
            }
        }

        private static void Exercise1_3() {
            var groups = Library.Books.GroupBy(b => b.PublishedYear).OrderBy(b => b.Key);
            foreach (var group in groups) {
                Console.WriteLine($"{group.Key}年:{group.Count(c => c.PublishedYear == group.Key)}");
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

        }

        private static void Exercise1_6() {

        }

        private static void Exercise1_7() {

        }

        private static void Exercise1_8() {

        }
    }
}