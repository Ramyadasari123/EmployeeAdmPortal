using Microsoft.EntityFrameworkCore;
using EmployeeAdmPortal.Model.Entities;




namespace EmployeeAdmPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }


    }
}
