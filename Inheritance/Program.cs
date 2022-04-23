using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Person[] people = new Person[3]
            {
                new Customer{FirstName="Hidayet" },
                new Student{FirstName="Engin"},
                new Person{FirstName="Maria"}
            };
            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
            //Customer customer = new Customer();
        }
    }
}
