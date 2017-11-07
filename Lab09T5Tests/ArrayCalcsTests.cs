using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab09T5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09T5.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        public static double[] taulö = { 1.0, 2.0, 12.0 };
        [TestMethod()]
        public void SumTest()
        {
            double expected = 15.0;
            double actual = ArrayCalcsTests.taulö.Sum();
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }

        [TestMethod()]
        public void AverageTest()
        {
            double expected = 5.0;
            double actual = ArrayCalcsTests.taulö.Average();
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }

        [TestMethod()]
        public void MinTest()
        {
            double expected = 1.0;
            double actual = ArrayCalcsTests.taulö.Min();
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }

        [TestMethod()]
        public void MaxTest()
        {
            double expected = 12.0;
            double actual = ArrayCalcsTests.taulö.Max();
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }
    }
}