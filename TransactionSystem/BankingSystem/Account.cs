using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Account
    {
        private string id;
        private string name;
        private DateTime date;
        private Double balance;
        public Account(string id,string name,DateTime date,double balance)
        {
            this.Id = id;
            this.Name = name;
            this.Date = date;
            this.Balance = balance;
        }
        public String Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id=value;
            }
        }

        public string Name
        { 
            get
            {
                return this.name; 
            }
            set
            {
                this.name = value ; 
            } 
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }
        public Double Balance 
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public bool Deposit(double amount)
        {
            if (amount >= 0)
            {
                this.balance += amount;
                Console.WriteLine("Deposit Successful");
                return true;
            }
            
            ShowHaultMessage();
            return false;

        }


        public virtual bool Withdraw(double amount)
        {
            if (amount >= 0 && amount>this.balance)
            {
                this.Balance -= amount;
                Console.WriteLine("Withdraw Successful");
                return true;
            }
            ShowHaultMessage();
            return false;

        }

        public static void Transfer(Account sender,Account receiver,double amount)
        {
            if(sender.GetType().Equals(receiver.GetType()))
            {
                if(receiver.Withdraw(amount))
                {
                    sender.Deposit(amount);
                }
            }
            else
            {
                Console.WriteLine("Transaction possible only between same account type !");
            }
        }


        protected void ShowHaultMessage( )
        { 
            Console.WriteLine("Operation not allowed!");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Showing Account Information......\n");
            Console.WriteLine("Account Owner Name " + this.Name);
            Console.WriteLine("Account Id " + this.Id);
            Console.WriteLine("Account Balance " + this.Balance);
            Console.WriteLine("Account Creation Date " + this.Date.ToString("yyyy/MM/dd"));
            
        }
    }
        

}
