using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8
{
    class Product
    {
        public string product;
        private double price;
        public double Price
        {
            get { return price; }

            set
            {
                price = Math.Round(value, 2, MidpointRounding.AwayFromZero);
            }
        }

        public Product(string name, double priceOf)
        {
            product = name;
            Price = priceOf;
        }

        public void PrintInfo()
        {
            Console.WriteLine("{0}, {1} euros.", product, Price);
        }
    }
}
