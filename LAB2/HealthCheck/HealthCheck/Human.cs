using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCheck
{
    struct DateOfBirth
    {
        private int month;
        private int date;
        private int year;
        public DateOfBirth(int month,int date,int year)
        {
            if (month >= 1 && month <= 12 && date >= 1 && date <= 31 && year >= 1950)
            {
                this.month = month;
                this.date = date;
                this.year = year;
            }
            else
            {
                this.date = 1;
                this.month = 1;
                this.year = 2019;
            }
            
        }

        public string GetDate()
        {
            string str = "";
            str += this.month + "-" + this.date + "-" + this.year;
            return str;
        }
       

        
    }
    class Human
    {
        private int id;
        private string name;
        private DateOfBirth dateOfBirth;
        private int bpH;
        private int bpL;
        private string gender;
        private int heartRate;
        public Human()
        {

        }
        public Human(int id,string name,DateOfBirth dateOfBirth,int bpH,int bpL,string gender,int heartRate)
        {
            SetId(id);
            SetName(name);
            SetDateOfBirth(dateOfBirth);
            SetBpH(bpH);
            SetBpL(bpL);
            SetGender(gender);
            SetHeartRate(heartRate);
        }

        public int  GetId()
        {
            return this.id;
        }
        public string  GetName()
        {
            return this.name;
        }
        
        public int  GetBpH()
        {
            return this.bpH;
        }
        public int  GetBpL()
        {
            return this.bpL;
        }
        public string GetGender()
        {
            return this.gender;
        }
        public int  GetHeartRate()
        {
            return this.heartRate;
        }

        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        
        public void SetBpH(int bpH)
        {
            this.bpH = bpH;
        }
        public void SetBpL(int bpL)
        {
            this.bpL = bpL;
        }
        public void SetGender(string gender)
        {
            if (gender.Equals("Male") || gender.Equals("Female"))
            {
                this.gender = gender;
            }
            else
            {
                this.gender = "N/A";
            }
            
        }
        public void SetHeartRate(int heartRate)
        {
            this.heartRate = heartRate;
        }
        public void SetDateOfBirth(DateOfBirth dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }
        public void ShowAll()
        {
            Console.WriteLine("Id is {0}",this.GetId());
            Console.WriteLine("Name is {0}",this.GetName());
            Console.WriteLine("Date of birth {0}", this.dateOfBirth.GetDate());
            Console.WriteLine("Blood Pressure High {0}",this.GetBpH());
            Console.WriteLine("Blood Pressure Low {0}", this.GetBpL());
            Console.WriteLine("Gender {0}",this.GetGender());
            Console.WriteLine("HeartRate is {0}",this.GetHeartRate());
            ValidateBP();
            ValidateHeartRate();
            Console.WriteLine();


        }
        public void ValidateBP()
        {
            if (this.GetGender().Equals("Male"))
            {
                if (this.GetBpH() >= 110 && this.GetBpH() <= 120 && this.GetBpL() >= 80 && this.GetBpL() <= 90)
                {
                    Console.WriteLine("{0} has healthy BP", this.GetName());
                }
                else
                {
                    Console.WriteLine("{0} does not have healthy BP", this.GetName());
                }
            }
            else if (this.GetGender().Equals("Female"))
            {
                if (this.GetBpH() >= 100 && this.GetBpH() <= 110 && this.GetBpL() >=70 && this.GetBpL() <= 80)
                {
                    Console.WriteLine("{0} has healthy BP", this.GetName());
                }
                else
                {
                    Console.WriteLine("{0} does not have healthy BP", this.GetName());
                }
            }
            else
            {
                Console.WriteLine("Gender not defined");
            }
        }

        public void ValidateHeartRate()
        {
            if (this.GetHeartRate() >= 70 && this.GetHeartRate() <= 90)
            {
                Console.WriteLine("{0} has healthy HeartRate", this.GetName());
            }
            else
            {
                Console.WriteLine("{0} does not have healthy HeartRate", this.GetName());
            }
        }
    }
}
