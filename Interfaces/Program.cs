using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {


            //Demo2();
            //InterfacesIntro();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal() 
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();

        }

        private static void Demo2()
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            //personManager.Add(new Customer { Id=1,FirstName="Hidayet",LastName="Akkas",Address="Warsaw"});
            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Hidayet",
                LastName = "Akkas",
                Address = "Warsaw"

            };

            Student student = new Student()
            {
                Id = 2,
                FirstName = "hido",
                LastName = "Akkas",
                Department = "Power Engineering"

            };

            personManager.Add(student);
            personManager.Add(customer);
        }
    }


    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
