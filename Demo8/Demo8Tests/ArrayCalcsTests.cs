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
    public class ArrayCalcsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            //Arrange
            Double[] arvot = new double[] { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double answer = 25.6;

            //Act
            double act = ArrayCalcs.Sum(arvot);

            // Assert
            Assert.AreEqual(answer, act);
        }

        [TestMethod()]
        public void AverageTest()
        {
            //Arrange
            Double[] arvot = new double[] { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double answer = 3.66;

            //Act
            double act = ArrayCalcs.Average(arvot);

            // Assert
            Assert.AreEqual(answer, act);
        }

        [TestMethod()]
        public void MinTest()
        {
            //Arrange
            Double[] arvot = new double[] { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double answer = -4.5;

            //Act
            double act = ArrayCalcs.Min(arvot);

            // Assert
            Assert.AreEqual(answer, act);
        }

        [TestMethod()]
        public void MaxTest()
        {
            //Arrange
            Double[] arvot = new double[] { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double answer = 12.0;

            //Act
            double act = ArrayCalcs.Max(arvot);

            // Assert
            Assert.AreEqual(answer, act);
        }
    }
}