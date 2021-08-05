namespace Lib
{
    public class ProductDetailsModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Unit { get; set; } = "pc";
        public long Price { get; set; }
        public int ParentGroup { get; set; }
        public int Quantity { get; set; }
        public long Total { get; set; }
    }
}
