public class ChecklistGoal : Goals {
// what is the name of the goal:
    // give a short description of it:
    // how many points are associated with this goal:
    // how many times does this goal ned to be accomplished for a bonus: 
    // how much is the bonus for accomplishing it the alloted amount: 


    // specific attribute of Checklist Goals:
    // shows currently completed amount until completion (i.e. 0/5)
    private string _typeOfGoal;
    private int _amountCompleted = 0; 
    private int _target;
    private int _bonus;

    private bool _isComplete = false;

    public ChecklistGoal(string name, string description, int points, string goal, int target, int bonus) : base(name, description, points)
    {
        _typeOfGoal = goal;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (IsComplete() && GetAmountCompleted() == _target)
        {
            AddSetPointToCurrentPoint();
            SetCheckMark();
        }
        else
        {
            AddSetPointToCurrentPoint();
            SetAmountCompleted();
            _isComplete = false;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"{GetCheckMark()} {_name} - {_description} -- Progress status {GetAmountCompleted()}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_typeOfGoal}: {_name} | {_description} | {_points} | {_bonus} | {_target} | {GetAmountCompleted()} | {IsComplete()}";
    }

    public void SetAmountCompleted()
    {
        _amountCompleted++;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public override void CompleteGoal()
    {
        _isComplete = true;
    }

    public void AddSaveAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }

}
