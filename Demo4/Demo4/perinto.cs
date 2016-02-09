using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{

    class Sukupuu
    {
        protected List<Henkilo> sukulaiset;
        protected List<Henkilo> kuolleetSukulaiset;
        protected int rahaaSuvussa;
        private int montako;
        private int perinto = 0;
        private int perintoJakoon;

        public void LaskeSuvunRahat()
        {
            rahaaSuvussa = 0;

            foreach (Henkilo henkilo in sukulaiset)
            {
                rahaaSuvussa += henkilo.Omaisuus;
            }
            Console.WriteLine("\nSuvussa rahaa: " + rahaaSuvussa);
        }

        public Sukupuu()
        {
            sukulaiset = new List<Henkilo>();
            kuolleetSukulaiset = new List<Henkilo>();
        }

        public void LisaaHenkilo(Henkilo kuka)
        {
            sukulaiset.Add(kuka);
        }

        public void LaskeSukulaiset()
        {
            montako = sukulaiset.Count;
            Console.WriteLine("Suvussa on " + montako + "henkilöä");
        }

        public void TulostaSukulaiset()
        {
            foreach (Henkilo henkilo in sukulaiset)
            {
                henkilo.PrintInfo();
            }
        }

        public void Kuolema()
        {
            foreach (Henkilo henkilo in sukulaiset)
            {
                if (henkilo.elossa == false)
                {
                    sukulaiset.Remove(henkilo);
                    kuolleetSukulaiset.Add(henkilo);
                    perinto += henkilo.Omaisuus;
                    break;
                }
            }

            LaskeSukulaiset();
            perintoJakoon = perinto / montako;

            foreach(Henkilo henkilo in sukulaiset)
            {
                henkilo.Omaisuus = henkilo.Omaisuus + perintoJakoon;
            }
        }
    }

    class Henkilo : Finanssi
    {
        protected String nimi;
        protected int ika;
        public bool elossa = true;
        protected string asuinPaikka;

        public Henkilo(string mikaNimi, int rahaa, int mikaIka, string mistapain)
        {
            nimi = mikaNimi;
            Omaisuus = rahaa;
            ika = mikaIka;
            asuinPaikka = mistapain;
        }

        public void Kuole()
        {            
            elossa = false;
            Console.WriteLine("\n" + nimi + " kuoli juuri, osanottoni.");
        }



        public void PrintInfo()
        {
            Console.WriteLine("\nNimi: " + nimi + "\nIkä: " + ika + "\nAsuinpaikka: " + asuinPaikka + "\nOmaisuus: " + Omaisuus);
        }

    }

    class Finanssi
    {
        protected int omaisuus;

        public int Omaisuus
        {
            get
            {
                return omaisuus;
            }

            set
            {
                omaisuus = value;
            }
        }
    }
}
