using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest_ConsoleApp.Interfaces;

namespace UnitTest_ConsoleApp
{
    public class Car : ICar
    {
        public string Name { get; private set; }

        public ICarTrunk Trunk { get; private set; }


        public Car(string name, ICarTrunk trunk)
        {
            Name = name;
            Trunk = trunk;
        }


    }
}
