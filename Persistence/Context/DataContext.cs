using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Gym_Users_master> Gym_User_Master { get; set; }
        public DbSet<GymAdminMaster> GymAdminMaster { get; set; }
        public DbSet<GymFeesStructure> GymFeesStructure { get; set; }
        public DbSet<GymMember>GymMember { get; set; }
        public DbSet<GymMessage>GymMessage { get; set; }
        public DbSet<GymOwner>GymOwner { get; set; }
        public DbSet<GymPayment> GymPayment { get; set; }
        public DbSet<Gym_Master> Gym_Master { get; set; }
        
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Gym_Users_master>().HasKey(p => new { p.GU_ID, p.GU_GM_ID, p.GU_MOBILE });
            modelbuilder.Entity<Gym_Users_master>().Property(e => e.GU_ID).ValueGeneratedOnAdd();

            modelbuilder.Entity<GymAdminMaster>().HasKey(p => p.Id);
            modelbuilder.Entity<GymAdminMaster>().Property(e=>e.Id).ValueGeneratedOnAdd();

            modelbuilder.Entity<GymFeesStructure>().HasKey(p => p.Id);
            modelbuilder.Entity<GymFeesStructure>().Property(e => e.Id).ValueGeneratedOnAdd();

            modelbuilder.Entity<GymMember>().HasKey(p => p.Id);
            modelbuilder.Entity<GymMember>().Property(e => e.Id).ValueGeneratedOnAdd();

            modelbuilder.Entity<GymMessage>().HasKey(p => p.Id);
            modelbuilder.Entity<GymMessage>().Property(e => e.Id).ValueGeneratedOnAdd();

            modelbuilder.Entity<GymOwner>().HasKey(p => p.Id);
            modelbuilder.Entity<GymOwner>().Property(e => e.Id).ValueGeneratedOnAdd();

            modelbuilder.Entity<GymPayment>().HasKey(p => p.Id);
            modelbuilder.Entity<GymPayment>().Property(e => e.Id).ValueGeneratedOnAdd();

            modelbuilder.Entity<Gym_Master>().HasKey(p => p.id);
            modelbuilder.Entity<Gym_Master>().Property(e => e.id).ValueGeneratedOnAdd();


        }
    }
}
