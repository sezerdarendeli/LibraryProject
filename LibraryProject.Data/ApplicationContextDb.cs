using LibraryProject.Data.ConfigurationData;
using LibraryProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject.Data
{
    public class ApplicationContextDb : DbContext
    {
        public ApplicationContextDb(DbContextOptions<ApplicationContextDb> options)
            : base(options)
        {
        }

        public DbSet<BooksEntity> Books { get; set; }
        public DbSet<BookReservationEntity> BookReservations { get; set; }

        public DbSet<BookReservationHistoryEntity> BookReservationHistory { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new SeedBooksData());
            base.OnModelCreating(builder);
        }
    }
}
