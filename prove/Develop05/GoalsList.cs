using Newtonsoft.Json;

class GoalsList {

    [JsonProperty] 
    private List<Goals> goalList = new List<Goals>();

    public void Add(Goals goal) {
        goalList.Add(goal);
    }

    public void Remove(Goals goal) {
        goalList.Remove(goal);
    }

    public override string ToString() {
        string result = "";
        int count = 1;
        foreach (Goals goal in goalList) 
        {
            result += count + ". " + goal + "\n";
            count++;
        }
        return result;
    }
}
