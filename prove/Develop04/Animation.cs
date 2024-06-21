public class Animation {
    private char _character;

    private int _num;
    private int _ms;
    private List<string> _charsToWrite; 

    public Animation(char character, int num, int ms) {
        _character = character;
        _num = num;
        _ms = ms;
        _charsToWrite = new List<string>();
        for (int i = 0; i < _num; i++) {
            _charsToWrite.Add(new string(_character, i));
        }
    }

    public static void ClearCurrentConsoleLine()
    {
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth)); 
        Console.SetCursorPosition(0, currentLineCursor);
    }

    public void Run() {
        foreach (string a in _charsToWrite)
        {
            Console.Write(a);
            Thread.Sleep(_ms);
            ClearCurrentConsoleLine();
        }
    }

}