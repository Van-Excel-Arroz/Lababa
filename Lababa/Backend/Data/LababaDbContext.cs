
using Lababa.Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace Lababa.Backend.Data
{
    public class LababaDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ItemService> ItemServices { get; set; }
        public DbSet<WeightService> WeightServices { get; set; }
        public DbSet<OrderItemItem> OrderItemItems { get; set; }
        public DbSet<OrderWeightItem> OrderWeightItems { get; set; }
        public DbSet<ApplicationSettings> AppSettings { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "lababa.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.ItemItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.WeightItems)
                .WithOne(ow => ow.Order)
                .HasForeignKey(ow => ow.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ApplicationSettings>().HasKey(s => s.Id);
            modelBuilder.Entity<ApplicationSettings>().HasData(
                    new ApplicationSettings { Id = 1 }
                );

        }
    }
}
