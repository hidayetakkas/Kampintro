using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    class CorporateCustomer:Customer //inheritance
    {
        
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
