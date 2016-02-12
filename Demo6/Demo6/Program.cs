using System;

namespace Demo6
{
    class Program
    {
        static void Main(string[] args)
        {
            int valinta;
            bool jatko = true;
            string[] biisilista;
            
            while (jatko == true)
            {
                Console.WriteLine("Valitse tehtävä:\n1. Tehtävä2, CD-kokoelma\n2. Tehtävä3, Korttipakka\n3. Lopeta\n");
                valinta = Convert.ToInt32(Console.ReadLine());

                switch (valinta)
                {
                    case 1:
                        biisilista = new string[] { "Mouth for War", "A New Level", "Walk", "Fucking Hostile", "This Love", "Rise", "No Good", "Live in a Hole", "Regular People", "By Demons Be Driven", "Hollow" };
                        Kokoelma pantera = new Kokoelma("Vulgar Display of Power", "Pantera", biisilista);
                        biisilista = new string[] { "Ruin", "As the Palaces Burn", "Purified", "11th Hour", "For Your Malice", "Boot Scraper", "A Devil In Gods Country", "In Defence of Our Good Name", "Blood Junkie", "Vigil" };
                        Kokoelma LoG = new Kokoelma("As the Palaces Burn", "Lamb of God", biisilista);
                        pantera.PrintInfo();
                        LoG.PrintInfo();
                        break;

                    case 2:
                        Cards pakka = new Cards();
                        pakka.Start();
                        break;

                    case 3:
                        jatko = false;
                        break;

                    default:
                        Console.WriteLine("Tarkasta syöte.\n");
                        break;
                }

            }
        }
    }
}
