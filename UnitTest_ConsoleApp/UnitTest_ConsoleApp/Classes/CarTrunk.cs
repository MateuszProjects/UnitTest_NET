using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_ConsoleApp.Classes
{
    public class CarTrunk : Interfaces.ICarTrunk
    {
        public int TrunkCapacity { get; private set; }

        public CarTrunk(int trunkCapacity)
        {
            TrunkCapacity = trunkCapacity;
        }
    }
}
