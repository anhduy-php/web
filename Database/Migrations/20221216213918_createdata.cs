using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class createdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "product_Img",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "pet_ImgUrl1",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "pet_ImgUrl2",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "pet_ImgUrl3",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "pet_ImgUrl4",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "PetCategories",
                columns: new[] { "pc_Id", "pc_Description", "pc_IsDelete", "pc_Name" },
                values: new object[,]
                {
                    { "14526a08-1aa3-4b71-a9d6-e1305dd60293", "Hound", false, "Hound" },
                    { "4ffcfeab-7d9d-4c9a-867a-56aada33d5eb", "Sheepdogs", false, "Sheepdogs" },
                    { "b309e402-f61f-478f-9cf9-a71b1d09d9be", " Sled dogs", false, " Sled dogs" },
                    { "ec4ac5f5-f450-4688-97ed-11a2dee12255", "Guard dog", false, "Guard dog" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "proc_Id", "proc_Description", "proc_IsDelete", "proc_Name" },
                values: new object[,]
                {
                    { "745d7d09-1a46-4c4b-9ced-443519e50b2d", "newCategories_Id1", false, "newCategories_Id1" },
                    { "9a980683-2470-4457-8ccc-14b3e5c0f29d", "newCategories_Id3", false, "newCategories_Id3" },
                    { "be12ceb7-6d18-41dc-a0f4-746ea177237c", "newCategories_Id2", false, "newCategories_Id2" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName", "isDelete" },
                values: new object[] { "d1cede10-3320-4ab4-980c-6b6dec513ec6", "5840055d-fdaf-4476-b0a1-cc6b23f77efb", "admin", "Roles", "ADMIN", "admin", false });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "isDelete" },
                values: new object[] { "1ae4d372-d977-44e0-878e-3ccbff40cac9", 0, "2b50de82-954e-42fd-912f-77a9a129f012", "Users", new DateTime(2022, 12, 17, 4, 39, 18, 592, DateTimeKind.Local).AddTicks(6565), "staff@gmail.com", true, "FirstName", "LastName", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEMeq6sm9Y+RqmDrSfPoF+0jSgWsyuYM21TdIk+uwbGIPm6tCFgWx/x2dv2UdMSp1wA==", null, false, "7a877bff-45b0-4b41-90e0-113c1cf8ccb4", false, "Admin", false });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "pet_Id", "pet_CategoryId", "pet_Description", "pet_ImgUrl1", "pet_ImgUrl2", "pet_ImgUrl3", "pet_ImgUrl4", "pet_IsDelete", "pet_Lifespan", "pet_Name", "pet_Origin", "pet_OrtherName", "pet_Price", "pet_Weight" },
                values: new object[,]
                {
                    { "12e44638-8cb3-466c-8b63-6ff0ac1803f8", "4ffcfeab-7d9d-4c9a-867a-56aada33d5eb", "Japan Dog", "image/giongcho/chonhatban.png", "", "", "image/cuncon/cuncon-pugdangyeu.jpg", false, 12.0, "Japan Dog", "Japan Dog", "Japan Dog", 100.0, 33.0 },
                    { "177eadba-125d-4d18-9ab0-51f0a0eff0b4", "b309e402-f61f-478f-9cf9-a71b1d09d9be", "Phoc squirrel dog", "image/giongcho/phoc-soc.jpg", "", "", "image/cuncon/cuncon-chuboss.jpg", false, 12.0, "Phoc squirrel dog", "Phoc squirrel dog", "Phoc squirrel dog", 100.0, 33.0 },
                    { "27c87c2e-3520-4444-adbe-94d29f9b7191", "b309e402-f61f-478f-9cf9-a71b1d09d9be", "Tibetan Clams", "image/giongcho/ngaottang.jpg", "", "", "image/cuncon/cuncon-golden1.jpg", false, 12.0, "Tibetan Clams", "Tibetan Clams", "Tibetan Clams", 100.0, 33.0 },
                    { "38193e75-1cba-4bd6-8ee9-ca74ca0f41aa", "ec4ac5f5-f450-4688-97ed-11a2dee12255", "SHIBA INU ", "image/giongcho/shiba.jpg", "", "", "image/cuncon/cuncon-phochuou.jpg", false, 12.0, "SHIBA INU ", "SHIBA INU ", "SHIBA INU ", 100.0, 33.0 },
                    { "3d8a9e2b-f45b-4522-a8ed-21346f1f867b", "ec4ac5f5-f450-4688-97ed-11a2dee12255", "BULLDOG", "image/giongcho/bulldog.jpg", "", "", "image/cuncon/cuncon-hoangtutuyetsamoyed.jpg", false, 12.0, "BULLDOG", "BULLDOG", "BULLDOG", 100.0, 32.0 },
                    { "41da7669-a1e1-44c7-9646-af396f2d1f45", "ec4ac5f5-f450-4688-97ed-11a2dee12255", "CHIHUAHUA", "image/giongcho/chihuahua.jpg", "", "", "image/cuncon/cuncon-phosocnhonhan.jpg", false, 12.0, "CHIHUAHUA", "CHIHUAHUA", "CHIHUAHUA", 100.0, 32.0 },
                    { "4296c53c-7461-4bf1-b030-7df7bc782b12", "ec4ac5f5-f450-4688-97ed-11a2dee12255", "ALASKA", "image/giongcho/alaska.jpg", "", "", "image/cuncon/cuncon-alaskamummim.jpg", false, 12.0, "ALASKA", "ALASKA", "ALASKA", 100.0, 23.0 },
                    { "48a47d36-4399-42a1-85ad-e1b0f73d8317", "ec4ac5f5-f450-4688-97ed-11a2dee12255", "BORDER COLLIE", "image/giongcho/BORDER-COLLIE.jpg", "", "", "image/cuncon/cuncon-phochuouden.jpg", false, 12.0, "BORDER COLLIE", "BORDER COLLIE", "BORDER COLLIE", 100.0, 32.0 },
                    { "6011c080-4b43-487f-becc-ea0c94d36b22", "4ffcfeab-7d9d-4c9a-867a-56aada33d5eb", "Dalmatian", "image/giongcho/cho-dom.jpg", "", "", "image/cuncon/cuncon-cocker.jpg", false, 12.0, "Dalmatian", "Dalmatian", "Dalmatian", 100.0, 33.0 },
                    { "7194233f-9938-4122-95b9-21331f5b5e77", "ec4ac5f5-f450-4688-97ed-11a2dee12255", "CHOW CHOW", "image/giongcho/chow-chow.jpg", "", "", "image/cuncon/cuncon-bordercolliemui2.jpg", false, 12.0, "CHOW CHOW", "CHOW CHOW", "CHOW CHOW", 100.0, 32.0 },
                    { "850e2f65-bb8f-424c-96f0-a9f268842e51", "ec4ac5f5-f450-4688-97ed-11a2dee12255", "GREAT DANE", "image/giongcho/great-dane.jpg", "", "", "image/cuncon/cuncon-lapxuongsocola.jpg", false, 12.0, "GREAT DANE", "GREAT DANE", "GREAT DANE", 100.0, 32.0 },
                    { "85439d8a-7fa2-47a0-ac68-be93e4de466f", "ec4ac5f5-f450-4688-97ed-11a2dee12255", "Pekingese", "image/giongcho/chobackinh.png", "", "", "image/cuncon/cuncon-chowchow.jpg", false, 12.0, "Pekingese", "Pekingese", "Pekingese", 100.0, 33.0 },
                    { "88194ebe-2907-49ac-ba55-62afab9521ba", "ec4ac5f5-f450-4688-97ed-11a2dee12255", "BULL France", "image/giongcho/bull-phap.jpg", "", "", "image/cuncon/cuncon-daingaohusky.jpg", false, 12.0, "BULL France", "BULL France", "BULL France", 100.0, 32.0 },
                    { "8cab3f8b-0f8b-4293-9144-474ada0166d9", "ec4ac5f5-f450-4688-97ed-11a2dee12255", "DOBERMANN", "image/giongcho/dobermann.jpg", "", "", "image/cuncon/cuncon-hotboylabrador.jpg", false, 12.0, "DOBERMANN", "DOBERMANN", "DOBERMANN", 100.0, 32.0 },
                    { "8f033b4a-0e71-4e8a-b0b7-702efd808922", "ec4ac5f5-f450-4688-97ed-11a2dee12255", "GOLDEN RETRIEVER", "image/giongcho/golden-retriever.jpg", "", "", "image/cuncon/cuncon-becgieduc.jpg", false, 12.0, "GOLDEN RETRIEVER", "GOLDEN RETRIEVER", "GOLDEN RETRIEVER", 100.0, 32.0 },
                    { "9668c416-811f-46c8-9c68-8e360802f9fd", "ec4ac5f5-f450-4688-97ed-11a2dee12255", "AKITA INU", "image/giongcho/akita-inu.jpg", "", "", "image/cuncon/cuncon-cooker.jpg", false, 10.0, "AKITA INU", "Japan", "AKITA INU", 100.0, 33.0 },
                    { "a4736e34-8ecc-496d-b3ce-e70ff47487ef", "b309e402-f61f-478f-9cf9-a71b1d09d9be", "Phu Quoc dogs", "image/giongcho/phu-quoc.jpg", "", "", "image/cuncon/cuncon-becgiehalan.jpg", false, 12.0, "Phu Quoc dogs", "Phu Quoc dogs", "Phu Quoc dogs", 100.0, 33.0 },
                    { "a5c3cd24-54d0-4187-af73-ae743d263048", "b309e402-f61f-478f-9cf9-a71b1d09d9be", "PITBULL", "image/giongcho/pitbull.jpg", "", "", "image/cuncon/cuncon-corgi.jpg", false, 12.0, "PITBULL", "PITBULL", "PITBULL", 100.0, 33.0 },
                    { "b69125ed-826b-4cff-b092-581d280b554e", "ec4ac5f5-f450-4688-97ed-11a2dee12255", "AKITA INU", "image/giongcho/akita-inu.jpg", "", "", "image/cuncon/cuncon-goldenretriever.jpg", false, 12.0, "AKITA INU", "AKITA INU", "AKITA INU", 100.0, 32.0 },
                    { "b84aec74-0d7e-40e8-93e7-c0682090c16e", "ec4ac5f5-f450-4688-97ed-11a2dee12255", "BECGIE Belgium (MALINOIS)", "image/giongcho/becgie-bi.jpg", "", "", "image/cuncon/cuncon-dobermann-2thang.jpg", false, 10.0, "BECGIE Belgium (MALINOIS)", "BECGIE Belgium (MALINOIS)", "BECGIE Belgium (MALINOIS)", 100.0, 33.0 },
                    { "bdf0f686-c7f7-400b-adb9-521128dbb30d", "4ffcfeab-7d9d-4c9a-867a-56aada33d5eb", "Deer Pug dog", "image/giongcho/phoc-huou.jpg", "", "", "image/cuncon/cuncon-poodlecuoituoi.jpg", false, 12.0, "Deer Pug dog", "Deer Pug dog", "Deer Pug dog", 100.0, 33.0 },
                    { "c2fd3022-670d-406b-a8fa-9537d66819df", "ec4ac5f5-f450-4688-97ed-11a2dee12255", "BĂC HÀ", "image/giongcho/chobacha.png", "", "", "image/cuncon/cuncon-bulldogmapmapa.jpg", false, 12.0, "BĂC HÀ", "BĂC HÀ", "BĂC HÀ", 100.0, 33.0 },
                    { "e21a5c1e-27cc-4ea9-badd-f08fcd2690e2", "ec4ac5f5-f450-4688-97ed-11a2dee12255", "BECGIE Germany", "image/giongcho/becgie-duc.jpg", "", "", "image/cuncon/cuncon-poodle-rautrang.jpg", false, 10.0, "BECGIE Germany", "BECGIE Germany", "BECGIE Germany", 100.0, 33.0 },
                    { "e39a3cf7-977c-4744-ac38-1471cf56aa93", "ec4ac5f5-f450-4688-97ed-11a2dee12255", "CORGI", "image/giongcho/corgy.jpg", "", "", "image/cuncon/cuncon-goodboyrottweiler.jpg", false, 12.0, "CORGI", "CORGI", "CORGI", 100.0, 32.0 },
                    { "f2049ece-6782-4d7a-9731-54462c5e2a79", "ec4ac5f5-f450-4688-97ed-11a2dee12255", "H'Mong Coc", "image/giongcho/mong-coc.jpg", "", "", "image/cuncon/cuncon-phochuoutimsen.jpg", false, 12.0, "H'Mong Coc", "H'Mong Coc", "H'Mong Coc", 100.0, 32.0 },
                    { "fc4e05ab-32f0-417b-9a03-ef4dc584b783", "ec4ac5f5-f450-4688-97ed-11a2dee12255", "Dalmatian", "image/giongcho/cho-dom.jpg", "", "", "image/cuncon/cuncon-cogaipitbull.jpg", false, 12.0, "Dalmatian", "Dalmatian", "Dalmatian", 100.0, 32.0 },
                    { "ff2cbae5-6b2f-4386-bafc-769ae9562997", "ec4ac5f5-f450-4688-97ed-11a2dee12255", "BULLY AMERICAN", "image/giongcho/bully-american.jpg", "", "", "image/cuncon/cuncon-bordercolliecongchua.jpg", false, 12.0, "BULLY AMERICAN", "BULLY AMERICAN", "BULLY AMERICAN", 100.0, 32.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "product_CategoryId", "product_Description", "product_Img", "product_IsDelete", "product_Name", "product_Price", "product_Rate", "product_ReProducePrice" },
                values: new object[,]
                {
                    { "138706ba-9eb8-4835-b855-4488b56344b6", "be12ceb7-6d18-41dc-a0f4-746ea177237c", "Anti-Tear Syrup", "image/phukien/phukien-sirochongchaynuocmat.png", false, "Anti-Tear Syrup", 10.0, 1.0, 1.0 },
                    { "16a5be4b-43b6-40ce-a969-83d5e4637224", "745d7d09-1a46-4c4b-9ced-443519e50b2d", "Drugs of Calcium", "image/phukien/phukien-thuoccanxi.png", false, "Drugs of Calcium", 10.0, 1.0, 1.0 },
                    { "20397d1b-3790-43c0-bfc6-63be7f6cc27b", "be12ceb7-6d18-41dc-a0f4-746ea177237c", "Balloon Toys", "image/phukien/phukien-bongbongdochoi.png", false, "Balloon Toys", 10.0, 1.0, 1.0 },
                    { "226b8393-9fdb-4e76-aa94-3fb1dad96d3d", "9a980683-2470-4457-8ccc-14b3e5c0f29d", "Bio Milk Powder For Dogs and Cats", "image/phukien/phukien-suabotchomeo.png", false, "Bio Milk Powder For Dogs and Cats", 10.0, 1.0, 1.0 },
                    { "2c8d51e1-9978-474f-a16e-e62af747c3c0", "9a980683-2470-4457-8ccc-14b3e5c0f29d", "Sleeky Multivitamin", "image/phukien/phukien-vitamintonghop.png", false, "Sleeky Multivitamin", 10.0, 1.0, 1.0 },
                    { "348c52de-016c-4d8e-80be-f5ee90c6bb62", "745d7d09-1a46-4c4b-9ced-443519e50b2d", "Transparent Backpack For Dogs and Cats", "image/phukien/phukien-balotrongsuot.png", false, "Transparent Backpack For Dogs and Cats", 10.0, 1.0, 1.0 },
                    { "3f72c5cb-ecb6-4af1-a6de-639753d225f9", "745d7d09-1a46-4c4b-9ced-443519e50b2d", "Royal Canin For Adult Dogs", "image/phukien/phukien-royal_truongthanh.png", false, "Royal Canin For Adult Dogs", 10.0, 1.0, 1.0 },
                    { "43ac8d92-5467-4afd-9d2b-e55541323b16", "745d7d09-1a46-4c4b-9ced-443519e50b2d", "Training Whistle", "image/phukien/phukien-coihuanluyen.png", false, "Training Whistle", 10.0, 1.0, 1.0 },
                    { "4d2f80e7-9b27-4aeb-af43-fc1110217691", "be12ceb7-6d18-41dc-a0f4-746ea177237c", "BLOOM SEXY Fragrance Bath Oil", "image/phukien/phukien-dautamFay.png", false, "BLOOM SEXY Fragrance Bath Oil", 10.0, 1.0, 1.0 },
                    { "4f2f01ff-ea94-47a4-927a-3981dff55b65", "be12ceb7-6d18-41dc-a0f4-746ea177237c", "Bow Bow Bra", "image/phukien/phukien-aongucnochuong.png", false, "Bow Bow Bra", 10.0, 1.0, 1.0 },
                    { "63e0c2cf-929e-4bac-9bc6-826cf1180ec5", "745d7d09-1a46-4c4b-9ced-443519e50b2d", "Princess Lace Scarf", "image/phukien/phukien-khanren.png", false, "Princess Lace Scarf", 10.0, 1.0, 1.0 },
                    { "6b2f7205-fdc3-40d7-8de8-0015c88383bf", "745d7d09-1a46-4c4b-9ced-443519e50b2d", "Bonus Cake Tablets", "image/phukien/phukien-banhthuong.png", false, "Bonus Cake Tablets", 10.0, 1.0, 1.0 },
                    { "6ef0f541-26e7-4ef4-8194-77d43ae79eca", "9a980683-2470-4457-8ccc-14b3e5c0f29d", "Canxi Nano", "image/phukien/phukien-canxinano.png", false, "Canxi Nano", 10.0, 1.0, 1.0 },
                    { "80eef068-c421-40ff-b720-79e8232f82a9", "be12ceb7-6d18-41dc-a0f4-746ea177237c", "BLOOM SEXY Fragrance Bath Oil", "image/phukien/phukien-dautamnuochoabloomsexy.png", false, "BLOOM SEXY Fragrance Bath Oil", 10.0, 1.0, 1.0 },
                    { "8629218b-65ca-436f-a105-31d7350d1e67", "9a980683-2470-4457-8ccc-14b3e5c0f29d", ">Nutri-Nutrition Gel", "image/phukien/phukien-gelddNutri.png", false, ">Nutri-Nutrition Gel", 10.0, 1.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "product_CategoryId", "product_Description", "product_Img", "product_IsDelete", "product_Name", "product_Price", "product_Rate", "product_ReProducePrice" },
                values: new object[,]
                {
                    { "afee0090-ac14-49cc-b9e3-4a2378aa7648", "be12ceb7-6d18-41dc-a0f4-746ea177237c", "Toys", "image/phukien/phukien-dochoi.png", false, "Toys", 10.0, 1.0, 1.0 },
                    { "b2bfefcc-e629-4ece-82b8-1693230c80ae", "be12ceb7-6d18-41dc-a0f4-746ea177237c", "Dog Fence", "image/phukien/phukien-raoquaycho.png", false, "Dog Fence", 10.0, 1.0, 1.0 },
                    { "be8ae287-0442-49e7-8023-3757d76e6483", "745d7d09-1a46-4c4b-9ced-443519e50b2d", "Pair of Bows", "image/phukien/phukien-capno.png", false, "Pair of Bows", 10.0, 1.0, 1.0 },
                    { "c42d6397-c4a2-4a01-8bc1-55ad38202071", "745d7d09-1a46-4c4b-9ced-443519e50b2d", "SmartHeart For Small Dogs", "image/phukien/phukien-SmartHeart.png", false, "SmartHeart For Small Dogs", 10.0, 1.0, 1.0 },
                    { "d1e56bd2-c1b3-4915-bb16-36dc434e5253", "745d7d09-1a46-4c4b-9ced-443519e50b2d", "Lamb Sticks", "image/phukien/phukien-thitcuuque.png", false, "Lamb Sticks", 10.0, 1.0, 1.0 },
                    { "e8e7bc6f-506e-46b0-a83a-b37a7631d1f2", "9a980683-2470-4457-8ccc-14b3e5c0f29d", "HANTOC Lice Spray", "image/phukien/phukien-xitveranHANTOC.png", false, "HANTOC Lice Spray", 10.0, 1.0, 1.0 },
                    { "feb14734-5dd5-40f5-a94a-45e28b32b176", "9a980683-2470-4457-8ccc-14b3e5c0f29d", "Lice Treatment Ring", "image/phukien/phukien-vongtriveran.png", false, "Lice Treatment Ring", 10.0, 1.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d1cede10-3320-4ab4-980c-6b6dec513ec6", "1ae4d372-d977-44e0-878e-3ccbff40cac9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "14526a08-1aa3-4b71-a9d6-e1305dd60293");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "12e44638-8cb3-466c-8b63-6ff0ac1803f8");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "177eadba-125d-4d18-9ab0-51f0a0eff0b4");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "27c87c2e-3520-4444-adbe-94d29f9b7191");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "38193e75-1cba-4bd6-8ee9-ca74ca0f41aa");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "3d8a9e2b-f45b-4522-a8ed-21346f1f867b");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "41da7669-a1e1-44c7-9646-af396f2d1f45");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "4296c53c-7461-4bf1-b030-7df7bc782b12");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "48a47d36-4399-42a1-85ad-e1b0f73d8317");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "6011c080-4b43-487f-becc-ea0c94d36b22");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "7194233f-9938-4122-95b9-21331f5b5e77");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "850e2f65-bb8f-424c-96f0-a9f268842e51");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "85439d8a-7fa2-47a0-ac68-be93e4de466f");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "88194ebe-2907-49ac-ba55-62afab9521ba");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "8cab3f8b-0f8b-4293-9144-474ada0166d9");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "8f033b4a-0e71-4e8a-b0b7-702efd808922");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "9668c416-811f-46c8-9c68-8e360802f9fd");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "a4736e34-8ecc-496d-b3ce-e70ff47487ef");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "a5c3cd24-54d0-4187-af73-ae743d263048");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "b69125ed-826b-4cff-b092-581d280b554e");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "b84aec74-0d7e-40e8-93e7-c0682090c16e");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "bdf0f686-c7f7-400b-adb9-521128dbb30d");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "c2fd3022-670d-406b-a8fa-9537d66819df");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "e21a5c1e-27cc-4ea9-badd-f08fcd2690e2");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "e39a3cf7-977c-4744-ac38-1471cf56aa93");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "f2049ece-6782-4d7a-9731-54462c5e2a79");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "fc4e05ab-32f0-417b-9a03-ef4dc584b783");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "ff2cbae5-6b2f-4386-bafc-769ae9562997");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "138706ba-9eb8-4835-b855-4488b56344b6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "16a5be4b-43b6-40ce-a969-83d5e4637224");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "20397d1b-3790-43c0-bfc6-63be7f6cc27b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "226b8393-9fdb-4e76-aa94-3fb1dad96d3d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "2c8d51e1-9978-474f-a16e-e62af747c3c0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "348c52de-016c-4d8e-80be-f5ee90c6bb62");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "3f72c5cb-ecb6-4af1-a6de-639753d225f9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "43ac8d92-5467-4afd-9d2b-e55541323b16");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "4d2f80e7-9b27-4aeb-af43-fc1110217691");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "4f2f01ff-ea94-47a4-927a-3981dff55b65");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "63e0c2cf-929e-4bac-9bc6-826cf1180ec5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "6b2f7205-fdc3-40d7-8de8-0015c88383bf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "6ef0f541-26e7-4ef4-8194-77d43ae79eca");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "80eef068-c421-40ff-b720-79e8232f82a9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "8629218b-65ca-436f-a105-31d7350d1e67");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "afee0090-ac14-49cc-b9e3-4a2378aa7648");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "b2bfefcc-e629-4ece-82b8-1693230c80ae");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "be8ae287-0442-49e7-8023-3757d76e6483");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "c42d6397-c4a2-4a01-8bc1-55ad38202071");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "d1e56bd2-c1b3-4915-bb16-36dc434e5253");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "e8e7bc6f-506e-46b0-a83a-b37a7631d1f2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "feb14734-5dd5-40f5-a94a-45e28b32b176");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d1cede10-3320-4ab4-980c-6b6dec513ec6", "1ae4d372-d977-44e0-878e-3ccbff40cac9" });

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "4ffcfeab-7d9d-4c9a-867a-56aada33d5eb");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "b309e402-f61f-478f-9cf9-a71b1d09d9be");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "ec4ac5f5-f450-4688-97ed-11a2dee12255");

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "proc_Id",
                keyValue: "745d7d09-1a46-4c4b-9ced-443519e50b2d");

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "proc_Id",
                keyValue: "9a980683-2470-4457-8ccc-14b3e5c0f29d");

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "proc_Id",
                keyValue: "be12ceb7-6d18-41dc-a0f4-746ea177237c");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d1cede10-3320-4ab4-980c-6b6dec513ec6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1ae4d372-d977-44e0-878e-3ccbff40cac9");

            migrationBuilder.DropColumn(
                name: "product_Img",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "pet_ImgUrl1",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "pet_ImgUrl2",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "pet_ImgUrl3",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "pet_ImgUrl4",
                table: "Pets");
        }
    }
}
