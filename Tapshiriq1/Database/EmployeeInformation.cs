using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tapshiriq1.Database
{
    public class EmployeeInformation
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public int InformationID { get; set; }
        public Employee Employee { get; set; }
        public Information Information { get; set; }
    }
}
