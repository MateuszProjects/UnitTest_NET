using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest_ConsoleApp.Interfaces;

namespace UnitTest_ConsoleApp
{
    public interface ICar
    {
        string Model { get;  }
        
        ICarTrunk Trunk { get; }

        int CheckerFulLevel();

        bool PackLuggageToTheTrunk(List<ILuggage> luggageItems);
    }
}
