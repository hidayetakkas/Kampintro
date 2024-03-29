﻿using InterfaceAbsractDemo.Abstract;
using InterfaceAbsractDemo.Entities;
using InterfaceAbsractDemo.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbsractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId),customer.FistName.ToUpper(),customer.LastName.ToUpper(),customer.DateOfBirth.Year);
        }

       
    }
}
