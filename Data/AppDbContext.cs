using Microsoft.EntityFrameworkCore;
using UniversityDbApp.Models;

namespace UniversityDbApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Тапсырма (Assignment)
        public DbSet<Department> Departments { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        // Лабораториялық жұмыс (Lab)
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Бастапқы деректер (миграциямен бірге кестеге түседі)
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Информатика кафедрасы" },
                new Department { Id = 2, Name = "Математика кафедрасы" });

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { Id = 1, FullName = "Ахметов Серік", Position = "Профессор", DepartmentId = 1 },
                new Teacher { Id = 2, FullName = "Нұрланова Айгүл", Position = "Доцент", DepartmentId = 1 },
                new Teacher { Id = 3, FullName = "Серіков Ержан", Position = "Аға оқытушы", DepartmentId = 2 });

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Электроника" },
                new Category { Id = 2, Name = "Аксессуарлар" });

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Ноутбук", Price = 285000m, CategoryId = 1 },
                new Product { Id = 2, Name = "Смартфон", Price = 320000m, CategoryId = 1 },
                new Product { Id = 3, Name = "Клавиатура", Price = 45000m, CategoryId = 2 });
        }
    }
}
