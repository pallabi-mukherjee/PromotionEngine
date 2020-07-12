using System;
using Xunit;
using PromotionEngine;
using System.Collections.Generic;
using Moq;

namespace PromotionEngineTest
{
    public class PromotionEngineTest
    {
        [Fact]
        public void TestPromotionEngineSet1()
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

            List<Product> products = new List<Product>(){
                new Product("A"),
                new Product("B"),
                new Product("C")
                };

            Order order = new Order(products);
            var orderService = new OrderService();
            var price = orderService.GetTotalPrice(order, promotions);
            Assert.Equal(100, price);

        }

        [Fact]
        public void TestPromotionEngineSet2()
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

            List<Product> products = new List<Product>(){
                new Product("A"),
                new Product("A"),
                new Product("A"),
                new Product("A"),
                new Product("A"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("C")
                };

            Order order = new Order(products);
            var orderService = new OrderService();
            var price = orderService.GetTotalPrice(order, promotions);
            Assert.Equal(370, price);

        }

        [Fact]
        public void TestPromotionEngineSet3()
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

            List<Product> products = new List<Product>(){
                new Product("A"),
                new Product("A"),
                new Product("A"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("B"),
                new Product("C"),
                new Product("D")
                };

            Order order = new Order(products);
            var orderService = new OrderService();
            var price = orderService.GetTotalPrice(order, promotions);
            Assert.Equal(280, price);

        }
    }
}
