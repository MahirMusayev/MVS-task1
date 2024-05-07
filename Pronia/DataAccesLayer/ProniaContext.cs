using Microsoft.EntityFrameworkCore;
using Pronia.Models;

namespace Pronia.DataAccesLayer
{
    public class ProniaContext : DbContext
    {
        public ProniaContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=LAPTOP-IM3K1CPI\\SQLEXPRESS;DataBase=AB106Pronia;Trusted_Connection=true;TrustServerCertificate = True");
            base.OnConfiguring(options);
        }
    }
}
