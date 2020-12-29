using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class EmployeeDbContext:DbContext
    {
        static string _conn = string.Empty;
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            _conn = "Data Source=192.168.50.95;Initial Catalog=pnimmagadda;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            optionBuilder.UseSqlServer(_conn);
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
