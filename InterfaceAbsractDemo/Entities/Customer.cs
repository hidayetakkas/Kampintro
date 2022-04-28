using InterfaceAbsractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbsractDemo.Entities
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string  FistName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
