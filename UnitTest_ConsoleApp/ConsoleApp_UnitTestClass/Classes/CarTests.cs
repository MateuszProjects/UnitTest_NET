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

            // Wskazówka: Moq pozwala na zweryfikowanie czy dana metoda została 
            // wywołana po wykonaniu się kodu innej metody.
            // Użyj odpowiednią metodę na zamockowanej zależności

            //         public void PackItem(string carModel, ILuggage item)

            // Given
            var fakeTrunk = new Mock<ICarTrunk>();
            var fakeLuggage = new Mock<List<ILuggage>>();
            var fakeCar = new Mock<ICar>();

            // When
            fakeLuggage.Setup(x => x.Count).Returns(3);
            fakeCar.Setup(y => y.Model);

            var ourCar = new Car(null, fakeTrunk.Object);
            var outTranck = new CarTrunk(3);

             
            // Then

            //  Assert.AreEqual(fakeLuggage, fakeTrunk);


        }

    }
}