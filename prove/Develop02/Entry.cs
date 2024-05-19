using System;

namespace ConsoleApplication1 {

public class Entry {
    // each entry requires the following

    // private DateTime date;
    private string dateString;
    private string message;
    private string prompt;
    public Entry(string prmt, string ds) 
    {
        dateString = ds;
        prompt = prmt;
    }

    public string GetDateString()
    {
        return dateString;
    }

    public string GetMessage()
    {
        return message;
    }

    public void SetMessage(string msg)
    {
        message = msg;
    }

    public void DisplayEntry()
    {
        Console.Write("*****************************\n");
        Console.Write($"{dateString}: {prompt}\n");
        Console.Write($"{message}\n");
        Console.Write("*****************************\n");
    }

    public string toLine()
    {
        return $"{dateString},%%{prompt}%%{message}";
    }
}
}