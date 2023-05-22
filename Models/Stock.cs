using System.Text;

namespace POO.Models
{
    internal class Stock
    {
        public List<ProductItem> ProductItems { get; set; }

        public Stock()
        {
            ProductItems = new List<ProductItem>();
        }

        public void PrintStock()
        {
            StringBuilder text = new();
            foreach (ProductItem productItem in ProductItems)
            {
                Product product = productItem.Product;
                text.AppendLine($"Id: {product.Id}");
                text.AppendLine($"Nome: {product.Name}");
                text.AppendLine($"Quantidade: {productItem.Quantity}");
                text.AppendLine("-----------------------------------");
            }
            Console.WriteLine(text.ToString());
        }

        public bool IsThereAProductById(int productId)
        {
            return ProductItems.Exists(_productItem => _productItem.Product.Id == productId);
        }

        public bool AddNewProduct(Product product, int quantity, int stockLimit)
        {
            bool hasProduct = IsThereAProductById(product.Id);
            if (hasProduct)
            {
                return false;
            }
            if (quantity > stockLimit || quantity < 0)
            {
                return false;
            }
            ProductItem productItem = new(product);
            productItem.Quantity = quantity;
            ProductItems.Add(productItem);
            return true;
        }

        public bool AddNewProductItems(List<ProductItem> productItems)
        {
            foreach(ProductItem productItem in productItems)
            {
                AddNewProduct(productItem.Product, productItem.Quantity, productItem.StockLimit);
            }
            return true;
        }

        public bool AddProductById(int productId, int quantity)
        {
            ProductItem? productItem = GetProductItemByProductId(productId);
            if (productItem == null || quantity <= 0)
            {
                return false;
            }
            int newQuantity = productItem.Quantity + quantity;
            if (newQuantity > productItem.StockLimit)
            {
                return false;
            }
            productItem.Quantity = newQuantity;
            return true;
        }

        public bool RemoveProductById(int productId, int quantity)
        {
            ProductItem? productItem = GetProductItemByProductId(productId);
            if (productItem == null || quantity <= 0)
            {
                return false;
            }
            int newQuantity = productItem.Quantity - quantity;
            if (newQuantity < 0)
            {
                return false;
            }
            productItem.Quantity = newQuantity;
            return true;
        }

        public ProductItem? GetProductItemByProductId(int productId)
        {
            if (!IsThereAProductById(productId))
            {
                return null;
            }
            return ProductItems.Find(_productItem => _productItem.Product.Id == productId);
        }
    }
}
