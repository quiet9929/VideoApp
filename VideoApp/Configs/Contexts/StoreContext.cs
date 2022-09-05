using Microsoft.EntityFrameworkCore;
using VideoApp.Models;

namespace VideoApp.Configs.Contexts
{
    public class StoreContext : DbContext
    {
        private static StoreContext _instance;
        public static StoreContext Db
        {
            get {
                if (_instance is null) 
                {
                    _instance = new StoreContext();
                    return _instance;
                }
                return _instance;
            }
        }

        public DbSet<Video> Videos { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Resource> Resources { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<VideoSerie> VideoSeries { get; set; }

        public DbSet<Actor> Actors{ get; set; }

        public DbSet<Director> Directors { get; set; }

        public StoreContext() 
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = Path.Combine(FileSystem.AppDataDirectory, "app.db");
            optionsBuilder.UseSqlite($"Data Source={path}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
