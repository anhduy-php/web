using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class PettInBillConfigurations : IEntityTypeConfiguration<PettInBill>
    {
        public void Configure(EntityTypeBuilder<PettInBill> builder)
        {
            builder.ToTable("PettInBill");
            builder.HasKey(t => new { t.pib_PetId, t.pib_BillId });

            builder.HasOne(t => t.pets).WithMany(ur => ur.pettInBill)
            .HasForeignKey(pc => pc.pib_PetId);

            builder.HasOne(t => t.bills).WithMany(ur => ur.pettInBill)
            .HasForeignKey(pc => pc.pib_BillId);
        }
    }
}
