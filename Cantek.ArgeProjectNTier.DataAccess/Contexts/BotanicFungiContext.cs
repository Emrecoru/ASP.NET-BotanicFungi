using Cantek.ArgeProjectNTier.DataAccess.Configurations;
using Cantek.ArgeProjectNTier.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.DataAccess.Contexts
{
    public class BotanicFungiContext : DbContext
    {
        public BotanicFungiContext(DbContextOptions<BotanicFungiContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new GenderConfiguration());
            modelBuilder.ApplyConfiguration(new ParameterConfiguration());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            modelBuilder.ApplyConfiguration(new RoomParameterConfiguration());
            modelBuilder.ApplyConfiguration(new RoomStatusConfiguration());
        }

        public DbSet<AppRole> AppRoles { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<AppUserRole> AppUserRoles { get; set; }

        public DbSet<Gender> Genders { get; set; }

        public DbSet<Parameter> Parameters { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<RoomParameter> RoomParameters { get; set; }

        public DbSet<RoomStatus> RoomStatuses { get; set; }
    }
}
