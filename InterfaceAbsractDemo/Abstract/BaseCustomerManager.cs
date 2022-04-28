using InterfaceAbsractDemo.Entities;
using InterfaceAbsractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace InterfaceAbsractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to database : " + customer.FistName);
        }
    }
}
