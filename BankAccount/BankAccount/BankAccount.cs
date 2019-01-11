using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class BankAccount
    {
        private string name;
        private decimal sold;
        private bool openedAccount;

        public BankAccount()
        {
            this.openedAccount = true;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        
        public decimal Sold
        {
            get
            {
                if (this.openedAccount)
                {
                    return this.sold;
                }
                else
                {
                    Console.WriteLine("This account is inexistent/inactive.");
                    return 0;
                }
            }
        }

        public void Deposit(decimal suma)
        {
            if (this.openedAccount)
            {
                this.sold += suma;
            }
            else
            {
                Console.WriteLine("This account is inexistent/inactive.");
            }
        }

        public void Withdraw(decimal suma)
        {
            if (this.sold >= suma && this.openedAccount)
            {
                 this.sold -= suma;
            }
            else
            {
                Console.WriteLine("Insufficient funds or inexistent/inactive account.");
            }
        }

        public void CloseAccount()
        {
            this.openedAccount = false;
        }

        public override string ToString()
        {
            return "In the account of mr/mrs " + this.Name + "has a sold of:  " + this.Sold + ". ";
        }
    }
}
