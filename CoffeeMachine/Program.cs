using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.adneom.coffeeMachineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/square/dagger/tree/master/examples/simple/src/main/java/coffee
            CoffeeMachin coffeMachine = new CoffeeMachin();
            int sugars = 2;
            ICafe cafe = coffeMachine.PrepareExpresso(sugars);

        }
    }

   
}
