using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_ConsoleApp.Classes
{
    public class Luggage : Interfaces.ILuggage
    {
        public string Name { get; set; }

        public Luggage(string name)
        {
            Name = name;
        }
             
    }
}
