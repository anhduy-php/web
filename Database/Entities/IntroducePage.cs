namespace Database.Entities
{
    public class IntroducePage
    {
        public string introduce_Id { get; set; }
        public string introduce_Zalo { get; set; }
        public string introduce_Phone { get; set; }
        public string introduce_Email { get; set; }
        public string introduce_Address1 { get; set; }
        public string introduce_Address2 { get; set; }
        public string introduce_Address3 { get; set; }
        public string introduce_Map1 { get; set; }
        public string introduce_Map2 { get; set; }
        public string introduce_Map3 { get; set; }
        public string introduce_UserCreate { get; set; }
        public Users users { get; set; }
    }
}
