using DersPlani_Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace DersPlani_Api.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Sınıf> Sınıflar { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Saat> Saatler { get; set; }
        public DbSet<Ogretmen> Ogretmenler { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
  

        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        // Öğretmen ve Ders arasındaki ilişkiyi belirtiyoruz
        //        modelBuilder.Entity<Ders>()
        //            .HasOne(d => d.Ogretmen)       // Bir ders bir öğretmene vardır
        //            .WithMany(s => s.Dersler)         // Bir öğretmenin birden fazla dersi olabilir
        //            .HasForeignKey(d => d.OgretmenId);

        //        // Ders - Sınıf İlişkisi
        //        modelBuilder.Entity<Ders>()
        //            .HasMany(d => d.Sınıflar)
        //            .WithMany(s => s.Dersler)
        //            .HasForeignKey(d => d.SinifId);

        //        // Ders - Saat İlişkisi (Eğer varsa)
        //        modelBuilder.Entity<Ders>()
        //            .HasOne(d => d.Saat)
        //            .WithMany(s => s.Dersler)
        //            .HasForeignKey(d => d.SaatId);

        //        base.OnModelCreating(modelBuilder);
        //    }
        //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    {
        //        // Veritabanı bağlantı dizesini burada ayarlayın
        //        optionsBuilder.UseSqlServer("YOUR_CONNECTION_STRING");
        //    }
    }
}
