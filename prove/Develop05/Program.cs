using System;
// using Newtonsoft.Json;
// using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("...*...*...*...Welcome to the Goal Setting App!...*...*...*... ");

        GoalHolder goalHolder = new ();
        goalHolder.ChooseAndRun();
        // bool continueRunning = true;



        // Serialization stretch!
        // while (continueRunning)
        // {
        //     continueRunning = goalHolder.ChooseAndRun();
        // }

        // {
        // GoalsList goals;

        // if (File.Exists("roster.json")) {
        //     Console.WriteLine("Deserialized List");
        //     Console.WriteLine("-------------------");
        //     string json = File.ReadAllText("list.json");
        //     goals = JsonConvert.DeserializeObject<GoalsList>(json);
        // } else {
        //     Console.WriteLine("Creating New List");
        //     Console.WriteLine("-------------------");
        //     goals = new GoalsList();

        //     // GoalHolder student1 = new Goals("Alice", 16, "John W. North High School");
        //     // GoalHolder student2 = new Goals("Bob", 17, "Madison High School");
        //     // GoalHolder teacher1 = new Goals("Charlie", 35, "John W. North High School");
        //     // GoalHolder teacher2 = new Goals("Diana", 40, "Madison High School");

        

        //     goals.Add(Goals);
        //     // ?????????
        //     // goals.Add(student2);
        //     // goals.Add(teacher1);
        //     // goals.Add(teacher2);

        //     // string json = JsonConvert.SerializeObject(roster, Formatting.Indented);
        //     string json = JsonConvert.SerializeObject(goals);
        //     File.WriteAllText("list.json", json);
        // }

        // Console.WriteLine(goals);
    // }
       


    }
}