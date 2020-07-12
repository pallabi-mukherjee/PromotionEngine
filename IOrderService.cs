using System.Collections.Generic;

namespace PromotionEngine
{
    public interface IOrderService
    {
        double GetTotalPrice(Order order, List<Promotion> availablePromotions);
    }
}
