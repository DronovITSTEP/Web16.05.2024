using Microsoft.EntityFrameworkCore;



namespace Practic16._05._2024.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Age { get; set; }
    }
    public class EmployeeDBContext: DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> DbSet { get; set;}
    }
}
