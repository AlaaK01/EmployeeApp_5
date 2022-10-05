using EmployeeApp_5.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp_5.EA_DbConText
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=ALAA\MYSQLSERVER;Initial Catalog=EmployeeApp_5;Integrated Security=True");
        }
    }
}
