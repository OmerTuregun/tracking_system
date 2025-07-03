using System.Data.Entity;
using CrsTakipSistemi.Models;

namespace CrsTakipSistemi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection") { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserTask> Tasks { get; set; }
        public DbSet<Training> Trainings { get; set; }
    }
}
