namespace ScriptureApp;
class Word {

    private string word;

    private bool visible;

    public Word(string w, bool v) {
        word = w;
        visible = v;
    }

    public void SetInvisible()
    {
        visible = false;
    }

    public bool GetVisibility()
    {
        return visible;
    }

    public void Display() {
        if (visible) {
            Console.Write(word);
        } else {
            Console.Write(new string('_', word.Length));
        }
    }

   


    // override to make letters dashes???
    // what it looks like: whether words are hidden or not 
}