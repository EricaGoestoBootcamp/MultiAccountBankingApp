using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiAccountBankingApp
{
    class Savings : Account
    {
        
        //Account #
        public  override string AccountNumber { get; set; }

        //Balance
        public override decimal Balance { get; set; } = 700.91M;

        //AccountType
        public override Enum AccountCSR { get; set; } = AccountType.Savings;

        /* internal decimal ViewBalance()
        {
            return Balance;
        }


        internal decimal WithDrawAmount()
        {
            Console.WriteLine("How much to withdraw?");
            decimal withdrawAmt = decimal.Parse(Console.ReadLine());
            return withdrawAmt;
        }

        internal virtual void getWithdraw(decimal withdrawal)
        {
            if (withdrawal > Balance)
            {
                Console.WriteLine("Transaction cancelled, insufficient funds.");
            }
            else
            {
                Balance -= withdrawal;
                Console.WriteLine("New balance in acct {1} is {0}", Balance,AccountNumber);
            }
        }

        //deposit
        internal decimal DepositAmount()
        {
            Console.WriteLine("How much will be deposited?");
            decimal depositAmt = decimal.Parse(Console.ReadLine());
            return depositAmt;
        }

        internal virtual void getDeposit(decimal deposit)
        {
            Balance += deposit;
            Console.WriteLine("New balance in acct {1} is {0}", Balance, AccountNumber);

        } */




    }

}
