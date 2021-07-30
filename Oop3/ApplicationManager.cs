using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class ApplicationManager
    {
        public void Apply(ICreditManager creditManager)
        {
            creditManager.Calculate();
        }
        public void CreditInformation(List<ICreditManager>credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
