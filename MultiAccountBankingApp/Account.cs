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
             
        //PROPERTIES

        //Account # 
        public virtual string AccountNumber { get; set; }

        //Balance
        public virtual decimal Balance { get; set; } 

        //AccountType
        public virtual Enum AccountCSR { get; set; } = AccountType.Checking;


        //METHODS
        //View balance only
        internal virtual decimal ViewBalance()
        {
            return Balance;
        }


        internal virtual decimal WithDrawAmount()
        {
            Console.WriteLine("How much will be withdrawn?");
            decimal withdrawAmt = decimal.Parse(Console.ReadLine());
            return withdrawAmt;
        }

        internal virtual void getWithdraw(decimal withdrawal)
        {
            if (withdrawal > Balance)
            {
                Console.WriteLine("Transaction cancelled due to insufficient funds.");
            }
            else
            {
                Balance -= withdrawal;
                Console.WriteLine("The new balance in acct {1} is {0}", Balance, AccountNumber);
            }
        }

        //deposit
        internal virtual  decimal DepositAmount()
        {
            Console.WriteLine("How much will be deposited?");
            decimal depositAmt = decimal.Parse(Console.ReadLine());
            return depositAmt;
        }

        internal virtual void getDeposit(decimal deposit)
        {
            Balance += deposit;
            Console.WriteLine("The new balance in acct {1} is {0}", Balance, AccountNumber);

        }


    }
}
