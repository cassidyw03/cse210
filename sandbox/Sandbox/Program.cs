using System;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Bank bank = new Bank();
        // declare the data type and name it in second

        Console.WriteLine($"You have ${bank.GetAccountBalance()}");

        bank.Withdraw();

        Console.WriteLine($"You have ${bank.GetAccountBalance()}");

    }
}