namespace Admin.Controllers
{
    internal class BillsModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Email { get; set; }
        public bool IsPayment { get; set; }
        public bool IsReceive { get; set; }
        public DateTime Created { get; set; }
    }
}