using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProiectASP.NET5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ProiectASP.NET5.net.Context
{

    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Shop> Shops { get; set; }

        public DbSet<Website> Websites { get; set; }
        public DbSet<Product> Products { get; set; }
        //public DbSet<Factory> Factories { get; set; }

        public DbSet<ShopClient> ShopClients { get; set; }

        protected override void OnModelCreating(ModelBuilder Builder)
        {//One to many

            Builder.Entity<Shop>()
                .HasMany(s => s.Products)
                .WithOne(p => p.Shop);
            //One to one

            Builder.Entity<Shop>()
                .HasOne(s => s.Website)
                .WithOne(w => w.Shop);

            //Many to many

            Builder.Entity<ShopClient>().HasKey(sc => new { sc.ShopId, sc.ClientId });

            Builder.Entity<ShopClient>()
                .HasOne(sc => sc.Shop)
                .WithMany(s => s.ShopClient)
                .HasForeignKey(sc => sc.ShopId);

            Builder.Entity<ShopClient>()
                 .HasOne(sc => sc.Client)
                 .WithMany(c => c.ShopClient)
                 .HasForeignKey(sc => sc.ClientId);
        }
    }
}
