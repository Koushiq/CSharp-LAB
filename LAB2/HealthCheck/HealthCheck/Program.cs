using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            DateOfBirth dateOfBirthOne = new DateOfBirth(10,20,2019);


            DateOfBirth dateOfBirthTwo = new DateOfBirth(5, 10, 2029); ;
            

            DateOfBirth dateOfBirthThree =new DateOfBirth(1,20,2019);
            

            DateOfBirth dateOfBirthFour = new DateOfBirth(3,10,2019);

            Human humanOne = new Human();
            humanOne.SetId(100);
            humanOne.SetName("Koushiq");
            humanOne.SetDateOfBirth(dateOfBirthOne);
            humanOne.SetBpH(120);
            humanOne.SetBpL(90);
            humanOne.SetGender("Male");
            humanOne.SetHeartRate(90);
            humanOne.ShowAll();

            Human humanTwo = new Human(300,"Oracle",dateOfBirthTwo,101,75,"Female",85);
            humanTwo.ShowAll();

            Human humanThree = new Human(200, "Poison Ivy", dateOfBirthThree, 111, 75, "Female", 85);
            humanThree.ShowAll();

            Human humanFour = new Human(400, "Alfred", dateOfBirthFour, 135, 95, "Male", 95);
            humanFour.ShowAll();


        }
    }
}
