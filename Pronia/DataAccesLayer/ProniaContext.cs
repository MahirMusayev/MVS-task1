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
        public DbSet<Slider> Sliders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=CA-R214-PC04\\SQLEXPRESS;DataBase=AB106Pronia;Trusted_Connection=true;TrustServerCertificate = True");
            base.OnConfiguring(options);
        }
    }
}
