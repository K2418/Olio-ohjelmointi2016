using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Demo7
{
    [Serializable]
    class Telkku
    {
        internal string nimi;
        internal string info;
        internal int kanava;
        internal string alkaa;
        internal string loppuu;

        public Telkku (string ohjelmanNimi, int channel, string alkaaIn, string loppuuIn, string kuvaus)
        {
            nimi = ohjelmanNimi;
            kanava = channel;
            info = kuvaus;
            alkaa = alkaaIn;
            loppuu = loppuuIn;
        }


    }

    class TallennusJaLuku
    {
        public void tallennaTiedostoon(List<Telkku> talteen)
        {
            Stream tallenna = new FileStream("Kanavat.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(tallenna, talteen);
            tallenna.Close();
        }

        public void haeTiedostosta(String tiedostonimi)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream lue = new FileStream(tiedostonimi, FileMode.Open, FileAccess.Read, FileShare.None);
            List<Telkku> lueTelkku = (List<Telkku>)formatter.Deserialize(lue);

            foreach (Telkku luettu in lueTelkku)
            {
                Console.WriteLine("Ohjelma: " + luettu.nimi);
                Console.WriteLine("Kanava: " + luettu.kanava);
                Console.WriteLine("Alkaa: " + luettu.alkaa + " Loppuu: " + luettu.loppuu);
                Console.WriteLine("Kuvaus: " + luettu.info);
            }
        }
    }
}
