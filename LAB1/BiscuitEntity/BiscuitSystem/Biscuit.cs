using System;
using System.Collections.Generic;
using System.Text;

namespace BiscuitSystem
{
    struct OurDate
    {
        private byte month;
        private byte date;
        private short year;
        public OurDate(byte month,byte date,short year)
        {
            this.month = month;
            this.date = date;
            this.year = year;

        }
        public byte GetDate()
        {
            return this.date;
        }

        public byte GetMonth()
        {
            return this.month;
        }

        public short GetYear()
        {
            return this.year;
        }


    }
    class Biscuit
    {
        private string biscuitName;
        private string companyName;
        private OurDate productionDate;
        private OurDate expireDate;
        private double price;

        public Biscuit() { }

        public Biscuit(string biscuitName,string companyName,OurDate productionDate,OurDate expireDate,double price)
        {
            this.biscuitName = biscuitName;
            this.companyName = companyName;
            this.productionDate = productionDate;
            this.expireDate = expireDate;
            this.price = price;
        }

        public void SetBiscuitName(string biscuitName)
        {
            this.biscuitName = biscuitName;
        }

        public void SetCompanyName(string companyName)
        {
            this.companyName = companyName;
        }
        public void SetProductionDate(OurDate productionDate)
        {
            this.productionDate = productionDate;
        }
        public void SetExpireDate(OurDate expireDate)
        {
            this.expireDate = expireDate;
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }

        public string GetBiscuitName()
        {
            return this.biscuitName;
        }

        public string GetCompanyName()
        {
            return this.companyName;
        }
        public string GetProductionDate()
        {
            string str = "" ;
            str += productionDate.GetMonth() + "/" + productionDate.GetDate() + "/" + productionDate.GetYear();
            return str;

        }
        public string GetExpireDate()
        {
            string str = "";
            str += expireDate.GetMonth() + "/" + expireDate.GetDate() + "/" + expireDate.GetYear();
            return str;
        }
        public double GetPrice()
        {
            return this.price;
        }



        public void DisplayInfo()
        {
            Console.WriteLine("Biscuit Name = {0}",this.GetBiscuitName());
            Console.WriteLine("Comapany Name = {0}",this.GetCompanyName());
            Console.WriteLine("Production Date = {0}",this.GetProductionDate());
            Console.WriteLine("Expire Date = {0}",this.GetExpireDate());
            Console.WriteLine("MRP = {0}",this.GetPrice());
            Console.WriteLine();
        }


    }
}
