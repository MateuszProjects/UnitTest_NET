using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest_ConsoleApp.Classes;
using UnitTest_ConsoleApp.Interfaces;

namespace UnitTest_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var carTrunk = new CarTrunk(3);
            var ourFamilyCar = new Car("Toyota Corolla",carTrunk);

            var mommyBag = new Luggage("Huge mommy bag");
            var tennisRacket = new Luggage("My tennis racket");
            var dadTools = new Luggage("Dad tools");
            // var notNeededLuggage = new Luggage("Useless stuff");

            var ourLuggage = new List<ILuggage>();
            ourLuggage.Add(mommyBag);
            ourLuggage.Add(tennisRacket);
            ourLuggage.Add(dadTools);
            // ourLuggage.Add(notNeededLuggage);

            var ourFamilyTrip = new FamilyTrip(ourFamilyCar, ourLuggage);

            ourFamilyTrip.PrepareFamilyTrip();
            Console.ReadKey();
        }
    }
}
