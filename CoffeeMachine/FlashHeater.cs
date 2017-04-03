using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace fr.adneom.coffeeMachineApp
{
    class FlashHeater : IHeater
    {
        public void Heat()
        {
            Console.Write("Heater Ready");
        }
    }

    class ClassicHeater : IHeater
    {
        public void Heat()
        {
            Console.Write("Heater getting Ready....");
            Thread.Sleep(1000);
            Console.Write("Ready");
        }
    }


}
