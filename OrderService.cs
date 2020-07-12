using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    public class OrderService:IOrderService
    {
        public double GetTotalPrice(Order order, List<Promotion> availablePromotions)
        {
            List<double> discountedPrices = availablePromotions
            .Select(promo => GetDiscountedPrice(order, promo))
            .ToList();
            double finalPrice = discountedPrices.Sum();
            return finalPrice;
        }

        private double GetDiscountedPrice(Order ord, Promotion prom)
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
            foreach(var i in prom.ProductCombos)
            {
                int TotalCountInOrder = ord.Products.Count(x => x.ProductId.Equals(i.Key));
                double productPrice = ord.Products.Where(x => x.ProductId.Equals(i.Key)).Select(x=>x.ProductPrice).FirstOrDefault();
                var addedPrice = countPromotedProductsInOrder * productPrice;
                d += addedPrice;
            }
            return d;
        }
    }
}
