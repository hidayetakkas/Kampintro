using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class HousingLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Housing loan  calculated !!");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
