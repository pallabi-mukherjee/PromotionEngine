namespace PromotionEngine
{
    public class Product
    {
        public string ProductId { get; set; }
        public double ProductPrice { get; set; }

        public Product(string id)
        {
            ProductId = id;
            ProductPrice = id switch
            {
                "A" => 50,
                "B" => 30,
                "C" => 20,
                "D" => 15,
                _ => ProductPrice
            };
        }
    }
}
