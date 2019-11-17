using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangementSystem
{
     abstract class Employee
    {
       
        private string id;
        private Double salary;
        private static int counter=000;
        public double SalaryTax { get; set; }
        public Employee(string name,DateTime joiningDate,double [] salary)
        {
            counter++;
            this.Name = name;
            this.Id += "E-" + counter.ToString();
            this.JoiningDate = joiningDate;
            this.Salary = CalculateMoney(salary);
            this.SalaryTax = this.GetTax();
        }


        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }

        public string Id 
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public double Salary
        {   get { return this.salary; }
            set { this.salary = value; }
        }

        public Double CalculateMoney(double [] salary)
        {
            double sum = 0;
            foreach (double i in salary)
            {
                sum += i;
            }
            return sum;
        }
        public double GetTax()
        {
            double tax = this.Salary;
            tax = tax / 2;
            tax = (10 * tax) / 100;
            return tax;
        }

        public virtual  void ShowDetails()
        {
            Console.WriteLine("\nShowing employee information -----");
            Console.WriteLine("Employee name " + this.Name);
            Console.WriteLine("Employee id " + this.Id);
            Console.WriteLine("Employee joining date " + this.JoiningDate);
            Console.WriteLine("Employee Salary " + this.Salary);
            Console.WriteLine("Employee Salary Tax " + this.SalaryTax);
        }


    }
}
