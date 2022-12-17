using Database.Configurations;
using Database.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Database.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder => {
            builder
                // .AddFilter (DbLoggerCategory.Database.Command.Name, LogLevel.Warning)
                // .AddFilter (DbLoggerCategory.Query.Name, LogLevel.Debug)
                .AddConsole();
        });

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //// Bỏ tiền tố AspNet của các bảng: mặc định các bảng trong IdentityDbContext có
            //// tên với tiền tố AspNet như: AspNetUserRoles, AspNetUser ...
            //// Đoạn mã sau chạy khi khởi tạo DbContext, tạo database sẽ loại bỏ tiền tố đó
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }



            builder.ApplyConfiguration(new BillsConfigurations());
            builder.ApplyConfiguration(new IntroducePageConfigurations());
            builder.ApplyConfiguration(new PetCategoriesConfigurations());
            builder.ApplyConfiguration(new PetsConfigurations());
            builder.ApplyConfiguration(new PettInBillConfigurations());
            builder.ApplyConfiguration(new ProductCategoriesConfigurations());
            builder.ApplyConfiguration(new ProductInBillConfigurations());
            builder.ApplyConfiguration(new ProductsConfigurations());
            builder.ApplyConfiguration(new RolesConfigurations());
            builder.ApplyConfiguration(new UserContactConfigurations());
            builder.ApplyConfiguration(new UsersConfigurations());

            builder.Seed();


        }
        public DbSet<Bills> bills { set; get; }
        public DbSet<IntroducePage> introducePage { set; get; }
        public DbSet<PetCategories> petCategories { set; get; }
        public DbSet<Pets> pets { set; get; }
        public DbSet<PettInBill> pettInBill { set; get; }
        public DbSet<ProductCategories> productCategories { set; get; }
        public DbSet<ProductInBill> productInBill { set; get; }
        public DbSet<Products> products { set; get; }
        public DbSet<Roles> roles { set; get; }
        public DbSet<UserContact> userContact { set; get; }
        public DbSet<Users> users { set; get; }
    }
}