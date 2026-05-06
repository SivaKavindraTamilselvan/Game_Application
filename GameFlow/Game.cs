using Game.Exceptions;
using Game.Validation;
using Game.WordGenerator;
using Game.Feedback;


namespace Game.GameFlow;

public class WordGuessGame
{
    private int max_attempt = 6;
    private string secretWord = "";

    WordGuessValidation validator = new WordGuessValidation();
    WordGeneratorClass generator = new WordGeneratorClass();
    FeedbackGenerator feedback = new FeedbackGenerator();

    List<string> guessed_words = new List<string>();
    public void Start()
    {
        secretWord = generator.GetRandomWord();
        Console.WriteLine(secretWord);
        int score = 0;
        int attempt = 1;
        bool won = false;
        while (attempt <= max_attempt)
        {
            try
            {
                Console.WriteLine("---------------------------------------------------");
                if (guessed_words.Count > 0)
                {
                    Console.WriteLine("Previously Guessed Words");
                    int count = 1;
                    foreach (var item in guessed_words)
                    {
                        Console.WriteLine(count + " " + item);
                        count++;
                    }
                }
                Console.WriteLine("Enter the Words Guessed");
                string guessed_word = Console.ReadLine() ?? "";
                guessed_word = guessed_word.ToUpper();
                validator.ValidateFunction(guessed_word, guessed_words);



                string actual = feedback.GetFeedback(guessed_word, secretWord);
                feedback.PrintColoredFeedback(guessed_word, actual);
                Console.WriteLine($"Your Result - {actual}");
                
                if (guessed_word == secretWord)
                {
                    won = true;
                    break;
                }
                guessed_words.Add(guessed_word);
                attempt++;
            }
            catch (InvalidGuessException ex)
            {
                Console.WriteLine(ex.Message);
                attempt--;
            }
        }
        
        
    }

    
}