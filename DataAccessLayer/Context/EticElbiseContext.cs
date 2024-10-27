using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class EticElbiseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-I1EN423K\\MSSQLSERVER01;initial catalog=ETicElbise;integrated security=true;");

        }
        public DbSet<Category> Categories { get; set; } //parantez içi klas adı , dışkısımada bulunan ad ise tablo adı 
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<ProductRewiew> ProductRewiews { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Sizes> Sizes { get; set; }
        public DbSet<TemporanyColors> TemporanyColors { get; set; }

    }
}
