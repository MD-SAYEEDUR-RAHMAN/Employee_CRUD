using Employee_Attendence.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Attendence.Data

{
    public class EmployeeDbContext : DbContext
    {
        internal readonly object Categories;

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> MyProperty { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Md.Sharafat Ayon", Designation = "Senior Frontend Developer" },
                new Employee { Id = 2, Name = "Mejbaur Bahar Fagun", Designation = "Product Acceptance Engineer" },
                new Employee { Id = 3, Name = "Ifrat Jahan Chowdhury", Designation = "Business Analyst" },
                new Employee { Id = 4, Name = "Md Sayeedur Rahman", Designation = ".NET (Intern)" },
                new Employee { Id = 5, Name = "Raisa Rokib", Designation = ".NET(Intern)" }
                );
        }
    }
}
