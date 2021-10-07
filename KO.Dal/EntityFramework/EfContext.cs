using KO.Entities.Entities;
using KO.Utility.Helper;
using Microsoft.EntityFrameworkCore;

namespace KO.Dal.EntityFramework
{
    public class EfContext : DbContext
    {
        public DbSet<User> Users { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //SqlServerDbContextOptionsExtensions.UseSqlServer(optionsBuilder, ConnectionString);
            optionsBuilder.UseSqlite(AppParameter.AppSettings.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ModelBuilderHelper.OnModelCreating(modelBuilder);
        }
    }
}
