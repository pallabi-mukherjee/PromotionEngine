using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PromotionEngine
{
    public class Promotion
    {
        static int nextId;
        public int PromotionId { get; private set; }
        public Dictionary<Product, int> ProductCombos { get; set; }
        public decimal PromoPrice { get; set; }

        public Promotion(Dictionary<Product, int> productCombos, decimal promoPrice)
        {
            PromotionId = Interlocked.Increment(ref nextId); ;
            ProductCombos = productCombos;
            PromoPrice = promoPrice;
        }
    }
}
