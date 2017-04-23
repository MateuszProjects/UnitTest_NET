using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_ConsoleApp
{
    public class Car : UnitTest_ConsoleApp.ICar
    {


        public int oblicz(int dane)
        {
            return dane * 5;
        }
    }
}
