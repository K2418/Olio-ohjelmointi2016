using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8
{
    public class Invoice
    {
        string buyer;
        List<InvoiceItem> listOfItems = new List<InvoiceItem>();

        public Invoice(string whoBuys)
        {
            buyer = whoBuys;
        }

        public void BuyItems(string what, double pricePerEach, int howMany)
        {
            listOfItems.Add(new InvoiceItem(what, pricePerEach, howMany));
        }

        override public string ToString()
        {
            double totalCost = 0.00;
            string whoBoughtWhat = "Customer " + buyer + "'s invoice:\n===============";

            foreach(InvoiceItem item in listOfItems)
            {
                whoBoughtWhat += "\n" + item.ToString();
                totalCost += item.totalPrice;
            }

            whoBoughtWhat += "\n===============\nTotal price: " + totalCost + " euros.\n";

            return (whoBoughtWhat);
        }



    }
}
