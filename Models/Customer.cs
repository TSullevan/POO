namespace POO.Models
{
    internal class Customer : Person
    {
        public int Id { get; set; }
        public List<ShopItem> ShoppingList { get; set; }
        public List<Product> Bag { get; set; }

        public Customer(string name, DateTime birthday) : base(name, birthday)
        {
            int newId = (int)DateTime.Now.Ticks % 100000;
            Id = newId < 0 ? newId * -1 : newId;
            Bag = new List<Product>();
            ShoppingList = new List<ShopItem>();
        }

        public void AddProductToBag(Product product)
        {
            Bag.Add(product);
        }
    }
}
