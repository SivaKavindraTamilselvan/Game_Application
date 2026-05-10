using WordGame.Exceptions;
using WordGame.Validation;
using WordGame.WordGenerator;
using WordGame.Feedback;
using WordGame.Scores;
using WordGame.IO;

namespace WordGame.GameFlow;

public class Game
{
    private int max_attempt = 6;
    private string secretWord = "";
    //validation of input
    GuessValidator validator = new GuessValidator();
    //generate random words
    WordProvider generator = new WordProvider();
    //compare the guessed words and secret word and print feedback
    FeedbackGenerator feedback = new FeedbackGenerator();
    //calculate the scores
    Score scoresCalucaltor = new Score();
    //for console statements
    InputsAndOutputs inputsAndOutputs = new InputsAndOutputs();

    public void Start()
    {
        while (true)
        {
            secretWord = generator.GetRandomWord();
            //Console.WriteLine(secretWord);

            int score = 0;
            int attempt = 1;
            //to check if won/lost
            bool won = false;
            //list to store previusly guessed words
            List<string> guessed_words = new List<string>();

            inputsAndOutputs.Title();
            Console.WriteLine($"Maximum Attempts - {max_attempt}");

            while (attempt <= max_attempt)
            {
                try
                {
                    //print the previously guessed words for better access for users
                    if (guessed_words.Count > 0)
                    {
                        inputsAndOutputs.PreviouslyUsedWords();

                        int count = 1;
                        foreach (var item in guessed_words)
                        {
                            Console.WriteLine(count + " " + item);
                            count++;
                        }
                    }
                    inputsAndOutputs.EnterWordGuessed();

                    string guessed_word = Console.ReadLine() ?? "";
                    //conversion to upper to avoid different cases
                    guessed_word = guessed_word.ToUpper();
                    validator.ValidateFunction(guessed_word, guessed_words);
                    
                    //print the feedback and check
                    string actual = feedback.GetFeedback(guessed_word, secretWord);
                    feedback.PrintColoredFeedback(guessed_word, actual);

                    //score calculation +10 if position correct and +5 if correct postion wroung
                    foreach (var c in actual)
                    {
                        if (c == 'G')
                        {
                            score = score + 10;
                        }
                        if (c == 'Y')
                        {
                            score = score + 5;
                        }
                    }
                    //if won break the loop
                    if (guessed_word == secretWord)
                    {
                        won = true;
                        break;
                    }
                    guessed_words.Add(guessed_word);
                    attempt++;
                }
                //custom exception
                catch (InvalidGuessException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
            scoresCalucaltor.ScoreCaluculator(attempt, won, score, max_attempt,secretWord);

            //replay option along with three different levels reducing the number of attempts
            Console.WriteLine("Enter 1 To Replay. Or any other input to exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice != 1)
            {
                break;
            }
            else
            {
                inputsAndOutputs.ChooseDifficulty();
                int level = Convert.ToInt32(Console.ReadLine());
                while (level < 1 || level > 3)
                {
                    Console.WriteLine("Invalid Input.Enter the correct input.");
                    level = Convert.ToInt32(Console.ReadLine());
                }
                if (level == 1)
                {
                    //easy
                    max_attempt = 6;
                }
                else if (level == 2)
                {
                    //medium
                    max_attempt = 5;
                }
                else if (level == 3)
                {
                    //hard
                    max_attempt = 4;
                }
            }
        }
    }
}