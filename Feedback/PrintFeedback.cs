namespace WordGame.Feedback;

public partial class FeedbackGenerator
{
    //for colour in the console
    public void PrintColoredFeedback(string guess, string feedback)
    {
        Console.WriteLine("---------------------------------------------------");
        for (int i = 0; i < guess.Length; i++)
        {
            //green color for letter G
            if (feedback[i] == 'G')
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            //yellow color for letter Y
            else if (feedback[i] == 'Y')
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            //red color for letter X
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