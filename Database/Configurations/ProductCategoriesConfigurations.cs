using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class ProductCategoriesConfigurations : IEntityTypeConfiguration<ProductCategories>
    {
        public void Configure(EntityTypeBuilder<ProductCategories> builder)
        {
            builder.ToTable("ProductCategories");
            builder.HasKey(t => new { t.proc_Id });



        }
    }
}
