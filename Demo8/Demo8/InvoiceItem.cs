using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8
{
    class InvoiceItem
    {
        private string product;
        private int quantity;
        internal double totalPrice;


        private double price;
        private double Price
        {
            get { return price; }

            set
            {
                price = Math.Round(value, 2, MidpointRounding.AwayFromZero);
            }
        }

        internal InvoiceItem(string name, double priceOf, int howMany)
        {
            product = name;
            Price = priceOf;
            quantity = howMany;
            totalPrice = priceOf * howMany;
        }

        override public string ToString()
        {
            string wholeSale = product + ", costs " + Price + " euros each, " + quantity + " pieces for total of " + totalPrice + " euros.";
            return wholeSale;
        }
    }
}
