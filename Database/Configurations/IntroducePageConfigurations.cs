using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class IntroducePageConfigurations : IEntityTypeConfiguration<IntroducePage>
    {
        public void Configure(EntityTypeBuilder<IntroducePage> builder)
        {
            builder.ToTable("IntroducePage");
            builder.HasKey(t => new { t.introduce_Id });

            builder.HasOne(t => t.users).WithMany(ur => ur.introducePage)
            .HasForeignKey(pc => pc.introduce_UserCreate);
        }
    }
}
