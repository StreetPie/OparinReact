using Microsoft.EntityFrameworkCore;
using OparinReact.Backend.Models;
using System;
using System.Windows;
using DbTask = OparinReact.Backend.Models.Task;


namespace OparinReact.Backend
{
    public class AppDbContext : DbContext
    {
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeProject> EmployeeProject { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<DbTask> Tasks { get; set; }
        public DbSet<User> User { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString =
        "Server=DESKTOP-36VM1D0\\SQLEXPRESS;Database=OparinRetake;Trusted_Connection=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
    
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeProject>()
                .HasOne(ep => ep.Employee)
                .WithMany(e => e.EmployeeProject) 
                .HasForeignKey(ep => ep.EmployeeId);

            modelBuilder.Entity<EmployeeProject>()
                .HasOne(ep => ep.Project)
                .WithMany(p => p.EmployeeProject)
                .HasForeignKey(ep => ep.ProjectId);


            modelBuilder.Entity<Project>()
                .HasMany(p => p.Task) 
                .WithOne(t => t.Project) 
                .HasForeignKey(t => t.ProjectId); 

            modelBuilder.Entity<Project>()
                .HasMany(p => p.EmployeeProject)
                .WithOne(ep => ep.Project) 
                .HasForeignKey(ep => ep.ProjectId);


            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.User)
                .HasForeignKey(u => u.RoleId);
        }



    }

}
