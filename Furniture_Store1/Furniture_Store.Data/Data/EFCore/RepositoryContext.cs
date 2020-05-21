using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Furniture_Store.Data.Models;
using Furniture_Store.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Furniture_Store.Models
{
    public class RepositoryContext : IdentityDbContext<MyUser, MyRole, int>
    {
        //public RepositoryContext(DbContextOptions options) : base(options)
        //{

        //}
        public RepositoryContext()
        {
        }
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
            Database.EnsureCreated();
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
            base.OnModelCreating(modelBuilder);
        }
    }
}

