﻿using System.Collections.Generic;
using System.Threading;

namespace PromotionEngine
{
    public class Order
    {
        static int nextIdForOrder;
        public int OrderId { get; private set; }
        public List<Product> Products { get; set; }

        public Order(List<Product> products)
        {
            OrderId = Interlocked.Increment(ref nextIdForOrder);
            Products = products;
        }
    }
}
