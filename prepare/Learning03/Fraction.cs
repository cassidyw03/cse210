using System;

public class Fraction {
    private int topNumber;
    private int bottomNumber;

    public Fraction()
    {
        topNumber = 1;
        bottomNumber = 1;
    }

    public Fraction(int passed_in_top)
    {
        topNumber = passed_in_top;
        bottomNumber = 1;
    }

    public Fraction(int top, int bot)
    {
        topNumber = top;
        bottomNumber = bot;
    }

    // public string GetLine()
    // {
    //     string line = $"{topNumber}/{bottomNumber}";
    //     return line;
    // }

    public string GetFractionString()
    {
        string text = $"{topNumber}/{bottomNumber}";
        return text;
    }

    public double GetDecimalValue()
    {
        // returning a double, not a string!
        return (double)topNumber / (double)bottomNumber;
    }
}