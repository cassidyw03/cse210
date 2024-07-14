using Internal;
using System;

class CalculatorFormat 
{
    private double accountAmount;

    public CalculatorFormat (double startingBalance)
    {
        accountAmount = startingBalance;
    }

    public double accountAmount
    {
        get {return accountAmount;}
        set {accountAmount = value + MoneyInput(value);}
    }

    public double MoneyInput(double value)
    {
        Console.WriteLine("Input your income for the month:    ");
        return income = double.Parse(Console.ReadLine());
        
    }

    public double SavingsInput(double value)
    {
        Console.WriteLine("Input your expenditures below... ");
        Console.WriteLine("");
        Console.WriteLine("Tithing (mark y for yes to paying tithing or n for no to paying tithing): ");
        Console.WriteLine("Rent:    ");
        Console.WriteLine("Electrical and water bill:   ");
        Console.WriteLine("Groceries:   ");
        Console.WriteLine("Insurances:  ");
        Console.WriteLine("Gas money:   ");
        Console.WriteLine("Miscellaneous:   ");
        Console.WriteLine("Set Aside Savings:   ");
        // extra cash should output after inputs are set
        // create try catch for if the expenditures ever go over the income
    }
}