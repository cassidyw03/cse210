using System;

public class Instructions
{
    private string _instructions = "WORD GUESSING GAME INSTRUCTIONS \n*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*\nThis word guessing game is a well known and beloved game by many. Players must guess the secret word by guessing one letter at a time. At the start of the game the word will be hidden. A correct guess will fill in a blank. Find the hidden word to win!\n*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*\n\n*Press Enter to return to the menu*";

    public void GetInstructions()
    {
        Console.CLear();

        Console.Write(_instructions);
        var input = Console.ReadKey()
        if (input.Key ==ConsoleKey.Enter)
        {
            Console.Clear();
        }
    }
}