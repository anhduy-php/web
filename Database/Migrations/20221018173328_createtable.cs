using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class createtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    bill_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    bill_UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bill_StatusPayment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bill_StatusReviceOrder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bill_Total = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bill_StartDateTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bill_Cancel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.bill_Id);
                });

            migrationBuilder.CreateTable(
                name: "PetCategories",
                columns: table => new
                {
                    pc_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pc_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pc_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pc_IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetCategories", x => x.pc_Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    proc_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    proc_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    proc_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    proc_IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.proc_Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isDelete = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDelete = table.Column<bool>(type: "bit", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    pet_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pet_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pet_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pet_Price = table.Column<double>(type: "float", nullable: false),
                    pet_OrtherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pet_Origin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pet_CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pet_Weight = table.Column<double>(type: "float", nullable: false),
                    pet_Lifespan = table.Column<double>(type: "float", nullable: false),
                    pet_IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.pet_Id);
                    table.ForeignKey(
                        name: "FK_Pets_PetCategories_pet_CategoryId",
                        column: x => x.pet_CategoryId,
                        principalTable: "PetCategories",
                        principalColumn: "pc_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    product_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    product_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_Price = table.Column<double>(type: "float", nullable: false),
                    product_Rate = table.Column<double>(type: "float", nullable: false),
                    product_ReProducePrice = table.Column<double>(type: "float", nullable: false),
                    product_CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    product_IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.product_Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_product_CategoryId",
                        column: x => x.product_CategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "proc_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IntroducePage",
                columns: table => new
                {
                    introduce_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    introduce_Zalo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    introduce_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    introduce_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    introduce_Address1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    introduce_Address2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    introduce_Address3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    introduce_Map1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    introduce_Map2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    introduce_Map3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    introduce_UserCreate = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntroducePage", x => x.introduce_Id);
                    table.ForeignKey(
                        name: "FK_IntroducePage_Users_introduce_UserCreate",
                        column: x => x.introduce_UserCreate,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserContact",
                columns: table => new
                {
                    uc_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    uc_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uc_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uc_Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uc_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uc_IsDelete = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uc_UserCreate = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserContact", x => x.uc_Id);
                    table.ForeignKey(
                        name: "FK_UserContact_Users_uc_UserCreate",
                        column: x => x.uc_UserCreate,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PettInBill",
                columns: table => new
                {
                    pib_PetId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pib_BillId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pib_Quantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pib_Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PettInBill", x => new { x.pib_PetId, x.pib_BillId });
                    table.ForeignKey(
                        name: "FK_PettInBill_Bills_pib_BillId",
                        column: x => x.pib_BillId,
                        principalTable: "Bills",
                        principalColumn: "bill_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PettInBill_Pets_pib_PetId",
                        column: x => x.pib_PetId,
                        principalTable: "Pets",
                        principalColumn: "pet_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInBill",
                columns: table => new
                {
                    proib_ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    proib_BillId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    proib_Quantity = table.Column<double>(type: "float", nullable: false),
                    proib_Price = table.Column<double>(type: "float", nullable: false),
                    proib_IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInBill", x => new { x.proib_ProductId, x.proib_BillId });
                    table.ForeignKey(
                        name: "FK_ProductInBill_Bills_proib_BillId",
                        column: x => x.proib_BillId,
                        principalTable: "Bills",
                        principalColumn: "bill_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInBill_Products_proib_ProductId",
                        column: x => x.proib_ProductId,
                        principalTable: "Products",
                        principalColumn: "product_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IntroducePage_introduce_UserCreate",
                table: "IntroducePage",
                column: "introduce_UserCreate");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_pet_CategoryId",
                table: "Pets",
                column: "pet_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PettInBill_pib_BillId",
                table: "PettInBill",
                column: "pib_BillId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInBill_proib_BillId",
                table: "ProductInBill",
                column: "proib_BillId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_product_CategoryId",
                table: "Products",
                column: "product_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserContact_uc_UserCreate",
                table: "UserContact",
                column: "uc_UserCreate");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IntroducePage");

            migrationBuilder.DropTable(
                name: "PettInBill");

            migrationBuilder.DropTable(
                name: "ProductInBill");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserContact");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "PetCategories");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
