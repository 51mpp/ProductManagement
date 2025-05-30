using Microsoft.EntityFrameworkCore;
using ProductManagementAPI.Models;

namespace ProductManagementAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<StockChange> StockChanges { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //config real name of table in database
            modelBuilder.Entity<Product>().ToTable("Product"); 
            modelBuilder.Entity<StockChange>().ToTable("StockChange"); 
        }

    }





}
