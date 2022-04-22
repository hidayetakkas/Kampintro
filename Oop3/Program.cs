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
            ICreditManager businessLoanManager = new BusinessLoanManager();
            //housingLoanManager.Calculate();

            ApplicationManager applicationManager = new ApplicationManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            List<ILoggerService> loggers = new List<ILoggerService> { databaseLoggerService, fileLoggerService, smsLoggerService };
            //1 or
            //applicationManager.Apply(personalFinanceCreditManager, loggers);
            //2 or 
            //applicationManager.Apply(vehicleCreditManager, loggers);
            //3
            //applicationManager.Apply(housingLoanManager, loggers);
            //4 or
            applicationManager.Apply(businessLoanManager, loggers);

            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager,vehicleCreditManager,housingLoanManager,businessLoanManager };
            //applicationManager.CreditInformation(credits);
        }
    }
}
