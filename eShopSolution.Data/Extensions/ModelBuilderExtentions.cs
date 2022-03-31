using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData
                (
                 new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
                 new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
                 new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopSolution" }
                 );

            modelBuilder.Entity<Language>().HasData
                (
                new Language() { Id="vi-VN",Name="Tiếng Việt",IsDefault=true},
                new Language() { Id="en-US",Name="English",IsDefault=true}
                );

            modelBuilder.Entity<Category>().HasData
                (
                new Category() 
                    { 
                    Id = 1,
                    IsShowOnHome=true,
                    ParentId=null,
                    SortOrder=1,
                    Status=Status.Active,
                    },
                     new Category()
                     {
                         Id = 2,
                         IsShowOnHome = true,
                         ParentId = null,
                         SortOrder = 2,
                         Status = Status.Active
                     }
                );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                        new CategoryTranslation(){
                            Id=1,
                            CategoryId = 1,
                            Name="Áo Nam",
                            LanguageId="vi-VN",
                            SeoAlias="ao-nam",
                            SeoDescription="Sản phẩm áo thời trang nam",
                            SeoTitle="Thời trang nam"},
                        new CategoryTranslation(){
                            Id=2,
                            CategoryId=1,
                            Name="Men Shirt",
                            LanguageId="en-US",
                            SeoAlias="men-shirt",
                            SeoDescription="The shirt products for men",
                            SeoTitle="Fashion men"},
                        new CategoryTranslation()
                             {
                             Id=3,
                             CategoryId=2,
                             Name = "Áo nữ",
                             LanguageId = "vi-VN",
                             SeoAlias = "ao-nu",
                             SeoDescription = "Sản phẩm áo thời trang nu",
                             SeoTitle = "Thời trang nu"
                             },
                        new CategoryTranslation()
                        {   
                            Id=4,
                            CategoryId=2,
                            Name = "Women Shirt",
                            LanguageId = "en-US",
                            SeoAlias = "Women-shirt",
                            SeoDescription = "The shirt products for women",
                            SeoTitle = "Fashion women"
                        }
                );

            modelBuilder.Entity<Product>().HasData
                (
                new Product() 
                    { 
                    Id=1,
                    DateCreated=DateTime.Now, 
                    OriginalPrice=100000,
                    Price=200000,
                    Stock=0,
                    ViewCount=0,
                     }
                );

            modelBuilder.Entity<ProductTranslation>().HasData(
                      new ProductTranslation()
                      {
                          Id=1,
                          ProductId=1,
                          Name = "Áo sơ mi nam trắng HL",
                          LanguageId = "vi-VN",
                          SeoAlias = "ao-so-mi-nam-trang-HL",
                          SeoDescription = "Sản phẩm áo thời sơ mi trắng nam",
                          SeoTitle = "Thời trang nam HL",
                          Details = "Mô tả sản phẩm",
                          Description = "HL nơi đẳng cấp được tôn lên"
                      },
                        new ProductTranslation()
                        {
                            Id=2,
                            ProductId=1,
                            Name = "Men Shirt",
                            LanguageId = "en-US",
                            SeoAlias = "men-shirt",
                            SeoDescription = "The shirt products for men",
                            SeoTitle = "Fashion men",
                            Details = "Product Description",
                            Description = "HL where class is exalted"
                        }
                );

                modelBuilder.Entity<ProductInCategory>().HasData(
                 new ProductInCategory() {ProductId=1, CategoryId = 1 }
                    );


            // any guid
            var roleId = new Guid("5FFB8C27-8539-4ACD-80AC-12F375A92F1C");
            var adminId = new Guid("A2F01688-BCB2-436B-A904-4C676B4AC72C");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "ngochuyle600@gmail.com",
                NormalizedEmail = "ngochuyle600@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "huyitc123$"),
                SecurityStamp = string.Empty,
                FirstName = "Le",
                LastName = "Huy",
                Dob = new DateTime(2000, 10, 26)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

        }
    }
 }

