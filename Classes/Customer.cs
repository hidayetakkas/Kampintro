using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        private string _lastName;

        public int Id { get; set; }
        public string FirstName { get; set; }
        //public string LastName { 
        //    get { return "Mr." + _lastName; }
        //    set { _lastName = value; } 
        //}
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
