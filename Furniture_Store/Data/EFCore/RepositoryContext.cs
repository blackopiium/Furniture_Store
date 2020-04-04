using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Furniture_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace Furniture_Store.Models
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext()
        {
        }

        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<Charachteristics_Item> Charachteristics_Items { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Items> Order_Items { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Coaches",
                    Description = "The best coach for every person only here"

                });
            modelBuilder.Entity<Factory>().HasData(
                new Factory
                {
                    Id = 2,
                    Name = "Frankof",
                    Country = "Ukraine",
                    City = "Kyiv",
                    Description = "The Ukrainian Factory of the modern furniture"

                });
            modelBuilder.Entity<Item>().HasData(
               new Item
               {
                   Id = 1,
                   Name = "Marsek",
                   CategoryId = 1,
                   Price = 27000,
                   FactoryId = 2
               });
        }
    }
}

