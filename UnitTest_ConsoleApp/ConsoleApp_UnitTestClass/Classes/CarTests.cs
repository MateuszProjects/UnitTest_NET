using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using UnitTest_ConsoleApp.Classes;
using UnitTest_ConsoleApp.Interfaces;
namespace UnitTest_ConsoleApp.Tests
{
    [TestClass]
    public class CarTests
    {
        // TODO: Zadanie nr 4
        // Zainicjalizuj powtarzające się dane używane w dotychczasowych testach 
        // w odpowiedniej metodzie inicjalizującej każdy test
        // Wskazówka: Użyj odpowiedniego atrybutu testów używanego w MSTest framework

        CarTrunk myCarTrunk;
        Car myCar;
        List<ILuggage> laggageList;
        

        [TestInitialize]
        public void TestInit()
        {
            myCarTrunk = new CarTrunk(2);
            myCar = new Car("Test model", myCarTrunk);
            laggageList = new List<ILuggage>();
        }

        [TestMethod]
        public void PackLuggageToTheTrunk_Test()
        {
            // TODO: Zadanie nr 1
            // Napisz test jednostkowy sprawdzający metodę 
            // „PackLuggageToTheTrunk” czy zwraca „true” 
            // gdy bagaż nie przekracza rozmiaru bagażnika samochodu


            // Given

            var myluggage = new Luggage("luggage one");
            laggageList.Add(myluggage);

            // When

            var result = myCar.PackLuggageToTheTrunk(laggageList);

            // Then

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void PackLuggageToTheTrunk_Test_Second()
        {
            // TODO: Zadanie nr 2
            // Napisz test jednostkowy sprawdzający metodę 
            // „PackLuggageToTheTrunk” czy zwraca „false” gdy 
            // bagaż przekracza rozmiar bagażnika samochodu

            // Given

            var myLuggage_one = new Luggage("luggage one");
            var myLuggage_second = new Luggage("luggage second");
            var myLuggage_three = new Luggage("luggage three");

            laggageList.Add(myLuggage_one);
            laggageList.Add(myLuggage_second);
            laggageList.Add(myLuggage_three);

            // When

            var result = myCar.PackLuggageToTheTrunk(laggageList);

            // Then

            Assert.AreNotEqual(true, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception),"A userId of null was inappropriately allowed.")]
        public void Exception_PackLuggageToTheTrunk()
        {
            // TODO: Zadanie nr 3
            // Napisz test jednostkowy sprawdzający metodę „PackLuggageToTheTrunk” 
            // czy rzuca wyjątek gdy podany parametr jest nieprawidłowy
            
            // Given

            laggageList.Add(null);

            // When

            var result = myCar.PackLuggageToTheTrunk(null);

           
        }

        [TestMethod]
        public void ShouldCallPackMethodAsManyTimesAsLuggageCount()
        {
            // TODO: Zadanie nr 8
            // Napisz test jednostkowy sprawdzający czy metoda „PackItem” 
            // została wywołana tyle razy ile jest bagażu

            // Given
            var fakeTrunk = new Mock<ICarTrunk>();
            var fakeCar = new Mock<ICar>();
            var fakeLuggage = new Mock<List<ILuggage>>();
        

            fakeLuggage.Setup(x => x.Count).Returns(2);
            fakeCar.Setup(x => x.PackLuggageToTheTrunk(null));
            fakeTrunk.Setup(x => x.PackItem(null, null));

      
            var ourTrip = new FamilyTrip(null, fakeLuggage.Object);


            // When

            var result = ourTrip.PrepareFamilyTrip();

            // Then

            Assert.IsTrue(result);
        }


    }
}