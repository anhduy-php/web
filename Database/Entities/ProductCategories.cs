namespace Database.Entities
{
    public class ProductCategories
    {
        public string proc_Id { get; set; }
        public string proc_Name { get; set; }
        public string proc_Description { get; set; }
        public bool proc_IsDelete { get; set; }

        public List<Products> products { get; set; }

    }
}
