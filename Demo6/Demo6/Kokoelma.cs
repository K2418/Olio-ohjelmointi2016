using System;

namespace Demo6
{
    class Kokoelma
    {
        private string name { get; set; }
        private string artist { get; set; }
        private string[] songs { get; set; }
        private int loop;

        public Kokoelma(string nimi, string artisti, string[] biisit)
        {
            name = nimi;
            artist = artisti;
            songs = biisit;
        }

        public void PrintInfo()
        {
            loop = 1;
            Console.WriteLine("Artist: " + artist + "\nAlbum: " + name + "\n\nSongs:");
            foreach(string song in songs)
            {
                Console.WriteLine(loop + ". " + song);
                loop++;
            }
            Console.WriteLine();

            

        }
    }
}
