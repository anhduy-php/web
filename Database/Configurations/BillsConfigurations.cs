using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class BillsConfigurations : IEntityTypeConfiguration<Bills>
    {
        public void Configure(EntityTypeBuilder<Bills> builder)
        {
            builder.ToTable("Bills");
            builder.HasKey(t => new { t.bill_Id });

            builder.HasOne(t => t.Users).WithMany(ur => ur.bill)
            .HasForeignKey(pc => pc.bill_UserId);
        }
    }
}
