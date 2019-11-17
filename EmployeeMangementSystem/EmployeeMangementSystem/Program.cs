using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2000, 11, 21);
            double[] salary1 = { 2000, 2000, 3000, 3000 };
            Employee employeeOne = new PartTime("Bruce", dt1, salary1);
            employeeOne.ShowDetails();

            DateTime dt2 = new DateTime(2010, 10, 01);
            double[] salary2 = { 5000, 5000, 5000, 5000, 10000 };
            double[] bonus1 = { 500, 500 };
            Employee employeeTwo = new Executive("Clerk", dt2, salary2, bonus1);
            employeeTwo.ShowDetails();

            DateTime dt3 = new DateTime(2001, 10, 20);
            double[] salary3 = { 200, 200, 400, 200 };
            double[] bonus3 = { 100, 100 };
            double[] commission1 = { 50, 50, 30, 30, 40 };
            Employee employeeThree = new Salesman("Tony", dt3, salary3, bonus3, commission1);
            employeeThree.ShowDetails();
            
           
            XYZCompany.AddEmployee(employeeOne);
            XYZCompany.AddEmployee(employeeTwo);
            XYZCompany.AddEmployee(employeeThree);
            XYZCompany.AllEmployeeDetails();
            XYZCompany.SearchEmployee("E-1-P");
            XYZCompany.DeleteEmployee("E-1-P");
        }
    }
}
