public class Breathing : Activity {

    private string _prompt1;
    private string _prompt2;

    public Breathing(string prompt1, string prompt2, string title, string description, string endMessage, int duration, Animation anim, int loadms) 
    : base(title, description, endMessage, duration, anim, loadms) {
        _prompt1 = prompt1;
        _prompt2 = prompt2;
    }

    public override void RunPrompts() {
        
        while (_timeCount < _duration) {
            Console.WriteLine(_prompt1);
            Thread.Sleep(_loadms);
            Console.WriteLine(_prompt2);
            Thread.Sleep(_loadms);
            _timeCount += _loadms;
        }
        
    }

    public override void DisplayDescription() {
        Console.WriteLine(_description);
    }

    public override void Run() {
        DisplayTitle();
        DisplayDescription();
        _anim.Run();
        RunPrompts();
        DisplayEndMessage();

    }
}