using System;

namespace BankAccount
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount cont = new BankAccount();
            cont.Name = "Gina I.";
            Console.WriteLine(cont.Sold);
            cont.Deposit(2500);
            Console.WriteLine(cont.Sold);
            cont.Withdraw(2601);
            cont.Withdraw(2450);
            Console.WriteLine(cont.Sold);
            cont.CloseAccount();
            Console.WriteLine(cont.Sold);
            cont.Deposit(5);
        }
    }
}

