namespace POO.Models.Base
{
    internal abstract class ItemBase
    {
        public int Quantity { get; set; }

        public ItemBase()
        {
            Quantity = default;
        }
    }
}
