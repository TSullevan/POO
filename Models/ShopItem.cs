using POO.Models.Base;

namespace POO.Models
{
    internal class ShopItem : ItemBase
    {
        public Product Product { get; set; }

        public ShopItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
