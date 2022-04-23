using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            ProductManager productManager = new ProductManager();
            customerManager.Add();
            customerManager.Update();
            productManager.Add();
            productManager.Update();
            
            Customer customer2 = new Customer();
            customer2.Id = 1;
            customer2.LastName = "Akkas";
            customer2.FirstName = "Hidayet";
            customer2.City = "İzmir";
            Customer customer1 = new Customer { Id=2,LastName="Akkas",FirstName="Hidayet",City="Warsaw"};
            Console.WriteLine(customer1.City);
            Console.WriteLine(customer2.City);
            Console.WriteLine(customer1.LastName);
            Console.ReadLine();       
        }
    }
}
