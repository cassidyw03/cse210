public class Assignment {
    private string studentName;
    private string topic;

    public Assignment(string name, string top)
    {
        studentName = name;
        topic = top;
    }

    public string GetName()
    {
        return studentName;
    }

    public string GetTopic()
    {
        return topic;
    }
    public string GetSummary()
    {
        return studentName + " - " + topic;
    }


}