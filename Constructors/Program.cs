using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id=1, FirstName="Engin", LastName="Demirog",City="Istanbul"};// used with default contructor 
            Customer customer2 = new Customer(2,"Derin","Demirog","Ankara"); 

            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer1.FirstName);
        }

    }

    class Customer
    {
        public Customer(int id,string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }
        public Customer()
        {
            Console.WriteLine("default contructor!!");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
