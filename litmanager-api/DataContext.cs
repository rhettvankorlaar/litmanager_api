using litmanager_api.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api
{
    public class DataContext : DbContext
    {
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> option) : base(option)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserActivity>()
                .HasKey(ua => new { ua.UserId, ua.ActivityId });
            modelBuilder.Entity<UserActivity>()
                .HasOne(ua => ua.User)
                .WithMany(u => u.UserActivities)
                .HasForeignKey(ua => ua.UserId);
            modelBuilder.Entity<UserActivity>()
                .HasOne(ua => ua.Activity)
                .WithMany(a => a.UserActivities)
                .HasForeignKey(ua => ua.ActivityId);
        }
    }
}
