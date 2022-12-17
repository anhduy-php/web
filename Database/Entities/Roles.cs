using Microsoft.AspNetCore.Identity;

namespace Database.Entities
{
    public class Roles : IdentityRole
    {
        public string Description { set; get; }

        public bool isDelete { set; get; }
    }
}
