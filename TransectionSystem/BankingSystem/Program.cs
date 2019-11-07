using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts = new Account[4];
            accounts[0] = new SavingsAccount("A-203", "Bruce Wayne", new DateTime(2019, 11, 22),2000,"5");
            accounts[1] = new SavingsAccount("A-204", "Harvey Dent", new DateTime(2019, 11, 22), 1500, "5");
            accounts[2] = new CurrentAccount("A-205", "Alfred Pennywort", new DateTime(2019, 11, 22), 3000);
            accounts[3] = new CurrentAccount("A-206", "Oracle Gordon", new DateTime(2019, 11, 22), 200);

            foreach(Account acc in accounts)
            {
                acc.ShowInfo();
            }

            accounts[0].Deposit(500);
            accounts[0].ShowInfo();
            accounts[1].Withdraw(200);
            accounts[1].ShowInfo();

            Account.Transfer(accounts[2], accounts[1], 3000);

            foreach (Account acc in accounts)
            {
                acc.ShowInfo();
            }


        }
    }
}
