using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest_ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_ConsoleApp.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void obliczObliczTest()
        {
            var exceptionresult = 25;
            var car = new Car("toyota");
            var dane = car.oblicz(5);


            Assert.AreEqual(exceptionresult, dane);
        }
    }
}