using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class CurrentAccount:Account
    {
        public CurrentAccount(string id, string name, DateTime date, double balance) : base(id, name, date, balance)
        {
            
        }
    }
}
