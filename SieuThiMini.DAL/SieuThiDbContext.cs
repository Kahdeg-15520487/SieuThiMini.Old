using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using SieuThiMini.DAL.Entites;
using System.IO;

namespace SieuThiMini.DAL
{
    public class SieuThiDbContext : DbContext
    {
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<DanhMuc> DanhMucs { get; set; }

        public SieuThiDbContext(DbContextOptions<SieuThiDbContext> options) : base(options)
        {
        }

        protected SieuThiDbContext()
        {
        }

        //for migration
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DanhMuc>().HasData(JsonConvert.DeserializeObject<DanhMuc[]>(SeedData.danhmuc));
            modelBuilder.Entity<SanPham>().HasData(JsonConvert.DeserializeObject<SanPham[]>(SeedData.sanpham));

            base.OnModelCreating(modelBuilder);
        }
    }
}
