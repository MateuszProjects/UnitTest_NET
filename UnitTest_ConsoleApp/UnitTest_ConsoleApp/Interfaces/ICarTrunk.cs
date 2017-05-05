using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_ConsoleApp.Interfaces
{
  public interface ICarTrunk
    {
        int TrunkCapacity { get; }

        void PackItem(string carModel, ILuggage item);

    }
}
