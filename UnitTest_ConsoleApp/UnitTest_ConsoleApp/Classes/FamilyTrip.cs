using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest_ConsoleApp.Interfaces;

namespace UnitTest_ConsoleApp.Classes
{
    public class FamilyTrip
    {
        private ICar _familyCar;

        private List<ILuggage> _familyLuggage;

        public FamilyTrip(ICar familyCar, List<ILuggage> familyLuggage)
        {
            _familyCar = familyCar;
            _familyLuggage = familyLuggage;
        }

        public bool PrepareFamilyTrip()
        {
            Console.Out.WriteLine("Family is packing the car!");
            var pacckinlsSuccess = false;

            try
            {
                pacckinlsSuccess = _familyCar.PackLuggageToTheTrunk(_familyLuggage);
            }catch(Exception ex)
            {
                Console.Out.WriteLine("There is a problem with packing: " + ex.Message);
                return false;
            }

            if (!pacckinlsSuccess)
            {
                Console.Out.WriteLine("Too much luggage!");
                return false;
            }

            Console.Out.WriteLine("Dad is checking how much fuel we have!");
            var carFuelLevel = _familyCar.CheckerFulLevel();
            if(carFuelLevel < 50)
            {
                Console.Out.WriteLine("Dad needs to tank out family car!");
                return false;
            }

            Console.Out.WriteLine("Yay! We are ready to go!");

            return true;
        }
    }
}
