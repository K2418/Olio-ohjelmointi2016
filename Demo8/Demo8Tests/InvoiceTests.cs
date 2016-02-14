using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8.Tests
{
    [TestClass()]
    public class InvoiceTests
    {
        [TestMethod()]
        public void InvoiceTest()
        {
            // Arrange
            string actual;
            string answer = "Customer Maija Kettunen's invoice:\n===============\nCandy, costs 2,49 euros each, 2 pieces for total of 4,98 euros.\nChocolate, costs 2,99 euros each, 1 pieces for total of 2,99 euros.\nJuice, costs 0,8 euros each, 2 pieces for total of 1,6 euros.\n===============\nTotal price: 9,57 euros.\n";
            Invoice customer1 = new Invoice("Maija Kettunen");
            customer1.BuyItems("Candy", 2.49, 2);
            customer1.BuyItems("Chocolate", 2.99, 1);
            customer1.BuyItems("Juice", 0.80, 2);

            // Act
            actual = customer1.ToString();

            // Assert
            Assert.AreEqual(answer, actual);
        }

        [TestMethod()]
        public void BuyItemsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }
    }
}