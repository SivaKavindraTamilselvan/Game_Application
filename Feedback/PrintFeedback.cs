namespace WordGame.Feedback;

public partial class FeedbackGenerator
{
    
    public void PrintColoredFeedback(string guess, string feedback)
    {
        Console.WriteLine("---------------------------------------------------");
        for (int i = 0; i < guess.Length; i++)
        {
            if (feedback[i] == 'G')
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (feedback[i] == 'Y')
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.Write(guess[i] + "  ");
        }
        Console.ResetColor();
        Console.WriteLine();

        foreach (char c in feedback)
        {
            Console.Write(c + "  ");
        }

        Console.WriteLine();
        Console.ResetColor();
        Console.WriteLine("---------------------------------------------------");
    }
}