using InterfaceAbsractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbsractDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
       
    }
}
