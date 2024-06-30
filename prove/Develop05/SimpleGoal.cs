

public class SimpleGoal : Goals
{
    // what is the name of the goal:
    // give a short description of it:
    // how many points are associated with this goal:
    private string _typeOfGoal;
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points, string goal) : base(name, description, points)
    {
        _typeOfGoal = goal;
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
        return $"{_typeOfGoal}: {_name} | {_description} | {_points} | {IsComplete()}";
    }
}