namespace WordGame.Scores;

public class Score
{
    public void ScoreCaluculator(int attempt, bool won, int score, int max_attempt, string secretWord)
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("---------------------------------------------------");

        //list of comments to display to the winenrs
        List<string> comment = new List<String> { "Genius!", "Excellent!", "Great job!", "Good work!", "Nice try!", "That was close!" };
        if (won)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Game Over! Congratulations! You Won The Game");
            //my own method used for calculating the scores and bonus
            int won_bonus = (max_attempt - attempt + 1) * 10;
            score = score + won_bonus;
            Console.WriteLine(comment[attempt - 1]);
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game Over! You Lost");
            //if lost then the score will be reduced by 10 from the previous score calculated in game.cs for correct guess.
            score = score - 10;
            Console.ResetColor();
            Console.WriteLine($"The Correct Word - {secretWord} ");
        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Final Score - {score}");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();
        Console.ResetColor();
    }
}