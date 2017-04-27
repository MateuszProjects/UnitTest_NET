using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest_ConsoleApp.Classes;


namespace UnitTest_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTrunk carTrunk = new CarTrunk(3);
            Car car = new Car("Toyota",carTrunk);
            Console.Write(car.Name, car.Trunk.TrunkCapacity);
            Console.ReadKey();
        }
    }
}
