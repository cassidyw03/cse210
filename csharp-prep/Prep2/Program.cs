using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage?");
        string percentage = Console.ReadLine();
        int parsed_percentage = int.Parse(percentage);

        if (parsed_percentage >= 90)
        {
            Console.WriteLine("You have an A!");
        }

        else if (parsed_percentage >= 80)
        {
            Console.WriteLine("You have a B!");
        }

        else if (parsed_percentage >= 70)
        {
            Console.WriteLine("You have a C.");
        }

        else if (parsed_percentage >= 60)
        {
            Console.WriteLine("You have a D.");
        }

        else{
            Console.WriteLine("You have an F...");
        }

        if (parsed_percentage >= 70)
        {
            Console.WriteLine("You passed!!");
        }

        else 
        {
            Console.WriteLine("You did not pass. But you are not defined by your grades. You are more than that. You are a child of God :)");
        }
    }
}