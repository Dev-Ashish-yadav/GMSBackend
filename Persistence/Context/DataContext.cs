using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Gym_Users_master> Gym_User_Master { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Gym_Users_master>().HasKey(p => new { p.GU_ID, p.GU_GM_ID, p.GU_MOBILE });
        }
    }
}
