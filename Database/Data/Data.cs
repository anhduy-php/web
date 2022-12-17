using Database.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Database.Data
{
    public static class Data
    {
        public static void Seed(this ModelBuilder builder)
        {
            string newPc_Id1 = Guid.NewGuid().ToString();
            string newPc_Id2 = Guid.NewGuid().ToString();
            string newPc_Id3 = Guid.NewGuid().ToString();
            string newPc_Id4 = Guid.NewGuid().ToString();
            string newPc_Id5 = Guid.NewGuid().ToString();

            // Table Pet Categories
            builder.Entity<PetCategories>().HasData(
                new PetCategories()
                {
                    pc_Id = newPc_Id1,
                    pc_Name = "Guard dog",
                    pc_Description = "Guard dog",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id2,
                    pc_Name = "Sheepdogs",
                    pc_Description = "Sheepdogs",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id3,
                    pc_Name = " Sled dogs",
                    pc_Description = " Sled dogs",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id4,
                    pc_Name = "Hound",
                    pc_Description = "Hound",
                    pc_IsDelete = false
                }
                );



            ////Table Pets
            builder.Entity<Pets>().HasData(
                        new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "AKITA INU",
                            pet_Description = "AKITA INU",
                            pet_Price = 100,
                            pet_OrtherName = "AKITA INU",
                            pet_Origin = "Japan",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 33,
                            pet_Lifespan = 10,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/akita-inu.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-cooker.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "BECGIE Belgium (MALINOIS)",
                            pet_Description = "BECGIE Belgium (MALINOIS)",
                            pet_Price = 100,
                            pet_OrtherName = "BECGIE Belgium (MALINOIS)",
                            pet_Origin = "BECGIE Belgium (MALINOIS)",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 33,
                            pet_Lifespan = 10,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/becgie-bi.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-dobermann-2thang.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "BECGIE Germany",
                            pet_Description = "BECGIE Germany",
                            pet_Price = 100,
                            pet_OrtherName = "BECGIE Germany",
                            pet_Origin = "BECGIE Germany",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 33,
                            pet_Lifespan = 10,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/becgie-duc.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-poodle-rautrang.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "BORDER COLLIE",
                            pet_Description = "BORDER COLLIE",
                            pet_Price = 100,
                            pet_OrtherName = "BORDER COLLIE",
                            pet_Origin = "BORDER COLLIE",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 32,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/BORDER-COLLIE.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-phochuouden.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "BULL France",
                            pet_Description = "BULL France",
                            pet_Price = 100,
                            pet_OrtherName = "BULL France",
                            pet_Origin = "BULL France",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 32,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/bull-phap.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-daingaohusky.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "BULLDOG",
                            pet_Description = "BULLDOG",
                            pet_Price = 100,
                            pet_OrtherName = "BULLDOG",
                            pet_Origin = "BULLDOG",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 32,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/bulldog.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-hoangtutuyetsamoyed.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "BULLY AMERICAN",
                            pet_Description = "BULLY AMERICAN",
                            pet_Price = 100,
                            pet_OrtherName = "BULLY AMERICAN",
                            pet_Origin = "BULLY AMERICAN",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 32,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/bully-american.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-bordercolliecongchua.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "CHIHUAHUA",
                            pet_Description = "CHIHUAHUA",
                            pet_Price = 100,
                            pet_OrtherName = "CHIHUAHUA",
                            pet_Origin = "CHIHUAHUA",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 32,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/chihuahua.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-phosocnhonhan.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "Dalmatian",
                            pet_Description = "Dalmatian",
                            pet_Price = 100,
                            pet_OrtherName = "Dalmatian",
                            pet_Origin = "Dalmatian",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 32,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/cho-dom.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-cogaipitbull.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "CHOW CHOW",
                            pet_Description = "CHOW CHOW",
                            pet_Price = 100,
                            pet_OrtherName = "CHOW CHOW",
                            pet_Origin = "CHOW CHOW",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 32,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/chow-chow.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-bordercolliemui2.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "CORGI",
                            pet_Description = "CORGI",
                            pet_Price = 100,
                            pet_OrtherName = "CORGI",
                            pet_Origin = "CORGI",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 32,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/corgy.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-goodboyrottweiler.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "DOBERMANN",
                            pet_Description = "DOBERMANN",
                            pet_Price = 100,
                            pet_OrtherName = "DOBERMANN",
                            pet_Origin = "DOBERMANN",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 32,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/dobermann.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-hotboylabrador.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "GOLDEN RETRIEVER",
                            pet_Description = "GOLDEN RETRIEVER",
                            pet_Price = 100,
                            pet_OrtherName = "GOLDEN RETRIEVER",
                            pet_Origin = "GOLDEN RETRIEVER",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 32,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/golden-retriever.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-becgieduc.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "GREAT DANE",
                            pet_Description = "GREAT DANE",
                            pet_Price = 100,
                            pet_OrtherName = "GREAT DANE",
                            pet_Origin = "GREAT DANE",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 32,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/great-dane.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-lapxuongsocola.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "H'Mong Coc",
                            pet_Description = "H'Mong Coc",
                            pet_Price = 100,
                            pet_OrtherName = "H'Mong Coc",
                            pet_Origin = "H'Mong Coc",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 32,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/mong-coc.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-phochuoutimsen.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "AKITA INU",
                            pet_Description = "AKITA INU",
                            pet_Price = 100,
                            pet_OrtherName = "AKITA INU",
                            pet_Origin = "AKITA INU",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 32,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/akita-inu.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-goldenretriever.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "ALASKA",
                            pet_Description = "ALASKA",
                            pet_Price = 100,
                            pet_OrtherName = "ALASKA",
                            pet_Origin = "ALASKA",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 23,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/alaska.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-alaskamummim.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "BĂC HÀ",
                            pet_Description = "BĂC HÀ",
                            pet_Price = 100,
                            pet_OrtherName = "BĂC HÀ",
                            pet_Origin = "BĂC HÀ",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 33,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/chobacha.png",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-bulldogmapmapa.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "Pekingese",
                            pet_Description = "Pekingese",
                            pet_Price = 100,
                            pet_OrtherName = "Pekingese",
                            pet_Origin = "Pekingese",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 33,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/chobackinh.png",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-chowchow.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "Dalmatian",
                            pet_Description = "Dalmatian",
                            pet_Price = 100,
                            pet_OrtherName = "Dalmatian",
                            pet_Origin = "Dalmatian",
                            pet_CategoryId = newPc_Id2,
                            pet_Weight = 33,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/cho-dom.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-cocker.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "Japan Dog",
                            pet_Description = "Japan Dog",
                            pet_Price = 100,
                            pet_OrtherName = "Japan Dog",
                            pet_Origin = "Japan Dog",
                            pet_CategoryId = newPc_Id2,
                            pet_Weight = 33,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/chonhatban.png",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-pugdangyeu.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "Tibetan Clams",
                            pet_Description = "Tibetan Clams",
                            pet_Price = 100,
                            pet_OrtherName = "Tibetan Clams",
                            pet_Origin = "Tibetan Clams",
                            pet_CategoryId = newPc_Id3,
                            pet_Weight = 33,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/ngaottang.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-golden1.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "Deer Pug dog",
                            pet_Description = "Deer Pug dog",
                            pet_Price = 100,
                            pet_OrtherName = "Deer Pug dog",
                            pet_Origin = "Deer Pug dog",
                            pet_CategoryId = newPc_Id2,
                            pet_Weight = 33,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/phoc-huou.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-poodlecuoituoi.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "Phoc squirrel dog",
                            pet_Description = "Phoc squirrel dog",
                            pet_Price = 100,
                            pet_OrtherName = "Phoc squirrel dog",
                            pet_Origin = "Phoc squirrel dog",
                            pet_CategoryId = newPc_Id3,
                            pet_Weight = 33,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/phoc-soc.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-chuboss.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "Phu Quoc dogs",
                            pet_Description = "Phu Quoc dogs",
                            pet_Price = 100,
                            pet_OrtherName = "Phu Quoc dogs",
                            pet_Origin = "Phu Quoc dogs",
                            pet_CategoryId = newPc_Id3,
                            pet_Weight = 33,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/phu-quoc.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-becgiehalan.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "PITBULL",
                            pet_Description = "PITBULL",
                            pet_Price = 100,
                            pet_OrtherName = "PITBULL",
                            pet_Origin = "PITBULL",
                            pet_CategoryId = newPc_Id3,
                            pet_Weight = 33,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/pitbull.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-corgi.jpg"
                        }, new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "SHIBA INU ",
                            pet_Description = "SHIBA INU ",
                            pet_Price = 100,
                            pet_OrtherName = "SHIBA INU ",
                            pet_Origin = "SHIBA INU ",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 33,
                            pet_Lifespan = 12,
                            pet_IsDelete = false,
                            pet_ImgUrl1 = "image/giongcho/shiba.jpg",
                            pet_ImgUrl2 = "",
                            pet_ImgUrl3 = "",
                            pet_ImgUrl4 = "image/cuncon/cuncon-phochuou.jpg"
                        }
                        );

            // Table Product Categories
            string newCategories_Id1 = Guid.NewGuid().ToString();
            string newCategories_Id2 = Guid.NewGuid().ToString();
            string newCategories_Id3 = Guid.NewGuid().ToString();

            builder.Entity<ProductCategories>().HasData(
                new ProductCategories()
                {
                    proc_Id = newCategories_Id1,
                    proc_Name = "newCategories_Id1",
                    proc_Description = "newCategories_Id1",
                    proc_IsDelete = false
                },
                new ProductCategories()
                {
                    proc_Id = newCategories_Id2,
                    proc_Name = "newCategories_Id2",
                    proc_Description = "newCategories_Id2",
                    proc_IsDelete = false
                }
                ,
                new ProductCategories()
                {
                    proc_Id = newCategories_Id3,
                    proc_Name = "newCategories_Id3",
                    proc_Description = "newCategories_Id3",
                    proc_IsDelete = false
                }
                );


            // Table Product
            builder.Entity<Products>().HasData(
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = "Transparent Backpack For Dogs and Cats",
                     product_Description = "Transparent Backpack For Dogs and Cats",
                     product_CategoryId = newCategories_Id1,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-balotrongsuot.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 },
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = "Training Whistle",
                     product_Description = "Training Whistle",
                     product_CategoryId = newCategories_Id1,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-coihuanluyen.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 },
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = "Lamb Sticks",
                     product_Description = "Lamb Sticks",
                     product_CategoryId = newCategories_Id1,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-thitcuuque.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 },
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = "SmartHeart For Small Dogs",
                     product_Description = "SmartHeart For Small Dogs",
                     product_CategoryId = newCategories_Id1,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-SmartHeart.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 },
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = "Bonus Cake Tablets",
                     product_Description = "Bonus Cake Tablets",
                     product_CategoryId = newCategories_Id1,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-banhthuong.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 },
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = "Royal Canin For Adult Dogs",
                     product_Description = "Royal Canin For Adult Dogs",
                     product_CategoryId = newCategories_Id1,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-royal_truongthanh.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 },
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = "Pair of Bows",
                     product_Description = "Pair of Bows",
                     product_CategoryId = newCategories_Id1,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-capno.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 },
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = "Princess Lace Scarf",
                     product_Description = "Princess Lace Scarf",
                     product_CategoryId = newCategories_Id1,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-khanren.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 },
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = "Drugs of Calcium",
                     product_Description = "Drugs of Calcium",
                     product_CategoryId = newCategories_Id1,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-thuoccanxi.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 },
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = "Bow Bow Bra",
                     product_Description = "Bow Bow Bra",
                     product_CategoryId = newCategories_Id2,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-aongucnochuong.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 },
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = "Balloon Toys",
                     product_Description = "Balloon Toys",
                     product_CategoryId = newCategories_Id2,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-bongbongdochoi.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 },
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = "Dog Fence",
                     product_Description = "Dog Fence",
                     product_CategoryId = newCategories_Id2,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-raoquaycho.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 },
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = "BLOOM SEXY Fragrance Bath Oil",
                     product_Description = "BLOOM SEXY Fragrance Bath Oil",
                     product_CategoryId = newCategories_Id2,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-dautamnuochoabloomsexy.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 },
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = "Toys",
                     product_Description = "Toys",
                     product_CategoryId = newCategories_Id2,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-dochoi.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 },
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = "BLOOM SEXY Fragrance Bath Oil",
                     product_Description = "BLOOM SEXY Fragrance Bath Oil",
                     product_CategoryId = newCategories_Id2,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-dautamFay.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 },
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = "Anti-Tear Syrup",
                     product_Description = "Anti-Tear Syrup",
                     product_CategoryId = newCategories_Id2,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-sirochongchaynuocmat.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 },
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = "Lice Treatment Ring",
                     product_Description = "Lice Treatment Ring",
                     product_CategoryId = newCategories_Id3,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-vongtriveran.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 },
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = "HANTOC Lice Spray",
                     product_Description = "HANTOC Lice Spray",
                     product_CategoryId = newCategories_Id3,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-xitveranHANTOC.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 },
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = ">Nutri-Nutrition Gel",
                     product_Description = ">Nutri-Nutrition Gel",
                     product_CategoryId = newCategories_Id3,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-gelddNutri.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 },
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = "Bio Milk Powder For Dogs and Cats",
                     product_Description = "Bio Milk Powder For Dogs and Cats",
                     product_CategoryId = newCategories_Id3,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-suabotchomeo.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 },
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = "Sleeky Multivitamin",
                     product_Description = "Sleeky Multivitamin",
                     product_CategoryId = newCategories_Id3,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-vitamintonghop.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 },
                 new Products()
                 {
                     product_Id = Guid.NewGuid().ToString(),
                     product_Name = "Canxi Nano",
                     product_Description = "Canxi Nano",
                     product_CategoryId = newCategories_Id3,
                     product_Price = 10,
                     product_Rate = 1,
                     product_Img = "image/phukien/phukien-canxinano.png",
                     product_ReProducePrice = 1,
                     product_IsDelete = false
                 }
                 );





            // Table Roles
            string newRole_Id1 = Guid.NewGuid().ToString();

            builder.Entity<Roles>().HasData(
                new Roles()
                {
                    Id = newRole_Id1,
                    Name = "ADMIN",
                    NormalizedName = "admin",
                    Description = "admin",
                    isDelete = false
                }
                );


            // Table Users
            string newUser_Id1 = Guid.NewGuid().ToString();
            var hasher = new PasswordHasher<Users>();

            builder.Entity<Users>().HasData(
                new Users()
                {
                    Id = newUser_Id1,
                    UserName = "Staft",
                    FirstName = "FirstName",
                    LastName = "LastName",
                    NormalizedUserName = "STAFF@GMAIL.COM",
                    NormalizedEmail = "STAFF@GMAIL.COM",
                    Email = "staff@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DoB = DateTime.Now,
                    isDelete = false
                }
                );

            //  Table User Role
            builder.Entity<IdentityUserRole<string>>().HasData(
           new IdentityUserRole<string>
           {
               RoleId = newRole_Id1,
               UserId = newUser_Id1
           });




        }
    }
}