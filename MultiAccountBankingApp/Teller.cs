using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiAccountBankingApp
{
    class Teller
    {
        internal void MainMenu()
        {
            Console.WriteLine("Please choose a transaction: ");
            Console.WriteLine("1  |  Client Information");
            Console.WriteLine("2  |  Account Balances");
            Console.WriteLine("3  |  Withdraw");
            Console.WriteLine("4  |  Deposit");
            Console.WriteLine("5  |  Exit Transaction Menu");
 
        }

        internal void WithDrawMenu()
        {
            Console.WriteLine("Withdraw from which account?");
            Console.WriteLine("1  |  Checking");
            Console.WriteLine("2  |  Savings");
            Console.WriteLine("3  |  Reserve");
        }

         internal void DepositMenu()
        {
            Console.WriteLine("Deposit to which account?");
            Console.WriteLine("1  |  Checking");
            Console.WriteLine("2  |  Savings");
            Console.WriteLine("3  |  Reserve");

        }


        //Methods common to all 3 account types
        //withdraw

        //balance - withdrawal (check for overdraft)
        //first method gets user input for withdrawal amount, returns amt
        //second method does math
        /*public decimal WithDrawAmount()
        {
            Console.WriteLine("How much to withdraw?");
            decimal withdrawAmt = decimal.Parse(Console.ReadLine());
            return withdrawAmt;
        }*/

    }
}
