using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiAccountBankingApp
{
    class Client
    {
        //Fields
        //Client Name
        private string clientName = "Scrooge McDuck";
        //Client DOB
        private string dateOfBirth = "5/12/1965";
        //Client Customer Since
        private string customerSince = "11/1/2001";
        //Client Address
        private string address = "12132 Wheredat Way, Springfield, OH  99999";

        //Properties 
        //Client Name
        
        internal string ClientName
        {
            get { return this.clientName; }
            set { this.clientName = value; }
        }
       //Client DOB
       internal string DateOfBirth
        {
            get { return this.dateOfBirth; }
           // set { this.dateOfBirth = value; } not allowing change within this program
        }
       //Client Customer Since
       internal string CustomerSince
        {
            get { return this.customerSince; }
        }
       //Client Address
       internal string ClientAddress
        {
            get { return this.address; }
            set { this.ClientAddress = value; }
        }

        //methods
        //view client info
        internal void ViewClientInfo()
        {
            Console.WriteLine("");
            Console.WriteLine("Customer Name: {0}", ClientName);
            Console.WriteLine("DOB: {1}", ClientName, DateOfBirth);
            Console.WriteLine("Customer Since: {0}", CustomerSince);
            Console.WriteLine("Customer Address: {0}",  ClientAddress);
            Console.WriteLine("");
        }
    }
}
