using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo7
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiedostoon teht2 = new Tiedostoon();
            teht2.Teht2();

            TallennusJaLuku jep = new TallennusJaLuku();
            List<Telkku> ohjelmisto = new List<Telkku>();
            ohjelmisto.Add(new Telkku("Salkkarit", 3, "19:00", "19:30", "Ohjelma, josta on tullut muutama jakso liikaa"));
            ohjelmisto.Add(new Telkku("Holby Cityn sairaala", 2, "16:00", "17:00", "Ohjelma, joka suistaa nuoret hermoromahduksen partaalle, koska naiset katsovat maratoonina ja täten varaavat tv:n koko illaksi"));
            ohjelmisto.Add(new Telkku("Titanic", 5, "21:00", "23:50", "Elokuva, jossa DiFaabio olisi mahtunut lautalle lopussa, Cameron kuitenkin halusi itkettää naisia ja täten hukutti hahmon."));
            jep.tallennaTiedostoon(ohjelmisto);
            jep.haeTiedostosta("Kanavat.bin");
            Console.WriteLine("Tarkastetaan työn tulos rauhassa, spacebar toimii jos pois jo haluat.");
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)) { }
        }
    }
}
