using System;

class Program
{



    static void Main(string[] args)
    {
        // Menu menu = new Menu();

        // List<bool> action = new List<bool> {true};

        // foreach (bool action in actions)
        // {
        //     if (!menu.ChooseAndRun())
        //     {
        //         break;
        //     }
        // }

        Console.WriteLine("Welcome to Mindfulness! We offer 3 mindfulness activities to unwind with!  :)  Choose below!\n");

        Menu menu = new Menu();

        bool keepRunning = true;
        while(keepRunning)
        {
            // Call the ChooseAndRun method of the menu and store the result in keepRunning.
            keepRunning = menu.ChooseAndRun();
        }

        // Animation breathAnim = new Animation('.', 10, 1000);
        // Breathing breath = new Breathing("Breath In", "Breath Out", "BREATHING ACTIVITY", "THIS IS THE BREATHING ACTIVITY DESCRIPTION", "END MESSAGE", 3000, breathAnim, 500);
        // Console.WriteLine("Write \"breathe\"");
        // string choice = Console.ReadLine();
        // if (choice == "breathe") {
        //     breath.Run();
        // }

        Console.WriteLine("Done!");
    }
}