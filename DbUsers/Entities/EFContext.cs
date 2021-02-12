using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbUsers.Entities
{
    public class EFContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=91.238.103.51;Port=5743;Database=mayevskydb;Username=maey;Password=$544$B77w**G)K$t!Ube22}mav");
        }
        /// <summary>
        /// Створення зв’язків в таблицях за допомогою Fluent Api
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserRole>(userRoles =>
            {
                userRoles.HasKey(tp => new { tp.UserId, tp.RoleId }); // вказуємо хто буде primery key

                userRoles.HasOne(tp => tp.User)
                    .WithMany(t => t.UserRoles)
                    .HasForeignKey(tp => tp.UserId)
                    .IsRequired();


                userRoles.HasOne(tp => tp.Role)
                    .WithMany(t => t.UserRoles)
                    .HasForeignKey(tp => tp.RoleId)
                    .IsRequired();
                    
            });
        }


    }
}
