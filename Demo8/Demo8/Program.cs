using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8
{
    class Program
    {


        static void Main(string[] args)
        {
            bool loopFor = true;
            int choose;

            while(loopFor == true)
            {
                Console.WriteLine("1. Tehtävä1: Roll the dice!\n2. Tehtävä2: Product\n3. Tehtävä5: Array matikkaa\n4. Tehtävä6: Henkilön ostokset \n5. Quit");
                choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Noppa noppen = new Noppa();
                        noppen.Dice();
                        break;

                    case 2:
                        List<Product> products = new List<Product>();
                        products.Add(new Product("LG 42\" Smart-LED TV", 500.99));
                        products.Add(new Product("Yamaha 5.1 AV-Receiver", 259.92));
                        products.Add(new Product("Eltax 5.1 Speaker set", 249.50));
                        foreach(Product product in products)
                        {
                            product.PrintInfo();
                        }
                        break;

                    case 3:
                        Double[] arvot = new double[] { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
                        Console.WriteLine("Sum: " + ArrayCalcs.Sum(arvot));
                        Console.WriteLine("Average: " + ArrayCalcs.Average(arvot));
                        Console.WriteLine("Min: " + ArrayCalcs.Min(arvot));
                        Console.WriteLine("Max: " + ArrayCalcs.Max(arvot));
                        break;

                    case 4:
                        Invoice customer1 = new Invoice("Maija Kettunen");
                        customer1.BuyItems("Candy", 2.49, 2);
                        customer1.BuyItems("Chocolate", 2.99, 1);
                        customer1.BuyItems("Juice", 0.80, 2);
                        Console.WriteLine(customer1.ToString());
                        break;

                    case 5:
                        loopFor = false;
                        break;

                    default:
                        Console.WriteLine("\nCheck your input.");
                        break;
                }
            }


        }
    }
}
