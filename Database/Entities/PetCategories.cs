namespace Database.Entities
{
    public class PetCategories
    {
        public string pc_Id { get; set; }
        public string pc_Name { get; set; }
        public string pc_Description { get; set; }
        public bool pc_IsDelete { get; set; }

        public List<Pets> pets { get; set; }
    }
}
