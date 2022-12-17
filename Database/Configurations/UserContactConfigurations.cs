using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class UserContactConfigurations : IEntityTypeConfiguration<UserContact>
    {
        public void Configure(EntityTypeBuilder<UserContact> builder)
        {
            builder.ToTable("UserContact");
            builder.HasKey(t => new { t.uc_Id });


            builder.HasOne(t => t.users).WithMany(ur => ur.userContact)
            .HasForeignKey(pc => pc.uc_UserCreate);
        }
    }
}
