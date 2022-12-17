using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class PetsConfigurations : IEntityTypeConfiguration<Pets>
    {
        public void Configure(EntityTypeBuilder<Pets> builder)
        {
            builder.ToTable("Pets");
            builder.HasKey(t => new { t.pet_Id });


            builder.HasOne(t => t.petCategories).WithMany(ur => ur.pets)
            .HasForeignKey(pc => pc.pet_CategoryId);
        }
    }
}
