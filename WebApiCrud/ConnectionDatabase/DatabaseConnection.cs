using Microsoft.EntityFrameworkCore;
using WebApiCrud.Models;

namespace WebApiCrud.ConnectionDatabase
{
    public class DatabaseConnection : DbContext
    {
        public DatabaseConnection(DbContextOptions<DatabaseConnection> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
