using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest_ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest_ConsoleApp.Classes;
namespace UnitTest_ConsoleApp.Tests
{
    [TestClass]
    public class CarTests
    {

        CarTrunk myCarTrunk;
        Car myCar;
        

        [TestInitialize]
        public void TestInit()
        {
            myCarTrunk = new CarTrunk(2);
            myCar = new Car("Test model", myCarTrunk);
        }

        [TestMethod]
        public void PackLuggageToTheTrunk_Test()
        {
            // Given

            // When

            // Then

            // Assert.AreEqual();
        }
    }
}