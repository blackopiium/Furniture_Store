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

        }
 }

