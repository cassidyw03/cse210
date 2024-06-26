using System.Runtime.InteropServices;

class Menu
{   
    // Array of menu items
    private string[] menuItems = {
        "Breathing Activity",
        "Reflecting Activity",
        "Listing Activity",
        "Quit"
    };

    // Method to choose and run menu options
    public bool ChooseAndRun()
    {
        // Display menu options
        Console.WriteLine("\nMenu Options:");
        for (int i = 0; i < menuItems.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {menuItems[i]}");
        }
        
        // Read user's choice
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        // Execute the chosen option
        switch (choice)
        {
            case 1:
                // Create an instance of Breathing class and run it
                Animation breathAnim = new Animation('.', 10, 1000);
                Breathing breath = new Breathing("Breath In", "Breath Out", "Welcome to the Breathing Activity!", "This activity will help you relax and clear your mind as you focus on your breathing.", 3000, breathAnim, 500);
                // took out endMessage as parameter above 
                breath.Run();
                break;
            // case 2:
            //     // Create an instance of Reflecting class and run it
            //     Reflecting reflecting = new Reflecting();
            //     reflecting.Run();
            //     break;
            // case 3:
            //     // Create an instance of Listing class and run it
            //     Listing listing = new Listing();
            //     listing.Run();
            //     break;
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