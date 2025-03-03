using Entity_FrameWork_Session03.InheretanceTest;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Session03.Contexts
{
    internal class RouteDBContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FullTimeEmployee>()
                        .Property(E => E.Salary)
                        .HasColumnType("decimal(18,5");
            modelBuilder.Entity<PartTimeEmployee>()
                        .Property(E => E.HourRate)
                        .HasColumnType("decimal(10,2)");

            modelBuilder.Entity<FullTimeEmployee>()
                        .HasBaseType<Employee>();
            modelBuilder.Entity<PartTimeEmployee>()
                        .HasBaseType<Employee>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; DataBase = ITI ; Trusted_Connection = true; TrustServerCertificate = true;");
        }
        //TPCC
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }


    }
}
