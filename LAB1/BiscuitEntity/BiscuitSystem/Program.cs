using System;

namespace BiscuitSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OurDate biscuitOneProductionDate = new OurDate(10, 3, 19);
            OurDate biscuitOneExpireDate=new OurDate (13,3,19);
            Biscuit biscuitOne = new Biscuit();
            biscuitOne.SetBiscuitName("Parle G");
            biscuitOne.SetCompanyName("Parle Com");
            biscuitOne.SetProductionDate(biscuitOneProductionDate);
            biscuitOne.SetExpireDate(biscuitOneExpireDate);
            biscuitOne.SetPrice(322.22);
            biscuitOne.DisplayInfo();


            OurDate biscuitTwoProductionDate = new OurDate(10, 3, 19);
            OurDate biscuitTwoExpireDate = new OurDate(13, 3, 19);
            Biscuit biscuitTwo = new Biscuit("Oreo","Nabisco",biscuitTwoProductionDate,biscuitTwoExpireDate,199.55);
            biscuitTwo.DisplayInfo();
        }
    }
}
