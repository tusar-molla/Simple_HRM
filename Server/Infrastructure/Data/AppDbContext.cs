﻿using Microsoft.EntityFrameworkCore;
using Server.Domain.Entities;
using Server.Helpers;

namespace Server.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Role>().HasData(
                
                new Role { Id = 1, Name = "Admin" },
                new Role { Id = 2, Name = "HR" },
                new Role { Id = 3, Name = "Employee" }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FullName = "Admin",
                    Email = "admin@gmail.com",
                    PasswordHash = PasswordHasher.HashPassword("
                    
                    
                    
                    
                    
                    
                    
                    "),
                    RoleId = 1
                }
                );
        }
    }
}
