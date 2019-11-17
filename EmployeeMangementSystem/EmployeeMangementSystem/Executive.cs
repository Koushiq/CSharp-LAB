using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangementSystem
{
    class Executive : Fulltime
    {
        public double BonusTax { get; set; }

       
        public Executive(string name, DateTime joiningDate, double[] salary, double[] bonus)
            : base(name,  joiningDate, salary, bonus)
        {
            
            base.Id += "E";
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
         
            Console.WriteLine("Employee Total Tax " + (base.BonusTax+base.SalaryTax));
           
        }
       
    }
}
