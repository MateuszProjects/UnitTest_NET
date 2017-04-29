using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_ConsoleApp.Classes
{
    class FuelChecker
    {
        public static int ReturnFuelLevel()
        {
            var random = new Random();
            var randomValue = random.Next(100);

            return randomValue;
        }
    }
}
