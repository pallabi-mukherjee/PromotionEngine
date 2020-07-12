using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.WriteLine("total number of prodcuts");
            int numbeOfProducts = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbeOfProducts; i++)
            {
                Console.WriteLine("enter the Products:");
                string product = Console.ReadLine();
                Product p = new Product(product);
                products.Add(p);
            }
            Order order = new Order(products);


        }
    }
}
