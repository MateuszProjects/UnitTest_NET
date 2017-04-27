using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_ConsoleApp
{
    public class Car : ICar
    {
        public string Name { get; set; }

        public Car(string name)
        {
            Name = name;
        }

 

        public int oblicz(int dane)
        {
            return dane * 5;
        }
    }
}
