using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiAccountBankingApp
{
    class Program
    {
        public static List<Teller> AvailableServices { get; set; } = new List<Teller>();
        public static Random Rnd = new Random();

        static void Main(string[] args)
        {
            //create objects

            Savings savingsAccount = new Savings();
            Reserve reserveAccount = new Reserve();
            Checking checkingAccount = new Checking();
            Teller bankTeller = new Teller();
            Client client = new Client();

            //get savings acct, save to property
            savingsAccount.AccountNumber = GetAccount();
            //get reserve acct #, save to property
            reserveAccount.AccountNumber = GetAccount();
            //Console.WriteLine("This is the reserve acct #, {0} and current balance {1}", reserveAcctNum, reserveAccount.Balance);
            checkingAccount.AccountNumber = GetAccount();
            //Console.WriteLine("savings{0}, reserve{1}, checking{2}", savingsAccount.AccountNumber, reserveAccount.AccountNumber, checkingAccount.AccountNumber);

            //setting variables
            decimal amt;  //used in deposit and withdrawal calcs below

            //MAIN MENU
            do
            {
                bankTeller.MainMenu();
                int menuItem = int.Parse(Console.ReadLine());

                switch (menuItem)
                {
                    case 1:
                        {
                            Console.WriteLine("Viewing client information: ");
                            client.ViewClientInfo();
                            break;
                        }
                    case 2:
                        {
                            //View balances
                            decimal sb = savingsAccount.ViewBalance();
                            decimal rb = reserveAccount.ViewBalance();
                            decimal cb = checkingAccount.ViewBalance();
                            Console.WriteLine("Your current balances are:\r\n  #  Savings: {0} \r\n  #  Checking: {1}  \r\n  #  Reserve {2}", sb, cb, rb);
                            break;
                        }
                    case 3:
                        {
                            //withdraw Menu
                            bankTeller.WithDrawMenu();
                            int menuSelect = int.Parse(Console.ReadLine());
                                switch (menuSelect)
                                {
                                    case 1:
                                    //checking
                                    amt = checkingAccount.WithDrawAmount();
                                    checkingAccount.getWithdraw(amt);
                                        break;
                                    case 2:
                                    //savings
                                    amt = savingsAccount.WithDrawAmount();
                                    savingsAccount.getWithdraw(amt);
                                        break;
                                    case 3:
                                    amt = reserveAccount.WithDrawAmount();
                                    reserveAccount.getWithdraw(amt);
                                        //reserve
                                        break;
                                    default:
                                        Console.WriteLine("Mary had a little lamb");
                                        break;
                                }

                            break;
                        }
                    case 4:
                        {
                            //Deposit funds
                            bankTeller.DepositMenu();
                            int menuSelect = int.Parse(Console.ReadLine());
                                switch (menuSelect)
                                {
                                    case 1:
                                    amt = checkingAccount.DepositAmount();
                                    checkingAccount.getDeposit(amt);
                                        //checking
                                        break;
                                    case 2:
                                    amt = savingsAccount.DepositAmount();
                                    savingsAccount.getDeposit(amt);
                                        //savings
                                        break;
                                    case 3:
                                    amt = reserveAccount.DepositAmount();
                                    reserveAccount.getDeposit(amt);
                                    //reserve
                                    break;

                                    default:
                                        Console.WriteLine(" its fleece was white as snow");
                                        break;
                                }

                            break;
                        }
                    case 5:
                        {
                            //exit
                            Console.WriteLine("Thank you, come again.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("I did not understand your entry.");
                            break;
                        }
                }
                Console.WriteLine("Another Transaction?");
            } while (Console.ReadLine().ToUpper() == ("Y")) ;
        }

                     

        //get random number for account
        internal static string GetAccount()
        {
                            //local variable
                double randomNumber = Rnd.Next(10000000, 99999999);
                //since we don't want to do math on the acct #, returning as string
                return randomNumber.ToString();
        }
    }
}
