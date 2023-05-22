using POO.Models.Base;

namespace POO.Models
{
    internal class ProductItem : StockItemBase
    {
        public Product Product { get; set; }

        public ProductItem(Product product)
        {
            Product = product;
        }
    }
}
