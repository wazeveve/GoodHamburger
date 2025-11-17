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

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OrderDish>().HasOne(d => d.Dish).WithMany(od => od.OrderDishes).HasForeignKey(d => d.DishId);
            modelBuilder.Entity<OrderDish>().HasOne(o => o.Order).WithMany(od => od.OrderDishes).HasForeignKey(o => o.Order);

        }


        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDish> OrderDishes { get; set; }
    }
}
