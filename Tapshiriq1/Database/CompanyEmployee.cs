using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tapshiriq1.Database
{
    public class CompanyEmployee
    {
        public int ID { get; set; }
        public int CompanyID { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employees { get; set; }
        public Company Company { get; set; }
    }
}
