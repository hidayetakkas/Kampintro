using InterfaceAbsractDemo.Abstract;
using InterfaceAbsractDemo.Adapters;
using InterfaceAbsractDemo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbsractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Entities.Customer {DateOfBirth=new DateTime(1997,8,7),FistName="Hidayet",LastName="Akkaş",NationalityId="123546584546" });
            
           // BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            //customerManager.Save(new Entities.Customer { DateOfBirth = new DateTime(1997, 8, 7), FistName = "Hidayet", LastName = "Akkaş", NationalityId = "190" });
            Console.ReadLine();
        }
    }
}
