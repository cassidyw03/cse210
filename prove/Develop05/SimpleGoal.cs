using System;

public class SimpleGoal : Goals
{
    // what is the name of the goal:
    // give a short description of it:
    // how many points are associated with this goal:
    private string _type;
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points, string goal) : base(name, description, points)
    {
        _type = goal;
    }

    public override void RecordEvent()
    {
        if (IsComplete())
        {
            AddSetPointToCurrentPoint();
            SetCheckMark();
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void CompleteGoal()
    {
        _isComplete = true;
    }



    public override GetStringRepresentation()
    {
        return $"{_type}: {_name} | {_description} | {_points} | {IsComplete()}";
    }
}