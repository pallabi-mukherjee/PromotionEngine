﻿using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {

            var promotionCombo1 = new Dictionary<string, int>();
            promotionCombo1.Add("A", 3);
            var promotionCombo2 = new Dictionary<string, int>();
            promotionCombo2.Add("B", 2);
            var promotionCombo3 = new Dictionary<string, int>();
            promotionCombo3.Add("C", 1);
            promotionCombo3.Add("D", 1);
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
                Console.WriteLine("enter the Products in your Cart:");
                string product = Console.ReadLine();
                Product p = new Product(product);
                products.Add(p);
            }
            
            Order order = new Order(products);
            var orderService = new OrderService();
            var price = orderService.GetTotalPrice(order, promotions);
            Console.WriteLine("Total Price of your Cart:{0}", price);

        }
    }
}
