namespace Database.Entities
{
    public class ProductInBill
    {
        public string proib_ProductId { get; set; } //
        public Products products { get; set; }
        public string proib_BillId { get; set; } //
        public Bills bills { get; set; }
        public double proib_Quantity { get; set; } 
       

        
    }
}
