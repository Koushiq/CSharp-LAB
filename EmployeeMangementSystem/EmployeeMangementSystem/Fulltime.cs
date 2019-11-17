using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangementSystem
{
    abstract class Fulltime : Employee
    {
        private double bonus;
        
        public Fulltime(string name, DateTime joiningDate, double[] salary, double[] bonus) : base(name,joiningDate,salary)
        {
            base.Id += "-F";
            this.Bonus = base.CalculateMoney(bonus);
            this.BonusTax = this.GetTax();
        }
        public double  Bonus { get; set; }
        public double BonusTax { get; set; }

        public  double GetTax()
        {
            double tax = this.Bonus;
            tax = (8*tax) / 100;
            return tax;

        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Employee Bonus " + this.Bonus);
            Console.WriteLine("Employee Bonus Tax  " + this.GetTax());
        }

        

    }
}
