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
        string Name { get;  }
        
        ICarTrunk Trunk { get; }
    }
}
