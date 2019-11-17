using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangementSystem
{
    class PartTime : Employee
    {
        public PartTime(string name,  DateTime joiningDate, double[] salary)
            : base(name, joiningDate, salary)
        {
            base.Id += "-P";
        }
        
    }
}
