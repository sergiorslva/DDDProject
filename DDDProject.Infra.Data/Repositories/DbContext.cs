using DDDProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DDDProject.Infra.Data.Repositories
{
    public class DDDPRojectContext: DbContext
    {
        public DDDPRojectContext(DbContextOptions<DDDPRojectContext> options) : base(options)
        {
        }

        public DbSet<Calendar> Calendar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Calendar>().HasKey(c => c.Id);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
