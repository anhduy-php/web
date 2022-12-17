namespace Database.Entities
{
    public class Products
    {
        public string product_Id { get; set; }
        public string product_Name { get; set; }
        public string product_Description { get; set; }
        public double product_Price { get; set; }
        public double product_Rate { get; set; }
        public double product_ReProducePrice { get; set; }
        public string product_Img { get; set; }
        public string product_CategoryId { get; set; } //
        public ProductCategories productCategories { get; set; }
        public bool product_IsDelete { get; set; }

        public List<ProductInBill> productInBill { get; set; }
    }
}
