using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest_ConsoleApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace UnitTest_ConsoleApp.Classes.Tests
{
    [TestClass()]
    public class FamilyTripFamilyTripTest
    {
        Mock<ICar> fakecar;

        [TestInitialize]
        public void Init()
        {
            fakecar = new Mock<ICar>();
        }

        [TestMethod]
        public void ShouldPrepareFamilyTripReturnFalseWhenExceptionOccurredDuringPackingLuggage()
        {
            // TODO: Zadanie nr 7
            // Napisz test jednostkowy sprawdzający metodę „PrepareFamilyTrip” 
            // czy zwraca „false” gdy metoda użyta do pakowania bagażu zwraca wyjątek

            // Given
            fakecar.Setup(x => x.PackLuggageToTheTrunk(null)).Throws(new Exception());
            fakecar.Setup(y => y.CheckerFulLevel()).Returns(51);

            var ourFamilyTrip = new FamilyTrip(fakecar.Object, null);

            // When
            var result = ourFamilyTrip.PrepareFamilyTrip();

            // Then
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShouldPrepareFamilyTripReturnFalseWhenFuelLevelIsNotEnough()
        {
            // TODO: Zadanie nr 6
            // Napisz test jednostkowy sprawdzający metodę „PrepareFamilyTrip” 
            // czy zwraca „false” gdy poziom paliwa jest niewystarczający

            // Give
            fakecar.Setup(x => x.CheckerFulLevel()).Returns(48);

            var ourFamilyTrip = new FamilyTrip(fakecar.Object, null);
            // When
            var result = ourFamilyTrip.PrepareFamilyTrip();

            // Then
            Assert.IsFalse(result);
        }
    }
}