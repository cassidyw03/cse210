using Systems;

public class WordGame 
{
    private string _guess;
    private User player;
    private WrongGuess wrongGuess;
    private HideWord hideWord;

   
    public WordGame()
    {
        player = new Player();
        wrongGuess = new WrongGuess();
        randomWord = new RandomWord();
        hideWord = new HideWord();  
    }

    
    

    public void StartGame()
    {
        Console.Clear();
        player.ShowRandomWord();
        do
        {
            Console.Clear();
        }

        while (!player.GameOver());
        
    }

    private void SelectRandomWord(string)
    {
        player.randomWord = SelectRandomWord.GetRandomWord();
    }

    private void DisplayRandomWord()
    {
        Console.WriteLine("\n{0}, player.randomWord")
    }

    private void PromptPlayerForLetter()
    {
        do
        {
            Console.Write("Guess a letter >>  ");
            string g = Console.ReadLine();
            _letterGuessed = g.Substring(0, 1);
        } while (player.CheckIfGuessed(player, _letterGuessed));

        player.lettersGuessed.Add(_letterGuessed);
    }
    private void CheckPlayerGuess()
    {
        player.CheckLatestGuess(_letterGuessed);
        player.ShowRandomWord();
    }

    private void PlayAgain()
    {
        Console.WriteLine($"\nWould you like to play again?, press enter to continue.");

        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Enter)
        {
            Console.Clear();  // This will clear the console
        }
    }

    private void ShowNumberOfGuesses()
    {
        Console.WriteLine($"\nGuesses Left = {player.wrongGuessCount}/7\n");
    }

    private void ShowHint()
    {
        WrongGuess.ShowHint(player.wrongGuessCount);
    }

    private void ShowLettersGuessesRight()
    {
        Console.WriteLine($"\n{player.showRandomWord}\n");
    }

    private void ShowLettersGuessedWrong()
    {
        Console.WriteLine($"\n{player.wrongGuesses}\n");
    }

    private void ShowTitle()
    {
        Console.WriteLine($"*** Lets Play Hangman ***\n");
    }

    private void ShowPlayerScore()
    {
        if (!player.PlayerLost())
        {
            simpleScore.DisplayScore(player.correctGuessCount, player.rightGuessList, player.randomWord);
            scrabbleScore.DisplayScore(player.correctGuessCount, player.rightGuessList, player.randomWord);
            complexScore.DisplayScore(player.correctGuessCount, player.rightGuessList, player.randomWord);
        }
        else
        {
            simpleScore.DisplayScore(0, player.emptyList, player.randomWord);
            scrabbleScore.DisplayScore(0, player.emptyList, player.randomWord);
            complexScore.DisplayScore(0, player.emptyList, player.randomWord);
        }
    }

    private void GameOver()
    {
        Console.Clear();  // This will clear the console
        if (player.GameOver() && player.PlayerWon())
        {
            Console.WriteLine("*** Congratulations You Won! ***");
        }
        else
        {
            Console.WriteLine("*** Sorry, you lost! ***");
        }
        ShowGallows();
        ShowNumberOfGuesses();
        Console.WriteLine($"\nThe word was - {player.randomWord}\n");
        ShowPlayerScore();
    }





}