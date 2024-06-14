using System.Diagnostics;

abstract class Activities {
    private string _activityTitle;
    private string _activityDescription;
    private int _duration;
    private string _endingMessage;

    public Activities(string title, string description, int duration)
    {
    }

    public virtual void LoadAnimation(int seconds = 5, int speed = 200)

    public abstract void RunActivity();

}