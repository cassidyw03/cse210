using System.ComponentModel;
using System.Diagnostics;
using Microsoft.Win32;

class Goals {
    private string _name;
    private int _points;
    private string _description;
    private int _yourPoints = 0;
    private bool _completion;
    protected string _checkBox = "[ ]";

// constructor!
    public Goals(string name, string description, int points)
    {
        this._name = name;
        this._description = description;
        this._completion = false;
        this._points = points;
    }

    // public Goals()
    // {
    //     _name = "Test Name!";
    //     _description = "Test Description";
    //     _points = 50000;
    //     _completion = false;
    // }

 
    public abstract void RecordEvent();
    
    public abstract bool IsComplete();
    // sets IsComplete to true
    public virtual void CompleteGoal()
    {

    }

        public string GetGoalName()
    {
        return _name;
    }

    public int GetYourPoints()
    {
        return _yourPoints;
    }

    public int GetSetPoints()
    {
        return _points;
    }

    public void AddSetPointToCurrentPoint()
    {
        _yourPoints += _points;
    }

    public void SetCheckMark()
    {
        string newCheckBox = _checkBox.Replace(_checkBox, "[✓]");
        _checkBox = newCheckBox;
    }

    public string GetCheckMark()
    {
        return _checkBox;
    }
    
}