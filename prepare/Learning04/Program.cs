using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        // base assignment object!
        Assignment a1 = new Assignment("Cassidy Whitehead", "Coding Assignment");
        Console.WriteLine(a1.GetSummary());

        // class assignments 

        MathAssignment a2 = new MathAssignment("Reece Mangum", "Managerial Accounting WorkBook", "5.5", "1-10");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Camrie Cox", "English Essay", "Growth and Development in Children ");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}