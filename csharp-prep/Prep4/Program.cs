using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> number_list = new List<int>();

        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        
        while (number != 0)
        {
            Console.WriteLine("Enter number: ");
            string num_input = Console.ReadLine();
            number = int.Parse(num_input);

            if (number != 0)
            {
                number_list.Add(number);
            }
        }

        int sum = 0;
        foreach (int numb in number_list)
        {
            sum += numb;
        }
        Console.WriteLine($"The sum is: {sum}.");

        float average = ((float)sum) / number_list.Count;
        Console.WriteLine($"The average is {average}.");

        int max = number_list[0];

        foreach (int numb in number_list)
        {
            if (number > max)
            {
                max = numb;
            }
        }
        Console.WriteLine($"The max is: {max}.");
    }
}

// dotnet run
// dotnet build