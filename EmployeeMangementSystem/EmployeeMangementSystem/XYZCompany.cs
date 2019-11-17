using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangementSystem
{
    class XYZCompany
    {
        private static Employee [] employee = new Employee[5];
        private static int index=0;
        
        public static void AddEmployee(Employee e)
        {
            if (index < 5)
            {
                
                employee[index] = e;
                index++;
                
            }
            else
            {
                Console.WriteLine("max Reached");
            }
        }
        public static void DeleteEmployee(string id)
        {
            if (SearchEmployee(id) == -1)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                employee[SearchEmployee(id)] = null;
                Console.WriteLine("Deleted");
            }
            
        }

        public static int  SearchEmployee(string id)
        {
           
            int i = 0;
            while (i < index)
            {
                if(employee[i].Id.Equals(id))
                {
                    return i;
                }
                i++;
            }
            return -1;
            
        }
        public static void AllEmployeeDetails()
        {
            int i=0;
            while (i < index)
            {
                employee[i].ShowDetails();
                i++;
            }
        }
    }
}
