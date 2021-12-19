using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class weather_DBContext : DbContext
    {
        public weather_DBContext()
        {
        }

        public weather_DBContext(DbContextOptions<weather_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FavoriteCitys> FavoriteCitys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-S2I7851;
DataBase=weather_DB;
Trusted_Connection=True;
");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FavoriteCitys>(entity =>
            {
                entity.ToTable("favoriteCitys");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("cityName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdName)
                    .IsRequired()
                    .HasColumnName("idName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdUser)
                    .IsRequired()
                    .HasColumnName("idUser")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Temp).HasColumnName("temp");

                entity.Property(e => e.WeatherText)
                    .IsRequired()
                    .HasColumnName("weatherText")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
