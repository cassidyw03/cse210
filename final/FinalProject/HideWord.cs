using System;

public class HideWords
{
    public void GetHidden(string randomWord)
    {
        Console.Write("\n");
        foreach (char c in randomWord)
        {
            Console.Write("_");
        }
    }
}