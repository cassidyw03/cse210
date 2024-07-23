using System;

public class WrongGuess
{
    string randomValue = myDictionary.Values.Random();
    public void ShowHint(int wrongGuessCount)
    {
        if (wrongGuessCount == 1)
        {
            Console.WriteLine("1 Wrong Guess!");
        }
        else if (wrongGuessCount == 2)
        {
            Console.WriteLine("2 Wrong Guesses!!");
        }
        else if (wrongGuessCount == 3)
        {
            string GetValueFromRandomKey = RandomWord.GetValueFromRandomKey();
            Console.WriteLine("3 Wrong Guesses!!!");
            Console.WriteLine($"Here's a hint!: \n{valueFromRandomKey}");
        }
    }
}