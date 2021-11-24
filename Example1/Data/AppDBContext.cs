using Microsoft.EntityFrameworkCore;

namespace Example1.Data
{
    public class AppDBContext : DbContext
    {
        public IConfiguration Configuration { get; }

        public DbSet<User> Users { get; set; } = null!;

        public AppDBContext(IConfiguration configuration, DbContextOptions<AppDBContext> options) : base(options)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
    }
}