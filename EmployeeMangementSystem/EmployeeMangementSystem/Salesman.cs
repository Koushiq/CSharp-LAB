using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangementSystem
{
    class Salesman : Fulltime
    {
        private double commission;
        private double CommissionTax;
        public Salesman(string name, DateTime joiningDate, double[] salary, double[] bonus, double[] commission)
            : base(name, joiningDate, salary,bonus)
        {
            base.Id += "S";
            this.Commission=base.CalculateMoney(commission);
            this.CommissionTax = this.GetTax();
        }
        public double Commission { get; set; }

        public  double GetTax()
        {
            double tax = this.Commission;
            tax = (5 * tax) / 100;
            return tax;
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Employee Commission " + this.Commission);
            Console.WriteLine("Employee Commission Tax  " + this.GetTax());
            Console.WriteLine("Employee Total Tax " + ( base.SalaryTax + base.BonusTax + this.CommissionTax));
        }

       
    }
}
