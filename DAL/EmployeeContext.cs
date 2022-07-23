using System;
using Microsoft.EntityFrameworkCore;
using Asp.netCoreMvcCrud.Models;



namespace Asp.netCoreMvcCrud.DAL
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

      

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Conge> Conges { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasMany(c => c.conges).WithOne(e => e.Employee);
            });
        }
    }
 
}
