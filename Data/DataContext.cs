using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi_rest_repository.Models;

namespace webapi_rest_repository.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> context):base(context)
        {
         
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Custumer> Custumers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Custumer>().HasKey(x => x.Id);
            modelBuilder.Entity<Custumer>()
                .HasOne(x => x.Product)
                .WithMany()
                .HasForeignKey(x => x.Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>().HasKey(x => x.Id);
        }
        

    }
}
