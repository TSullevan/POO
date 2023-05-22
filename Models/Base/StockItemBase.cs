namespace POO.Models.Base
{
    internal abstract class StockItemBase : ItemBase
    {
        public int StockLimit { get; set; }

        public StockItemBase()
        {
            StockLimit = default;
        }
    }
}
