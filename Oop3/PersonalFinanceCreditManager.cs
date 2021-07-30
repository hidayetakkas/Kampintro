using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class PersonalFinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal finance credit calculated !!");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
