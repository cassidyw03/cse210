public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;


    public MathAssignment(string name, string top, string textbookSection, string problems)
        : base(name, top)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

     public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}

