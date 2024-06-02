using System;
namespace ScriptureApp;
public class Scripture {

    private Reference reference;
    private string scriptureString;
    private List<Word> words = new List<Word>();

    private float RandomHideFloat = 0.6f;
    public Scripture(Reference r, string s) {
        scriptureString = s;
        reference = r;
        string[] split = s.Split(' ');
        foreach (string sp in split)
        {   
            Word w = new Word(sp, true);
            words.Add(w);
        }
    }

    public bool IsExit() {
        bool result = true;
        words.ForEach((word) => {
            if (word.GetVisibility()) {
                result = false;
            }
        });
        return result;
    }

    private void RandomHide() {
        List<Word> filteredList = words.Where((w) => w.GetVisibility()).ToList();
        // stretch!!!! filters out words that are already hidden
        // .Where method for lists, filters, parameter is word
        filteredList.ForEach((word) => {
            Random random = new Random();
            double randomNumber = random.NextDouble(); // between 0.0 and 1.0
            if (randomNumber > RandomHideFloat) {
                word.SetInvisible();
            }
        });
    }

    public void Display() {
        
        reference.Display();
        Console.Write(" ");
        words.ForEach((word) => {
            word.Display();
            Console.Write(" ");
            
        });
        Console.Write("\n");
        RandomHide();
    }

    // public Scripture(string reference) {
    //     for (int i = 0; i < words)
    // }
   

    // Console.WriteLine("Words in scripture: ");
    // foreach (string word in wordList)
    // {
    //     Console.WriteLine(word);
    // }

    // public string.Format("{0}, scriptureString");




    // loop through list of words and have words print themselves, called in scripture ... what it looks like, 
}