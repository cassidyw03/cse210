public abstract class Activity {
    protected string _title;
    protected string _endMessage;
    protected string _description;
    protected int _duration;
    protected int _timeCount;
    protected Animation _anim;
    protected int _loadms;

    public Activity(string title, string description, string endMessage, int duration, Animation anim, int loadms)
    {
        _title = title;
        _endMessage = endMessage;
        _description = description;
        _duration = duration;
        _anim = anim;
        _loadms = loadms;
    }

    public void DisplayTitle() {
        Console.WriteLine(_title);
    }

    public abstract void DisplayDescription();

    public abstract void RunPrompts();

    public void DisplayEndMessage() {
        Console.WriteLine(_endMessage);
    }

    public abstract void Run();
}