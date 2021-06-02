using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tapshiriq1.Database
{
    public class CompanyDb:DbContext
    {
        public CompanyDb(DbContextOptions<CompanyDb>context) : base(context) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<EmployeeInformation> EmployeeInformations { get; set; }
        public DbSet<CompanyEmployee> CompanyEmployees { get; set; }
    }
}
