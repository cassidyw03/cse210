using System;

class Program
{



    static void Main(string[] args)
    {
         Console.WriteLine("Welcome to Wordlé, a word guessing game!\n");

        Menu menu = new Menu();

        bool keepRunning = true;
        while(keepRunning)
        {
            // Call the ChooseAndRun method of the menu and store the result in keepRunning.
            keepRunning = menu.ChooseAndRun();
        }




    }
}

