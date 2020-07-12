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
        public Dictionary<string, int> ProductCombos { get; set; }
        public double PromoPrice { get; set; }

        public Promotion(Dictionary<string, int> productCombos, double promoPrice)
        {
            PromotionId = Interlocked.Increment(ref nextId); ;
            ProductCombos = productCombos;
            PromoPrice = promoPrice;
        }
    }
}
