using Microsoft.EntityFrameworkCore;

namespace NCQ.Test.Infrastructure.Common.Contexts
{
    public class SqLiteDbContext : DbContext
    {
        public SqLiteDbContext() { }
        public SqLiteDbContext(DbContextOptions<SqLiteDbContext> options) : base(options)
        {
            var wasCreated = Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(SqLiteDbContext).Assembly,
                t => t.Namespace != null && t.Namespace.Contains("NCQ.Test.Infrastructure.SqLite"));

            base.OnModelCreating(modelBuilder);
        }
    }
}
