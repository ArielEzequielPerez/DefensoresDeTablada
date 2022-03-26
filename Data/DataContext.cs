using defensoresCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace DefensoresDeTablada.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<MaximumRep> MaximumReps { get; set; }
    }
}