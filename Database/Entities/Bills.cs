namespace Database.Entities
{
    public class Bills
    {
        public string bill_Id { get; set; }
        public Users Users { get; set; }
        public string bill_UserId { get; set; }
        public bool bill_StatusPayment { get; set; }
        public bool bill_StatusReviceOrder { get; set; }
        public double   bill_Total { get; set; }
        public DateTime bill_StartDateTime { get; set; }
        public bool bill_Cancel { get; set; }
        public bool bill_checkout { get; set; }

        public List<ProductInBill> productInBill { get; set; }
        public List<PettInBill> pettInBill { get; set; }
    }
}
