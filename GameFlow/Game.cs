using Game.Exceptions;
using Game.Validation;
using Game.WordGenerator;
using Game.Feedback;
using Game.Scores;

namespace Game.GameFlow;

public class WordGuessGame
{
    private int max_attempt = 6;
    private string secretWord = "";

    WordGuessValidation validator = new WordGuessValidation();
    WordGeneratorClass generator = new WordGeneratorClass();
    FeedbackGenerator feedback = new FeedbackGenerator();
    Score scoresCalucaltor = new Score();

    public void Start()
    {
        while (true)
        {
            secretWord = generator.GetRandomWord();
            Console.WriteLine(secretWord);

            int score = 0;
            int attempt = 1;
            bool won = false;
            List<string> guessed_words = new List<string>();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("=================Word Game=========================");
            Console.WriteLine("---------------------------------------------------");
            Console.ResetColor();

            Console.WriteLine($"Maximum Attempts - {max_attempt}");

            while (attempt <= max_attempt)
            {
                try
                {
                    if (guessed_words.Count > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine();
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Previously Guessed Words");
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine();
                        Console.ResetColor();

                        int count = 1;
                        foreach (var item in guessed_words)
                        {
                            Console.WriteLine(count + " " + item);
                            count++;
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine();
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Enter the Words Guessed");
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine();
                    Console.ResetColor();

                    string guessed_word = Console.ReadLine() ?? "";
                    guessed_word = guessed_word.ToUpper();
                    validator.ValidateFunction(guessed_word, guessed_words);

                    string actual = feedback.GetFeedback(guessed_word, secretWord);
                    feedback.PrintColoredFeedback(guessed_word, actual);
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
                    continue;
                }
            }
            scoresCalucaltor.ScoreCaluculator(attempt, won, score, max_attempt);
            Console.WriteLine("Enter 1 To Replay. Or any other input to exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice != 1)
            {
                break;
            }
            else
            {
                Console.WriteLine("Choose Difficulty Level");
                Console.WriteLine("1. For Easy");
                Console.WriteLine("2. For Medium");
                Console.WriteLine("3. For Hard");
                int level = Convert.ToInt32(Console.ReadLine());
                while (level < 1 || level > 3)
                {
                    Console.WriteLine("Invalid Input.Enter the correct input.");
                    level = Convert.ToInt32(Console.ReadLine());
                }
                if (level == 1)
                {
                    max_attempt = 6;
                }
                else if (level == 2)
                {
                    max_attempt = 5;
                }
                else if (level == 3)
                {
                    max_attempt = 4;
                }
            }
        }
    }
}