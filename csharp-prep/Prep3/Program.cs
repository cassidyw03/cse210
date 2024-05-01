using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // inputmagic number
        // Console.WriteLine("What is the magic number?");
        // int number = int.Parse(Console.ReadLine());

        // random magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        // next is method of Random to generate random number in between 1 and 100

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed the magic number!")
            }
        }
    }
}