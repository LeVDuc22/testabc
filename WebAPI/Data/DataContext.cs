
using Microsoft.EntityFrameworkCore;
using WebAPI.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class DataContext : DbContext
    {

        public DbSet<Announcement> announcements { get; set; }
        public DbSet<News> news { set; get; }
        public DbSet<Gallery> galleries { set; get; }
        public DbSet<Events> events { set; get; }
        public DbSet<HowDoI> howDo { set; get; }
        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            IConfiguration config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false).Build();

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AnnoucementConfiguration(config));
            modelBuilder.ApplyConfiguration(new NewsConfiguration(config));
            modelBuilder.ApplyConfiguration(new GalleryConfiguration(config));
            modelBuilder.ApplyConfiguration(new EventsConfiguration());
            modelBuilder.ApplyConfiguration(new HowDoConfiguration());
        }

    }
}
