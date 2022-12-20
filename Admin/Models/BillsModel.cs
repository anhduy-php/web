namespace Admin.Models
{
    public class BillsModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Double Price { get; set; }
        public string Email { get; set; }
        public bool IsPayment { get; set; }
        public bool IsReceive { get; set; }
        public DateTime Created { get; set; }

    }
}
