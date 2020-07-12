using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public interface IOrderService
    {
        double GetTotalPrice(Order order, List<Promotion> availablePromotions);
    }
}
