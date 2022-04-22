using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Product product1 = new Product();

            product1.Name = "Apple";
            product1.Price = 15;
            product1.Explanation = "Amasya";
            product1.Stock = 8;

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 80;
            product2.Explanation = "Diyarbakır";
            product2.Stock = 10;

            Product[] products = new Product[] { product1, product2 };


            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine(product.Stock);
                Console.WriteLine("---------------------");

            }

            Console.WriteLine("..........Metotlar........");
            
            //encapsulation
            //instance
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);
            


        }
    }
}
