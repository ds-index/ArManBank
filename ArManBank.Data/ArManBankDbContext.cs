//ArMan DS
using ArManBank.Domain;
using Microsoft.EntityFrameworkCore;

namespace ArManBank.Data
{
    public class ArManBankDbContext : DbContext
    {
        private string _dbPath;
        public ArManBankDbContext()
        {
            var folder = Environment.SpecialFolder.ApplicationData;
            var path = Environment.GetFolderPath(folder);
            _dbPath = Path.Combine(path, "ArManBank.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={_dbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData
                (
                    new User { Id = 1, FirstName = "John", LastName = "Doe", Balance = 1340.75m, CreateDate = DateTime.Parse("2023-01-12"), TypeOfBalance = TypeOfBalance.Primary },
                    new User { Id = 2, FirstName = "Emma", LastName = "Smith", Balance = 987.60m, CreateDate = DateTime.Parse("2023-02-08"), TypeOfBalance = TypeOfBalance.Primary },
                    new User { Id = 3, FirstName = "Liam", LastName = "Johnson", Balance = 2590.00m, CreateDate = DateTime.Parse("2023-03-22"), TypeOfBalance = TypeOfBalance.Increasing },
                    new User { Id = 4, FirstName = "Olivia", LastName = "Brown", Balance = 410.50m, CreateDate = DateTime.Parse("2023-04-05"), TypeOfBalance = TypeOfBalance.Stored },
                    new User { Id = 5, FirstName = "Noah", LastName = "Williams", Balance = 1325.25m, CreateDate = DateTime.Parse("2023-05-18"), TypeOfBalance = TypeOfBalance.Primary },
                    new User { Id = 6, FirstName = "Ava", LastName = "Jones", Balance = 830.80m, CreateDate = DateTime.Parse("2023-06-11"), TypeOfBalance = TypeOfBalance.Stored },
                    new User { Id = 7, FirstName = "James", LastName = "Miller", Balance = 4200.00m, CreateDate = DateTime.Parse("2023-07-07"), TypeOfBalance = TypeOfBalance.Increasing },
                    new User { Id = 8, FirstName = "Isabella", LastName = "Davis", Balance = 1550.30m, CreateDate = DateTime.Parse("2023-08-19"), TypeOfBalance = TypeOfBalance.Primary },
                    new User { Id = 9, FirstName = "William", LastName = "Garcia", Balance = 670.00m, CreateDate = DateTime.Parse("2023-09-23"), TypeOfBalance = TypeOfBalance.Primary },
                    new User { Id = 10, FirstName = "Sophia", LastName = "Martinez", Balance = 2999.99m, CreateDate = DateTime.Parse("2023-10-01"), TypeOfBalance = TypeOfBalance.Stored }
                );
        }

        public DbSet<User> Users { get; set; }
    }
}
