using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo7
{
    class Tiedostoon
    {
        private List<int> kokLuk = new List<int>();
        private List<double> liuLuk = new List<double>();
        private double read;
        private bool jatko = true;
        private static string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private System.IO.StreamWriter liukuluvut = new System.IO.StreamWriter(mydocpath + @"\liukuluvut.txt");
        private System.IO.StreamWriter kokoluvut = new System.IO.StreamWriter(mydocpath + @"\kokonaisluvut.txt");

        public void Teht2()
        {
            Console.WriteLine("Syötä kokonaislukuja tai liukulukuja, jokin muu näppäin kuin numero lopettaa.");
            while (jatko == true)
            {
                try
                {
                    read = Convert.ToDouble(Console.ReadLine());

                    if (read % 1 == 0)
                    {
                        kokLuk.Add(Convert.ToInt32(read));

                    }
                    else { liuLuk.Add(read); }
                }

                catch (System.FormatException)
                {
                    Console.WriteLine("Kiitos ja näkemiin");
                    jatko = false;
                }


            }

            try
            {

                foreach (int n in kokLuk)
                {
                    kokoluvut.WriteLine(n);
                }
                foreach (double d in liuLuk)
                {
                    liukuluvut.WriteLine(d);
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine("Virhe' " + ex + " 'tulostettaessa tiedostoon.");
            }

            finally
            {
                if (kokoluvut != null) { kokoluvut.Close(); }
                if (liukuluvut != null) { liukuluvut.Close(); }
            }
        }
        
    }
}
