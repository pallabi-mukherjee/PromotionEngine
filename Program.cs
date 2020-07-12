using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var productA = new Product("A");
            var productB = new Product("B");
            var productC = new Product("C");
            var productD = new Product("D");
            var promotionCombo1 = new Dictionary<Product, int>();
            promotionCombo1.Add(productA, 3);
            var promotionCombo2 = new Dictionary<Product, int>();
            promotionCombo2.Add(productB, 2);
            var promotionCombo3 = new Dictionary<Product, int>();
            promotionCombo3.Add(productC, 1);
            promotionCombo3.Add(productD, 1);
            List<Promotion> promotions = new List<Promotion>()
            {
                new Promotion(promotionCombo1,130),
                new Promotion(promotionCombo2,45),
                new Promotion(promotionCombo3,30)

            };

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
