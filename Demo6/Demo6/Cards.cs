using System;

namespace Demo6
{
    class Cards : Deck
    {

        private int valinta;
        private bool cont = true;
        Random rand = new Random();

        public void Start()
        {
            Console.WriteLine("H = hearts, D = diamonds, S = spades & C = clubs\n Paina väliköyntiä jatkaaksesi");
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)) { }
            CreateDeck();
            Console.WriteLine("Ensin pakka järjestettynä:\n");
            PrintDeck();
            Console.WriteLine("Sitten sekoitetaan, paina väliköyntiä jatkaaksesi");
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)) { }
            ShuffleDeck();
            PrintDeck();
            Console.WriteLine("Sekoitusalgoritmina Fischer-Yates shuffle\nTein sekoitusalgoritmeistä esitelmän Tietorakenteet ja algoritmit-kurssilla viime syksynä,\nKoodini oli C++ tehty, kutakuin samantapainen toteutus\n");
            Console.WriteLine("Paina väliköyntiä jatkaaksesi.\n");
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)) { }
        }


        private void ShuffleDeck()                                          //Sekoitusalgoritminä fischer-Yates shuffle, joka on täysin random, ei ennustettava
        {                                                                   //Algoritmi poimii päällimmäisen kortin ja sijoittaa satunnaiseen väliin, kunnes koko pakka käyty läpi
            int i = 51;
            int j;
            string temp;
            ;

            while (i > 0)
            {
                j = rand.Next(i) % (i + 1);
                temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
                i--;
            }
        }

        private void PrintDeck()                                            //Tulostetaan korttipakka, hieman helpompilukuinen kun ei tee vain yhtä pystysuoraa riviä tulosteeksi
        {
            int j = 1;

            for (int i = 0; i < 52; i = i + 2)
            {
                if (i == 26)
                {
                    Console.WriteLine(" \n");
                }

                Console.WriteLine(deck[i] + " -------- " + deck[j]);
                j = j + 2;
            }
            Console.WriteLine();
        }

    }

    class Deck                                                              //Deck luokan olio, kuvastaa korttipakkaa
    {                                                                       //Kortin arvo on vain stringinä, koska tätä ohjelmaa ei sen suurempiin asioihin käytetä nyt
        internal int cardNo;
        internal char suit;
        internal string[] deck = new string[52];

        internal void CreateDeck()
        {
            cardNo = 0;
            for (int loop = 0; loop < 4; loop++)                            //Loop, joka määrittää kortille maan ja pyöräyttää kaikki 14 korttia kyseistä maata
            {
                if (loop == 0)
                {
                    suit = 'H';
                }
                else if (loop == 1)
                {
                    suit = 'S';
                }
                else if (loop == 2)
                {
                    suit = 'D';
                }
                else {
                    suit = 'C';
                }

                for (int loop2 = 1; loop2 < 14; loop2++)
                {
                    deck[cardNo] = suit + " " + loop2;

                    cardNo++;
                }
            }
        }
    }
}
