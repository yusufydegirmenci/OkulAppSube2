using Microsoft.EntityFrameworkCore;

namespace EfAppSube2
{
    internal class OkulDbContext:DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial
              Catalog=OkulDBSube2EF;Integrated Security=true;TrustServerCertificate=true");
            

           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ogrenci>().Property(o=>o.Soyad).HasColumnType("varchar").HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Ogrenci>().Property(o =>o.Numara).HasColumnType("varchar").HasMaxLength(20).IsRequired();
        }
    }
}



//Migration: EF Code First tekniğinde yazılan kodların veritabanına yansıtılması için kullanılan class'lara migration classları denir.
//Kod üzerinde her değişiklik yapıldığında, yeni bir migration eklenmelidir.