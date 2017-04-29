using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest_ConsoleApp.Interfaces;

namespace UnitTest_ConsoleApp.Classes
{
    public class CarTrunk : ICarTrunk
    {
        public int TrunkCapacity { get; private set; }

        public CarTrunk(int trunkCapacity)
        {
            TrunkCapacity = trunkCapacity;
        }

        public void PackItem(string carModel, ILuggage item)
        {
            Console.Out.WriteLine(string.Format("New item: {0} has benn packed to {1} trunk!", item.Name, carModel));
        }
    }
}
