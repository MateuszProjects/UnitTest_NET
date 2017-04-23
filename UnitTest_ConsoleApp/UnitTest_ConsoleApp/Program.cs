using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota");
            Console.Write(car.Name);
            Console.ReadKey();
        }
    }
}
