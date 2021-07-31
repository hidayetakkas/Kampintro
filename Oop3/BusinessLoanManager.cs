using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BusinessLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Business Loan Calculated !!");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
