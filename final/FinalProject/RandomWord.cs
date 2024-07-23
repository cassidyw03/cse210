using System;

public class RandomWord
{
    private string _randomWord;
    private Dictionary<string, string> wordList;
    private Random random = new Random();
    public RandomWord()
    {
        myDictionary = new Dictionary<string, string>()
        {
            {"arbitrary", "based on random choice or personal whim, rather than any reason or system"},
            {"baboon", "a type of monkey"}, 
            {"chrysanthemum", "a type of flower"},
            {"dumplings", "an Asian appetizer"},
            {"engraving", "the process of cutting or carving a design onto a hard surface"},
            {"fungi", "often grouped with mold"},
            {"gypsies", "traditionally itinerant people who originated in northern India and now live chiefly in Europe and in smaller numbers throughout the world"},
            {"hymns", "music sung at church"},
            {"icelandic", "relating to Iceland or its language"},
            {"jolly", "the attitude of Santa Clause"},
            {"kaleidoscope", "a toy"}
            {"laudatory", "expressing praise and commendation"}
        };
    }

    public string GetRandomValue()
    {
        return myDictionary.ElementAt(random.Next(myDictionary.Count)).Value;
    }

    public string GetRandomKey()
    {
        _randomWord = randomWord;
        randomWord =  myDictionary.ElementAt(random.Next(myDictionary.Count)).Key;
        return randomWord;
    }

    public string GetValueFromRandomKey()
    {
        string randomKey = GetRandomKey();
        return myDictionary[randomKey];
    }

    }

    
    
    // public string GetRandomWord()
    // {
    //     return wordDictionary.Keys.ElementAt(random.Next(wordDictionary.Count));
    // }

    // public KeyValuePair<string, string> GetRandomWordWithDefinition()
    // {
    //     return wordDictionary.ElementAt(random.Next(wordDictionary.Count));
    // }

