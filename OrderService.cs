using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    public static class OrderService
    {
        public static double GetTotalPrice(Order order, List<Promotion> availablePromotions)
        {
            List<double> discountedPrices = availablePromotions
            .Select(promo => GetDiscount(order, promo))
            .ToList();
            double originalPrice = order.Products.Sum(x => x.ProductPrice);
            double discountedPrice = discountedPrices.Sum();
            return 0;
        }

        private static double GetDiscount(Order ord, Promotion prom)
        {
            double d = 0;
            //get count of promoted products in order
            var countPromotedProductsInOrder = ord.Products
                .GroupBy(x => x.ProductId)
                .Where(grp => prom.ProductCombos.Any(y => grp.Key == y.Key && grp.Count() >= y.Value))
                .Select(grp => grp.Count())
                .Sum();
            //get count of promoted products from promotion
            int countPromotedProductsInPromotion = prom.ProductCombos.Sum(kvp => kvp.Value);
            while (countPromotedProductsInOrder >= countPromotedProductsInPromotion)
            {
                d += prom.PromoPrice;
                countPromotedProductsInOrder -= countPromotedProductsInPromotion;
            }
            return d;
        }
    }
}
