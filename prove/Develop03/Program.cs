using System;

namespace ScriptureApp;

class Program
{
    static void Main(string[] args)
    {
        Reference scripture1Ref = new Reference("Ether", 12, new List<int>{6});
        Scripture scripture1 = new Scripture(scripture1Ref, "And now, I Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith.");
       

        // Reference scripture2Ref = new Reference("Romans", 8, new List<int>{38, 39});
        // Scripture scripture2 = new Scripture(scripture2Ref, "For I am persuaded that neither death, nor life, nor angels, nor principalities, nor powers, noe things present, nor things to come, Nor height nor depth, nor any other creature, shall be able to separate us from the love of God, which is in CHrist Jesus our Lord.");
        
        bool exit = false;
        while (!exit) {
            
            scripture1.Display();
            exit = scripture1.IsExit();
            if (!exit) { 
                Console.WriteLine("Hit ENTER to continue!");
            } else {
                Console.WriteLine("Nice memorizing!");
            }
            Console.ReadLine();

        }

    }
}



// notes from class
// scripture2.Practice();

        // can have as many constrictors of the same class, as long as the parameters are different
        // 
        
        // Scripture scripture1 = new Scripture("John", 3, 16, 19, "For God so loved the world...");
        //                                      book, chapter, verse start, verse end
        //                                             if verse start and end are different print "-"
        //                                              if verse start and end are same just put one number...
        // scritpure1.Practice();
        // Practice method calls out to other things (reaches into reference every time enter is pressed)
        // reference has actual words, list of words
        // reference class hides more words
        // word turns itself from visible to hidden

// stretch? 
// random scripture generator like prompts in journal