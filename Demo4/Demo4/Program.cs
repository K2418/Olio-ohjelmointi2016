using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            int valinta;
            bool jatko = true;



            while (jatko == true)
            {
                Console.WriteLine("1. Tehtävä 5, radio\n2. Tehtävä 6, kirjahylly\n3. Tehtävä 7, sukupuu\n4. Lopeta");
                valinta = Convert.ToInt32(Console.ReadLine());

                switch (valinta)
                {
                    case 1:
                        Console.WriteLine("Luodaan uusi mankka.");
                        Radio mankka = new Radio();
                        mankka.PrintSettings();
                        Console.WriteLine("\nAlkuasetukset päällä\n\nYritetään säätää volumea tasolle 5.\n");
                        mankka.Volume = 5;
                        Console.WriteLine("\nLaitetaan power päälle:");
                        mankka.power = true;
                        mankka.PrintSettings();
                        Console.WriteLine("\nYritetään asettaa volumeksi 40 ja kanavaksi 666 666.66");
                        mankka.Volume = 40;
                        mankka.Channel = 666666.66;
                        mankka.PrintSettings();
                        Console.WriteLine("\nNoniin, pelleily loppuu ja laitetaan toimivat kanavat..");
                        mankka.Volume = 6;
                        mankka.Channel = 6666.6;
                        mankka.PrintSettings();
                        break;

                    case 2:
                        Console.WriteLine("On kirjoja, bluray levyjä, pelejä, kaukosäädin ja ohjain");
                        Kirja juoppohullunpaivakirja = new Kirja("Juoppohullun paivakirja", "OK", 5, 250);
                        Kirja tarpeellistaTavaraa = new Kirja("Tarpeellista Tavaraa", "aika rupsahtanut", 25, 870);
                        Peli demonsSouls = new Peli("Demons Souls", "Priima", 5);
                        Peli darkSouls = new Peli("Dark Souls", "Priima", 4);
                        BluRay Braindead = new BluRay("Braindead", "Nojaa", 7);
                        Ohjain original = new Ohjain(33, "Langaton");
                        Ohjain kiinalainen = new Ohjain(100, "Langallinen");
                        Kaukosaadin LG = new Kaukosaadin(77);
                        juoppohullunpaivakirja.PrintInfo();
                        tarpeellistaTavaraa.PrintInfo();
                        demonsSouls.PrintInfo();
                        darkSouls.PrintInfo();
                        Braindead.PrintInfo();
                        original.PrintInfo();
                        kiinalainen.PrintInfo();
                        LG.PrintInfo();
                        original.LataaAkku();
                        original.PrintInfo();
                        kiinalainen.KaynnistaKonsoli();
                        kiinalainen.PelaaPelia();
                        LG.KaynnistaTv();
                        LG.VaihdaKanavaa();
                        break;

                    case 3:
                        Sukupuu sukupuu = new Sukupuu();
                        Henkilo henk1 = new Henkilo("Marko", 100, 33, "Tampere");
                        Henkilo henk2 = new Henkilo("Steven", 13000000, 56, "US and a A");
                        Henkilo henk3 = new Henkilo("Pirkko", 50000, 42, "Toijala");
                        Henkilo henk4 = new Henkilo("Ilpo", 140000, 57, "Pihtipudas");
                        sukupuu.LisaaHenkilo(henk1);
                        sukupuu.LisaaHenkilo(henk2);
                        sukupuu.LisaaHenkilo(henk3);
                        sukupuu.LisaaHenkilo(henk4);
                        sukupuu.LaskeSuvunRahat();
                        sukupuu.TulostaSukulaiset();
                        henk3.Kuole();
                        sukupuu.Kuolema();
                        sukupuu.LaskeSuvunRahat();
                        sukupuu.TulostaSukulaiset();
                        Henkilo henk5 = new Henkilo("Santeri", 50, 18, "Jyväskylä");
                        sukupuu.LisaaHenkilo(henk5);
                        sukupuu.TulostaSukulaiset();
                        sukupuu.LaskeSuvunRahat();
                        henk2.Kuole();
                        sukupuu.Kuolema();
                        sukupuu.TulostaSukulaiset();
                        sukupuu.LaskeSuvunRahat();
                        break;

                    case 4:
                        Console.WriteLine("Hyvästi, tuulenpesä");
                        jatko = false;
                        break;

                    default:
                        Console.WriteLine("Nyt taisit näppäillä omias..");
                        break;
                }
            }
        }
    }
}
