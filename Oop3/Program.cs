using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonalFinanceCreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            //personalFinanceCreditManager.Calculate();
            //VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.Calculate();
            //HousingLoanManager housingLoanManager = new HousingLoanManager();
            //housingLoanManager.Calculate();
            //--------------Same work----------
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            //personalFinanceCreditManager.Calculate();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.Calculate();
            ICreditManager housingLoanManager = new HousingLoanManager();
            //housingLoanManager.Calculate();
            ApplicationManager applicationManager = new ApplicationManager();
            //1 or
            //applicationManager.Apply(personalFinanceCreditManager);
            //2 or 
            //applicationManager.Apply(vehicleCreditManager);
            //3
            //applicationManager.Apply(housingLoanManager);

            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager,vehicleCreditManager,housingLoanManager };
            applicationManager.CreditInformation(credits);
        }
    }
}
