using System.CodeDom.Compiler;
using System.Collections.ObjectModel;

public abstract class Activity {
    protected string _title;
    protected string _description;
    protected int _duration;
    // protected int _timeCount;
    // protected Animation _anim;
    // protected int _loadms;

    // public Activity(string title, string description, string endMessage, int duration, Animation anim, int loadms)
    // // took out string endMessage here
    // {
    //     _title = title;
    //     _endMessage = endMessage;
    //     _description = description;
    //     _duration = duration;
    //     _anim = anim;
    //     _loadms = loadms;
    // }

    public Activity()
    {
        _title = "";
        _description = "";
        _duration = 1;
    }

    public void DisplayTitle() {
        Console.WriteLine(_title);
    }

    public void DisplayDescription(string description)
    {
        _description = description;
    }

    public void Display()
    {
        Console.WriteLine($"Welcome to the {_title} Activity!");
        Console.WriteLine();
        Console.WriteLine(_description);
    }

    public void TimeInput ()
    {
        Console.WriteLine();
        Console.WriteLine("Type how long (in seconds), you would like to do this activity:  ");
        string durationString = Console.ReadLine();
        SetDuration(Convert.ToInt32(durationString));
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    // public abstract void RunPrompts();

    // public void DisplayEndMessage() {
    //     Console.WriteLine(_endMessage);
    // }

    public abstract void Run()
    {
        Console.Clear();
        Display();
        TimeInput();

    }

    public void EndActivity(Animation anim)
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine($"Well done!");
        _anim = anim;
        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of the {_title} ");
        _anim = anim;
    }
}