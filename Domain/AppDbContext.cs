using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Domain.Entities;

namespace WebApplication2.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Heat_work> Heat_Works { get; set; }
        public DbSet<ShiftEn> ShiftEns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            

            modelBuilder.Entity<ShiftEn>().HasData(new ShiftEn
            {
                Id = 3,
                Team = 3,
                DataTeam = new DateTime(2023, 1, 3)
            });

            modelBuilder.Entity<ShiftEn>().HasData(new ShiftEn
            {
                Id = 4,
                Team = 4,
                DataTeam = new DateTime(2023, 1, 1)
            });

            modelBuilder.Entity<ShiftEn>().HasData(new ShiftEn
            {
                Id = 5,
                Team = 1,
                DataTeam = new DateTime(2023, 1, 2)
            });

            modelBuilder.Entity<Heat_work>().HasData(new Heat_work
            {
                Id = 100,  
                HEAT_NO = 1180201,
                HEAT_DTE = new DateTime(2023, 1, 1, 7, 17, 00)
            });
            modelBuilder.Entity<Heat_work>().HasData(new Heat_work
            {
                Id = 200,
                HEAT_NO = 1180201,
                HEAT_DTE = new DateTime(2023, 1, 1, 7, 17, 00)
            });
            modelBuilder.Entity<Heat_work>().HasData(new Heat_work
            {
                Id = 300,
                HEAT_NO = 1180201,
                HEAT_DTE = new DateTime(2023, 1, 1, 7, 17, 00)
            });

        }

    }
}
