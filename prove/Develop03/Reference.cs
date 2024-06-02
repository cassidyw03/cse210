using System.Collections.Generic;
namespace ScriptureApp;
public class Reference {
    
    private int chapter;
    private string book;
    private List<int> verses;
    
    public Reference(string b, int c, List<int> vs) {
        verses = vs;
        book = b;
        chapter = c;
    }

    private string VersesToString() {
        string result = "";
        verses.ForEach((verseNum) => result += verseNum.ToString());
        return result;
    } 

    public void Display() {
        Console.Write(string.Format("{0} {1}:{2}", book, chapter, VersesToString()));
    }

}