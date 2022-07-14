using Microsoft.EntityFrameworkCore;
using PizzaApp.DataAccess.DataRelations;
using PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.DataAccess.Data
{
    public class PizzaAppDbContext : DbContext
    {
        public PizzaAppDbContext(DbContextOptions options) : base(options)
        {

        }
        // db set od domain model User da bide Users vo baza
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // moze vo posebni klasi relaciite so metoda AddPizzaRelations primer folder Data Relation

            // DEFINING RELATIONSHIPS

            // hover na x ako ne sme sigurni od koj tip e x
            //modelBuilder.Entity<Order>()
            //    .HasMany(x => x.PizzaOrders)
            //    .WithOne(x => x.Order)
            //    .HasForeignKey(x => x.OrderId);

            // Define relations in external method
            RelationsResolver.AddOrderRelations(modelBuilder);

            modelBuilder.Entity<Pizza>()
                .HasMany(x => x.PizzaOrders)
                .WithOne(x => x.Pizza)
                .HasForeignKey(x => x.PizzaId);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);


            // Data seed
            DataSeed.InsertDataInDb(modelBuilder);

        }





    }
}
