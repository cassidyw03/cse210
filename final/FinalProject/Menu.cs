using System;

class Menu
{   
    // Array of menu items
    private string[] menuItems = {
        "Start Word Guessing Game",
        "Instructions",
        "Go Back to Menu",
        "Quit"
    };

    // Method to choose and run menu options
    public bool ChooseAndRun()
    {
        // Display menu options
        Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
        Console.WriteLine("\nMenu Options:");
        for (int i = 0; i < menuItems.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {menuItems[i]}");
        }
        Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
        
        // Read user's choice
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        // Execute the chosen option
        switch (choice)
        {
            case 1:
                // Word game
                WordGame game = new WordGame();
                game.StartGame();


                break;
            case 2:
                Instructions instruct= new Instructions();

            case 3:
                // Go back to main menu 
                Console.Clear();
                
                break;
            case 4:
                // Quit the program
                Console.WriteLine("Goodbye!");
                return false;
            default:
                // Invalid option, display error message
                Console.WriteLine("Invalid option please try again.");
                break;
        }
        return true;
    }
}