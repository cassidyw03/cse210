// notes from class and class work!
// class Program
// {
//     static void Main(string[] args)
//     {
//         int action = 0;
//         Journal journal = new Journal();

//         Console.WriteLine("\n *****Welcome to your Journal app!***** \n");
//         List<string> menu = ["Write", "Display", "Load", "Save", "Quit"];

//         // declare a variable in line (i), start at 0, lists start at 0, condition is in the middle, COUNT is like .length
//         for (int i = 0; i < menu.Count; i++)
//         {
//             Console.WriteLine($"{i+1}. {menu[i]}");
//         }

//         int choice = int.Parse(Console.ReadLine()); 
//         // int instead of string stops 
//         // assume perfect input
//         Console.WriteLine($"You chose {menu[choice - 1]}");

//         // switch is a simplified if tree
//         // switch example
//         // switch (choice)
//         // {
//         //     case 1;
//         //         Console.WriteLine("Write");
//         //         break;
//         // }


using System;
using System.IO;

namespace ConsoleApplication1

{
    class Program
    {

        static void Main(string[] args)
        {
            int action = 0;
            Console.Write("\n*****JOURNALING IS SO FUN :) *****\n");
            // Create new journal reference/list
            Journal journal = new Journal();
            Prompt jp = new Prompt();

            while (action != 5)
            {
                // Ask for user input (1-5)
                //Call Choices
                action = Choices();
                String fileName;
                switch (action)
                {
                    case 1:
                        // Write Journal Entry
                        string prompt = jp.GetPrompt();
                        DateTime now = DateTime.Now;
                        
                        Entry entry = new Entry(prompt, now.ToShortDateString());

                        Console.Write($"{prompt}\n");
                        Console.Write(">>> ");
                        string userEntry = Console.ReadLine();
                        entry.SetMessage(userEntry);

                        journal.addEntry(entry);

                        Console.WriteLine("Choice 1 Completed!");
                        break;
                    case 2:
                        // Display Journal Entries
                        journal.DisplayJournal();
                         Console.WriteLine("Choice 2 Completed!");
                        break;
                    case 3:
                        // Load text file
                        Console.WriteLine("File Name? >>>");
                        fileName = Console.ReadLine();
                        journal.LoadFromFile(fileName);
                        Console.WriteLine("Choice 3 Completed!");
                        break;
                    case 4:
                        Console.WriteLine("File Name? >>>");
                        fileName = Console.ReadLine();
                        journal.SaveToFile(fileName);
                        Console.WriteLine("Choice 4 Completed!");
                        break;
                    case 5:
                        // Quit
                        Console.WriteLine("\nEXIT!\n");
                        break;
                    default:
                        Console.WriteLine($"\nINVALID");
                        break;
                }
            }
        }

        static int Choices()
            // Method to display choices to user
        {
            string choices = @"
    Please select one of the following choices:
    1. Write
    2. Display
    3. Load
    4. Save
    5. Quit
    What would you like to do? ";

            Console.Write(choices);
            string userInput = Console.ReadLine();
            int action = 0;
            // This block catches any non integer values that are entered
            action = int.Parse(userInput);

            while (true)
            {
                try
                {
                    action = int.Parse(userInput);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    userInput = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    userInput = Console.ReadLine();
                }
            }

            return action;
        }
    }
}

