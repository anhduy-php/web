using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class ProductsConfigurations : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(t => new { t.product_Id });

            builder.HasOne(t => t.productCategories).WithMany(ur => ur.products)
            .HasForeignKey(pc => pc.product_CategoryId);
        }
    }
}
