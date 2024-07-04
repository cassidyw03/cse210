public class GoalHolder {
    private List<Goals> _goals = new ();
    private int _score;
    private int _count = 0;
    private string _folderPath = "savefolder/";

    public GoalHolder()
    {

    }

    protected string[] menuItems = 
    {
        "Create New Goal",
        "List Goals",
        "Save Goals",
        "Load Goals",
        "Record Event",
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
                CreateGoal();
                break;
            case 2:
                ListGoals();
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                RecordEvent();
                break;
            case 6:
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

    private void DisplayPlayerPoint()
    {
        Console.WriteLine($"\nYou have {_score} points!");
    }

    private void CreateGoal()
    {
        string[] goalOptions = {"Simple Goal", "Eternal Goal", "Checklist Goal"};
        Console.WriteLine($"The types of goals are: 1. {goalOptions[0]}\n 2. {goalOptions[1]}\n 3. {goalOptions[2]}");
        Console.WriteLine("What type of goal do you want to create: ");
        int type = int.Parse(Console.ReadLine()) -1;

        if (type == 0)
        {
            SimpleGoal simpleGoal = new(name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoint(), goal: goalOptions[type]);
            _goals.Add(simpleGoal);
        }
        else if (type == 1)
        {
           EternalGoal eternalGoal = new (name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoint(), goal: goalOptions[type]);
           _goals.Add(eternalGoal);
        }
        else if (type == 2)
        {
            ChecklistGoal checkListGoal = new(name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoint(), goal: goalOptions[type], target: SetCheckListCount(), bonus: SetBonusPoint());
            _goals.Add(checkListGoal);
        }
        else
        {
            Console.WriteLine("❗️Invalid: This option does not exist.");
        }

    }

    private void ListGoals()
    {
        if (_goals.Count != 0)
        {
            foreach (Goals goal in _goals)
        {
            _count ++;
            Console.WriteLine($"{_count}. {goal.GetGoalName}");
        }
        _count = 0;
        }
        else 
        {
            Console.WriteLine("There are no goals in the list. Load your saved goals or create new ones!");
        }
        
    }

    private void ListGoalDetails()
    {
        if (_goals.Count != 0)
        {
            foreach (Goals goal in _goals)
            {
                _count++;
                Console.WriteLine($"{_count}. {goal.GetDetailsString()}");
            }
            _count = 0;
        }
        else 
        {
            Console.WriteLine("There are no goals in the list. Load your saved goals or create new ones!");
        }
    }

    private void RecordEvent()
    {
        ListGoals();
        Console.WriteLine("\n Which goal did you accomplish: ");
        int goalCompleteParse = int.Parse(Console.ReadLine());

        Goals goalDone = _goals[goalCompleteParse - 1];
        goalDone.CompleteGoal();
        goalDone.RecordEvent();
        _score += goalDone.GetYourPoints();

        string message = $"\n Yay! You have earned {goalDone.GetSetPoints} \n You now have {_score} points";
        Console.WriteLine(message);
        // DisplayPlayerPoints();
    }

    private void ListGoalsss()
    {
        ListGoalDetails();   
    }

    private void SaveGoal()
    {
        Console.Write("\nWhat would you like to name the file? : ");
        string fileName = Console.ReadLine();

        using StreamWriter saveGoals = new($"{_folderPath}{fileName}.txt");
        saveGoals.WriteLine(_score);
        foreach (Goals goal in _goals)
        {
            saveGoals.WriteLine(goal.GetStringRepresentation());
        }
        _goals.Clear();
    }






    // setters
    private static string SetGoalName()
    {
        Console.Write("\nWhat is the name of the goal? : ");
        string _goalName = Console.ReadLine();
        return _goalName;
    }

    private static int SetGoalPoint()
    {
        Console.Write("\nEnter the amount of point you want to achieve: ");
        int _goalPoint = int.Parse(Console.ReadLine());
        return _goalPoint;
    }

    private static string SetGoalDescription()
    {
        Console.Write("\nWrite a short description of the goal: ");
        string _goalDescription = Console.ReadLine();
        return _goalDescription;
    }

    private static int SetBonusPoint()
    {
        Console.Write("\nEnter the amount of bonus point you want to achieve for this goal: ");
        int _bonusPoint = int.Parse(Console.ReadLine());
        return _bonusPoint;
    }

    private static int SetCheckListCount()
    {
        Console.Write("\nHow many times do you want to set for this goal to be completed? : ");
        int _checklistCount = int.Parse(Console.ReadLine());
        return _checklistCount;
    }
    
    private List<Goals> ConvertToGoalObjects(string[] param)
    {
        _score = int.Parse(param[0]);
        char colon = ':';
        char pipe = '|';
        int start = 1;
        int end = param.Length;
        param = param.Where((value, index) => index >= start && index <= end).ToArray();

        List<Goals> initialGoal = new();

        foreach (string list in param)
        {
            string[] parts = list.Split(colon);
            string goalName = parts[0].Trim();
            string[] contents = parts[1].Split(pipe);

            if (goalName == "Simple Goal")
            {
                SimpleGoal simpleGoal = new(name: contents[0].Trim(), description: contents[1].Trim(), points: int.Parse(contents[2].Trim()), goal: goalName);
                bool isComplete = bool.Parse(contents[3]);
                if (isComplete) 
                {
                    simpleGoal.SetCheckMark();
                    simpleGoal.CompleteGoal();
                }
                initialGoal.Add(simpleGoal);
            }
            if (goalName == "Eternal Goals")
            {
                EternalGoal eternalGoal = new (name: contents[0].Trim(), description: contents[1].Trim(), points: int.Parse(contents[2].Trim()), goal: goalName);
                initialGoal.Add(eternalGoal);
            }
            if (goalName == "Checklist Goals")
            {
                ChecklistGoal checkListGoal = new(name: contents[0].Trim(), description: contents[1].Trim(), points: int.Parse(contents[2].Trim()), goal: goalName, bonus: int.Parse(contents[3].Trim()), target: int.Parse(contents[4].Trim()));
                bool isComplete = bool.Parse(contents[6]);
                if (isComplete)
                {
                    checkListGoal.SetCheckMark();
                    checkListGoal.CompleteGoal();
                } 
                checkListGoal.AddSaveAmountCompleted(int.Parse(contents[5].Trim()));
                initialGoal.Add(checkListGoal);
            }
        }
        Console.WriteLine("\nFile loaded Successfully ✅");
        return initialGoal;
    }

    

    

}