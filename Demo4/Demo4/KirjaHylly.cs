using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
    class Fyysiset
    {
        public int ika { get; set; }
        public String nimi { get; set; }
        public String kunto { get; set; }

        public Fyysiset(String nimiIn, String kuntoIn, int ikaIn)
        {
            nimi = nimiIn;
            kunto = kuntoIn;
            ika = ikaIn;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("\nNimi: " + nimi + "\nIkä: " + ika + " vuotta\nKunto: " + kunto);
        }

    }

    class Tekniset
    {
        protected int akunTaso;

        public int AkunTaso
        {
            get { return akunTaso; }

            set
            {
                if (value <=100 && value >= 0) { akunTaso = value; }
            }
        }

        public void LataaAkku()
        {
            akunTaso = 100;
        }
        public Tekniset(int akku)
        {
            AkunTaso = akku;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("\nAkun taso: " + akunTaso);
        }
    }

    class BluRay : Fyysiset
    {
        public BluRay(String nimiIn, String kuntoIn, int ikaIn)
            : base (nimiIn, kuntoIn, ikaIn)
        {
            nimi = nimiIn;
            kunto = kuntoIn;
            ika = ikaIn;
        }
    }

    class Kirja : Fyysiset
    {
        private int sivuja;

        public Kirja(String nimiIn, String kuntoIn, int ikaIn, int sivumaara)
            : base(nimiIn, kuntoIn, ikaIn)
        {
            nimi = nimiIn;
            kunto = kuntoIn;
            ika = ikaIn;
            sivuja = sivumaara;
        }

        override public void PrintInfo()
        {
            Console.WriteLine("\nNimi: " + nimi + "\nSivumäärä: " + sivuja +  "\nIkä: " + ika + " vuotta\nKunto: " + kunto);
        }

    }

    class Peli : Fyysiset
    {
        public Peli(String nimiIn, String kuntoIn, int ikaIn)
            : base(nimiIn, kuntoIn, ikaIn)
        {
            nimi = nimiIn;
            kunto = kuntoIn;
            ika = ikaIn;
        }
    }

    class Ohjain : Tekniset
    {
        public String lanka;

        public Ohjain(int akku, String minkalainen)
            : base (akku)
        {
            AkunTaso = akku;
            lanka = minkalainen;
        }

        public void KaynnistaKonsoli()
        {
            Console.WriteLine("Käynnissä on..");
        }

        public void PelaaPelia()
        {
            Console.WriteLine("Näpy näpy");
        }

        public override void PrintInfo()
        {
            Console.WriteLine("\nAkun taso: " + akunTaso + "\nLangallinen vai langaton?: " + lanka);
        }
    }

    class Kaukosaadin : Tekniset
    {
        public Kaukosaadin(int akku)
            : base (akku)
        {
            AkunTaso = akku;
        }

        public void KaynnistaTv()
        {
            Console.WriteLine("Tv on nyt käynnissä");
        }

        public void VaihdaKanavaa()
        {
            Console.WriteLine("Channel 69, oujee");
        }
    }
}
