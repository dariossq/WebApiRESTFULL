using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StoreWebApi.Models
{
    public partial class StoreDBBContext : DbContext
    {
        public virtual DbSet<CurrentWeather> CurrentWeather { get; set; }
        public virtual DbSet<News> News { get; set; }

        public StoreDBBContext(DbContextOptions<StoreDBBContext> options) : base(options)
        {

        }


        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer(@"Server= DESKTOP-PIB9MC0\SQLEXPRESS;Database= StoreDBB;Integrated Security=SSPI");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurrentWeather>(entity =>
            {
                entity.ToTable("current_weather");

                entity.Property(e => e.CurrentWeatherId).HasColumnName("current_weather_id");

                entity.Property(e => e.Cloudcover)
                    .HasColumnName("cloudcover")
                    .HasColumnType("numeric(3, 3)");

                entity.Property(e => e.Feelslike)
                    .HasColumnName("feelslike")
                    .HasColumnType("numeric(3, 3)");

                entity.Property(e => e.Humidity)
                    .HasColumnName("humidity")
                    .HasColumnType("numeric(3, 3)");

                entity.Property(e => e.ObservationTime).HasColumnName("observation_time");

                entity.Property(e => e.Precip)
                    .HasColumnName("precip")
                    .HasColumnType("numeric(3, 3)");

                entity.Property(e => e.Pressure)
                    .HasColumnName("pressure")
                    .HasColumnType("numeric(3, 3)");

                entity.Property(e => e.Temperature)
                    .HasColumnName("temperature")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.UvIndex)
                    .HasColumnName("uv_index")
                    .HasColumnType("numeric(3, 3)");

                entity.Property(e => e.Visibility)
                    .HasColumnName("visibility")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.WeatherDescriptions)
                    .HasColumnName("weather_descriptions")
                    .HasMaxLength(50);

                entity.Property(e => e.WindDegree)
                    .HasColumnName("wind_degree")
                    .HasColumnType("numeric(3, 3)");

                entity.Property(e => e.WindDir)
                    .HasColumnName("wind_dir")
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.WindSpeed)
                    .HasColumnName("wind_speed")
                    .HasColumnType("numeric(3, 3)");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.HasKey(e => e.NewId);

                entity.ToTable("news");

                entity.Property(e => e.NewId)
                    .HasColumnName("new_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Author)
                    .HasColumnName("author")
                    .HasMaxLength(50);

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(50);

                entity.Property(e => e.CurrentWeatherId).HasColumnName("current_weather_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.PublishedAt)
                    .HasColumnName("publishedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(50);

                entity.Property(e => e.UrlToImage)
                    .HasColumnName("urlToImage")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CurrentWeather)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.CurrentWeatherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_news_current_weather");
            });
        }
    }
}
