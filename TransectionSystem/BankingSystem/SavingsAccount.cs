using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class SavingsAccount : Account
    {
        private string savingsDuration;
        public SavingsAccount(string id, string name, DateTime date, double balance,string savingsDuration) : base(id,name,date,balance)
        {
            this.SavingsDuration = savingsDuration;
        }
        public string SavingsDuration
        {
            get
            {
                return this.savingsDuration;
            }
            set
            {
                this.savingsDuration = value ; 
            } 
        }

        public override bool Withdraw(double amount)
        {
            if (amount>=0 && this.Balance-amount>500)
            {
                this.Balance -= amount;
                Console.WriteLine("Withdraw Successful");
                return true;
            }
            ShowHaultMessage();
            return false;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Account Savings Duration "+this.SavingsDuration+" year\n");
        }


    }
}
