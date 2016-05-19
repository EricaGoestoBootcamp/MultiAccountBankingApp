using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiAccountBankingApp
{
    class Checking:Account
    {
        //Random # Generator
        //public Random Rnd { get; set; } = new Random();

        //Account #
        public  string AccountNumber { get; set; }

        //Balance
        public override decimal Balance { get; set; } = 711.11M;

        //AccountType
        public override Enum AccountCSR { get; set; } = AccountType.Checking;


        //get random number
        /*  public string GetAccount()
         {
             //local variable
             double randomNumber = Rnd.Next(10000000, 99999999);
             //since we don't want to do math on the acct #, returning as string
             return randomNumber.ToString(); 
         }  */


        internal decimal ViewBalance()
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
                Console.WriteLine("New balance in acct {1} is {0}", Balance, AccountNumber);
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

        }
    }
}
