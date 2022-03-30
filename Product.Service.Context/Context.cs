using Microsoft.EntityFrameworkCore;
using Product.Service.Entities;
using System.Reflection;

namespace Product.Service.Context
{
    public class Context : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=TestDatabase.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map table names
            modelBuilder.Entity<ProductEntity>().ToTable("Products");
            modelBuilder.Entity<ProductEntity>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Number);
                entity.Property(e => e.Quantity);
                entity.Property(e => e.Description).HasMaxLength(200);
                entity.Property(e => e.Price).IsRequired();
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
