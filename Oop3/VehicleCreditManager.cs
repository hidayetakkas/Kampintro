using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle credit calculated !!");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
