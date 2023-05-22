namespace POO.Models
{
    internal class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Stock Stock { get; set; }

        public Shop(Stock stock)
        {
            Stock = stock;
        }

        public void ShowStock()
        {
            Stock.PrintStock();
        }

        public void DoShopping(Customer customer)
        {
            foreach (ShopItem desiredShopItem in customer.ShoppingList)
            {
                Product desiredProduct = desiredShopItem.Product;
                int desiredQuantity = desiredShopItem.Quantity;

                ProductItem? stockedProductItem = Stock.GetProductItemByProductId(desiredProduct.Id);

                if (stockedProductItem == null)
                {
                    Console.WriteLine($"{desiredProduct.Name} indisponível!");
                    continue;
                }
                if (desiredQuantity > stockedProductItem.Quantity)
                {
                    Console.WriteLine($"{desiredProduct.Name} só teremos {stockedProductItem.Quantity}!");
                    continue;
                }

                Stock.RemoveProductById(desiredProduct.Id, desiredQuantity);
                customer.AddProductToBag(desiredProduct);
            }
        }
    }
}
