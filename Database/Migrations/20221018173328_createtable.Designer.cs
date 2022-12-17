﻿// <auto-generated />
using System;
using Database.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Database.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221018173328_createtable")]
    partial class createtable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Database.Entities.Bills", b =>
                {
                    b.Property<string>("bill_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("bill_Cancel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bill_StartDateTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bill_StatusPayment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bill_StatusReviceOrder")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bill_Total")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bill_UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("bill_Id");

                    b.ToTable("Bills", (string)null);
                });

            modelBuilder.Entity("Database.Entities.IntroducePage", b =>
                {
                    b.Property<string>("introduce_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("introduce_Address1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("introduce_Address2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("introduce_Address3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("introduce_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("introduce_Map1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("introduce_Map2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("introduce_Map3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("introduce_Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("introduce_UserCreate")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("introduce_Zalo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("introduce_Id");

                    b.HasIndex("introduce_UserCreate");

                    b.ToTable("IntroducePage", (string)null);
                });

            modelBuilder.Entity("Database.Entities.PetCategories", b =>
                {
                    b.Property<string>("pc_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("pc_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("pc_IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("pc_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("pc_Id");

                    b.ToTable("PetCategories", (string)null);
                });

            modelBuilder.Entity("Database.Entities.Pets", b =>
                {
                    b.Property<string>("pet_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("pet_CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("pet_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("pet_IsDelete")
                        .HasColumnType("bit");

                    b.Property<double>("pet_Lifespan")
                        .HasColumnType("float");

                    b.Property<string>("pet_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_Origin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_OrtherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("pet_Price")
                        .HasColumnType("float");

                    b.Property<double>("pet_Weight")
                        .HasColumnType("float");

                    b.HasKey("pet_Id");

                    b.HasIndex("pet_CategoryId");

                    b.ToTable("Pets", (string)null);
                });

            modelBuilder.Entity("Database.Entities.PettInBill", b =>
                {
                    b.Property<string>("pib_PetId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("pib_BillId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("pib_Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pib_Quantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("pib_PetId", "pib_BillId");

                    b.HasIndex("pib_BillId");

                    b.ToTable("PettInBill", (string)null);
                });

            modelBuilder.Entity("Database.Entities.ProductCategories", b =>
                {
                    b.Property<string>("proc_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("proc_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("proc_IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("proc_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("proc_Id");

                    b.ToTable("ProductCategories", (string)null);
                });

            modelBuilder.Entity("Database.Entities.ProductInBill", b =>
                {
                    b.Property<string>("proib_ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("proib_BillId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("proib_IsDelete")
                        .HasColumnType("bit");

                    b.Property<double>("proib_Price")
                        .HasColumnType("float");

                    b.Property<double>("proib_Quantity")
                        .HasColumnType("float");

                    b.HasKey("proib_ProductId", "proib_BillId");

                    b.HasIndex("proib_BillId");

                    b.ToTable("ProductInBill", (string)null);
                });

            modelBuilder.Entity("Database.Entities.Products", b =>
                {
                    b.Property<string>("product_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("product_CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("product_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("product_IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("product_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("product_Price")
                        .HasColumnType("float");

                    b.Property<double>("product_Rate")
                        .HasColumnType("float");

                    b.Property<double>("product_ReProducePrice")
                        .HasColumnType("float");

                    b.HasKey("product_Id");

                    b.HasIndex("product_CategoryId");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("Database.Entities.UserContact", b =>
                {
                    b.Property<string>("uc_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("uc_Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("uc_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("uc_IsDelete")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("uc_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("uc_Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("uc_UserCreate")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("uc_Id");

                    b.HasIndex("uc_UserCreate");

                    b.ToTable("UserContact", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("Database.Entities.Roles", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.ToTable("Roles");

                    b.HasDiscriminator().HasValue("Roles");
                });

            modelBuilder.Entity("Database.Entities.Users", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.ToTable("Users");

                    b.HasDiscriminator().HasValue("Users");
                });

            modelBuilder.Entity("Database.Entities.IntroducePage", b =>
                {
                    b.HasOne("Database.Entities.Users", "users")
                        .WithMany("introducePage")
                        .HasForeignKey("introduce_UserCreate")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("users");
                });

            modelBuilder.Entity("Database.Entities.Pets", b =>
                {
                    b.HasOne("Database.Entities.PetCategories", "petCategories")
                        .WithMany("pets")
                        .HasForeignKey("pet_CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("petCategories");
                });

            modelBuilder.Entity("Database.Entities.PettInBill", b =>
                {
                    b.HasOne("Database.Entities.Bills", "bills")
                        .WithMany("pettInBill")
                        .HasForeignKey("pib_BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Database.Entities.Pets", "pets")
                        .WithMany("pettInBill")
                        .HasForeignKey("pib_PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bills");

                    b.Navigation("pets");
                });

            modelBuilder.Entity("Database.Entities.ProductInBill", b =>
                {
                    b.HasOne("Database.Entities.Bills", "bills")
                        .WithMany("productInBill")
                        .HasForeignKey("proib_BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Database.Entities.Products", "products")
                        .WithMany("productInBill")
                        .HasForeignKey("proib_ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bills");

                    b.Navigation("products");
                });

            modelBuilder.Entity("Database.Entities.Products", b =>
                {
                    b.HasOne("Database.Entities.ProductCategories", "productCategories")
                        .WithMany("products")
                        .HasForeignKey("product_CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("productCategories");
                });

            modelBuilder.Entity("Database.Entities.UserContact", b =>
                {
                    b.HasOne("Database.Entities.Users", "users")
                        .WithMany("userContact")
                        .HasForeignKey("uc_UserCreate")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Database.Entities.Bills", b =>
                {
                    b.Navigation("pettInBill");

                    b.Navigation("productInBill");
                });

            modelBuilder.Entity("Database.Entities.PetCategories", b =>
                {
                    b.Navigation("pets");
                });

            modelBuilder.Entity("Database.Entities.Pets", b =>
                {
                    b.Navigation("pettInBill");
                });

            modelBuilder.Entity("Database.Entities.ProductCategories", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("Database.Entities.Products", b =>
                {
                    b.Navigation("productInBill");
                });

            modelBuilder.Entity("Database.Entities.Users", b =>
                {
                    b.Navigation("introducePage");

                    b.Navigation("userContact");
                });
#pragma warning restore 612, 618
        }
    }
}
