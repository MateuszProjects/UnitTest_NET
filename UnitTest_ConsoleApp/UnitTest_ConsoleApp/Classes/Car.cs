using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest_ConsoleApp.Classes;
using UnitTest_ConsoleApp.Interfaces;

namespace UnitTest_ConsoleApp
{
    public class Car : ICar
    {
        public string Model { get; private set; }

        public ICarTrunk Trunk { get; private set; }


        public Car(string name, ICarTrunk trunk)
        {
            Model = name;
            Trunk = trunk;
        }

        public int CheckerFulLevel()
        {
            Console.Out.WriteLine("Fuel level checking... ");
            return FuelChecker.ReturnFuelLevel();
        }

        public bool PackLuggageToTheTrunk(List<ILuggage> luggageItems)
        {
            if(luggageItems == null)
            {
                throw new Exception("Luggage does not exist!");
            }

            if(luggageItems.Count > Trunk.TrunkCapacity)
            {
                Console.Out.WriteLine("Car trunk is not big enough for such a luggage!");
                return false;
            }

            foreach(var luggageItem in luggageItems)
            {
                Trunk.PackItem(Model, luggageItem);
            }

            return true; 

        }
    }
}
