namespace POO.Models
{
    internal class Product
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public decimal Value { get; set; }

        public Product(string name)
        {
            int newId = (int)DateTime.Now.Ticks % 100000;
            Id = newId < 0 ? newId * -1 : newId;
            Name = name;
        }
    }
}
