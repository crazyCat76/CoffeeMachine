using System;

namespace fr.adneom.coffeeMachineApp
{
    internal class CoffeeMachin
    {
        public IHeater Heater { get; set; }

        public ICafe PrepareExpresso(int sugars)
        {
            throw new NotImplementedException();
        }
    }
}