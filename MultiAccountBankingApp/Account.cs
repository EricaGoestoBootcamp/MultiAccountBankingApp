using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiAccountBankingApp
{
    internal enum AccountType { Checking, Savings, Reserve };

    abstract class Account
    {
             
        //properties

        //Account #
        //public virtual string AccountNumber { get; set; }

        //Balance
        public virtual decimal Balance { get; set; } 

        //AccountType
        public virtual Enum AccountCSR { get; set; } = AccountType.Checking;




    }
}
