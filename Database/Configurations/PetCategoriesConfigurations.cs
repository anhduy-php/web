using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class PetCategoriesConfigurations : IEntityTypeConfiguration<PetCategories>
    {
        public void Configure(EntityTypeBuilder<PetCategories> builder)
        {
            builder.ToTable("PetCategories");
            builder.HasKey(t => new { t.pc_Id });
        }
    }
}
