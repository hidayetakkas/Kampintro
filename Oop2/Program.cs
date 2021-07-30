﻿using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerId = "1234568879";
            customer1.Name = "Hidayet";
            customer1.LastName = "Akkaş";
            customer1.IdNo = "191554825364";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerId = "125642";
            customer2.CompanyName = "Monster";
            customer2.TaxNo = "12354446878892";


            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);



        }
    }
}
