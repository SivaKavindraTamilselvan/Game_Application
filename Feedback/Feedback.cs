namespace Game.Feedback;

public class FeedbackGenerator
{
    public string GetFeedback(string guessed_word, string actual_word)
    {
        char[] result = new char[5];
        char[] hidden_word = actual_word.ToCharArray();
        for (int i = 0; i < 5; i++)
        {
            if (guessed_word[i] == hidden_word[i])
            {
                result[i] = 'G';
                hidden_word[i] = '*';
            }
        }
        for (int i = 0; i < 5; i++)
        {
            if (result[i] == 'G')
            {
                continue;
            }
            bool check = false;
            for (int j = 0; j < 5; j++)
            {
                if (hidden_word[j] != '*' && guessed_word[i] == hidden_word[j])
                {
                    hidden_word[j] = '*';
                    check = true;
                    break;
                }
            }
            if (check)
            {
                result[i] = 'Y';
            }
            else
            {
                result[i] = 'X';
            }
        }
        string final_result = new string(result);
        return final_result;
    }

    public void PrintColoredFeedback(string guess, string feedback)
    {
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
    }
}