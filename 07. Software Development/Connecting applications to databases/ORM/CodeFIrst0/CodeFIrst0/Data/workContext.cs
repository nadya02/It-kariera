using CodeFirstDB.Models;
using Microsoft.EntityFrameworkCore;


namespace CodeFirstDB.Data
{
    public class WorkContext : DbContext //изисква пакет Microsoft.EntityFrameworkCore.SqlServer
    {
        public WorkContext()
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .\\SQLEXPRESS; Database = Work; Integrated Security = true");
        }

        //за копозитния ключ на таблица EmployeeProject
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeProject>().HasKey(x => new { x.EmployeeId, x.ProjectId });
        }
    }
}
