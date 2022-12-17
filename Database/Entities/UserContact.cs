namespace Database.Entities
{
    public class UserContact
    {
        public string uc_Id { set; get; }
        public string uc_Name { set; get; }
        public string uc_Email { set; get; }
        public string uc_Content { set; get; }
        public string uc_Phone { set; get; }
        public string uc_IsDelete { set; get; }
        public string uc_UserCreate { set; get; }
        public Users users { get; set; }
    }
}
