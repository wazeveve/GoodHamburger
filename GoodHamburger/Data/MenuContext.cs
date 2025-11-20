using GoodHamburguer.Models;
using Microsoft.EntityFrameworkCore;

namespace GoodHamburguer.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDish>().HasKey(od => new { od.OrderId, od.DishId });

            modelBuilder.Entity<OrderDish>()
                .HasOne(od => od.Dish)
                .WithMany(d => d.OrderDishes)
                .HasForeignKey(od => od.DishId);

            modelBuilder.Entity<OrderDish>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDishes)
                .HasForeignKey(od => od.OrderId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDish> OrderDishes { get; set; }
    }
}
