using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            /*2.1.3
            List<Song> songs = new List<Song>();

            Song song1 = new Song("タイトル1", "アーティスト名", 485);
            Song song2 = new Song("タイトル2", "アーティスト名", 698);
            Song song3 = new Song("タイトル3", "アーティスト名", 698);

            songs.Add(song1);
            songs.Add(song2);
            songs.Add(song3);*/

            var songs = new Song[] {
                new Song("タイトル1", "アーティスト名", 485),
                new Song("タイトル2", "アーティスト名", 589),
                new Song("タイトル3", "アーティスト名", 478),
                new Song("タイトル4", "アーティスト名", 369),
                new Song("タイトル5", "アーティスト名", 857),
            };
            PrintSongs(songs);
        }

        //2.1.4
        private static void PrintSongs(IEnumerable<Song> songs) {
            foreach (var song in songs) {
                Console.WriteLine("{0},{1},{2:mm\\:ss}", 
                    song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));
            }
        }
        private static void PrintSongs(List<Song> songs) {

        }       
    }
}
