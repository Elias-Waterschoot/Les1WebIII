﻿using Banking2x.Models.Domain;
using System;

namespace Banking2x
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBA = new BankAccount("123-12312312-99");
            Console.WriteLine($"Account {myBA.AccountNumber} created...");
            Console.WriteLine($"Balance is currently {myBA.Balance} Euro");
            Console.WriteLine($"Withdrawcost is {BankAccount._withdrawCost} Euro");

            BankAccount myOtherBA = new BankAccount("123-12312312-99",50);
            Console.WriteLine($"Other Account {myOtherBA.AccountNumber} created...");
            Console.WriteLine($"Balance is currently {myOtherBA.Balance} Euro");

            myBA.Deposit(1000);
            Console.WriteLine($"Balance is currently {myBA.Balance} Euro");
            myBA.Deposit(200);
            Console.WriteLine($"Balance is currently {myBA.Balance} Euro");
            myBA.Withdraw(100);
            Console.WriteLine($"Balance is currently {myBA.Balance} Euro");
            Console.ReadLine();
        }
    }
}
