using LibraryProject.Domain;
using LibraryProject.Domain.Entities;
using LibraryProject.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace LibraryProject.Data.ConfigurationData
{
    public class SeedBooksData : IEntityTypeConfiguration<BooksEntity>
    {
        public void Configure(EntityTypeBuilder<BooksEntity> builder)
        {
            builder.HasData
            (
               new BooksEntity
               {
                   Id = 1,
                   BookName = "Alis Harikalar Diyarında",
                   Auther = "Levis Corrol",
                   BookPublishYear = 2022,
                   ControllerUserName = "Admin User",
                   CreatedDate = DateTime.Now,
                   ISBN = "975-17-1627-6",
                   Price = 20,
                   Status = (int)BookStatusEnum.Avaible
               },
             new BooksEntity
             {
                 Id = 2,
                 BookName = "Andersen Masalları",
                 Auther = "Andersen",
                 BookPublishYear = 2005,
                 ControllerUserName = "Admin User",
                 CreatedDate = DateTime.Now,
                 ISBN = "975-17-1627-6",
                 Price = 20,
                 Status = (int)BookStatusEnum.Avaible
             },
                new BooksEntity
                {
                    Id = 3,
                    BookName = "Ezop Masalları",
                    Auther = "Aisopos",
                    BookPublishYear = 1995,
                    ControllerUserName = "Admin User",
                    CreatedDate = DateTime.Now,
                    ISBN = "975-17-1627-6",
                    Price = 20,
                    Status = (int)BookStatusEnum.Avaible
                }
            );
        }
    }
}
