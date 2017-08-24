using Robot.Models;
using Microsoft.EntityFrameworkCore;

namespace Robot.Data
{
    public class RobotContext : DbContext
    {
        public RobotContext(DbContextOptions<RobotContext> options) : base(options)
        {
        }

        public DbSet<Scene> Scenes { get; set; }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Scene>().ToTable("Scenes");
            modelBuilder.Entity<Person>().ToTable("Persons");
        }

    }
}