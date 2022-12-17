using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class ProductInBillConfigurations : IEntityTypeConfiguration<ProductInBill>
    {
        public void Configure(EntityTypeBuilder<ProductInBill> builder)
        {
            builder.ToTable("ProductInBill");
            builder.HasKey(t => new { t.proib_ProductId, t.proib_BillId });

            builder.HasOne(t => t.products).WithMany(ur => ur.productInBill)
            .HasForeignKey(pc => pc.proib_ProductId);

            builder.HasOne(t => t.bills).WithMany(ur => ur.productInBill)
            .HasForeignKey(pc => pc.proib_BillId);
        }
    }
}
