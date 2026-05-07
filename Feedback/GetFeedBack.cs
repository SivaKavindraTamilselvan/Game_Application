namespace WordGame.Feedback;

public partial class FeedbackGenerator
{
    public string GetFeedback(string guessed_word, string actual_word)
    {
        char[] result = new char[5];
        //used to avoid repeated letters errors
        char[] hidden_word = actual_word.ToCharArray();
        for (int i = 0; i < 5; i++)
        {
            if (guessed_word[i] == hidden_word[i])
            {
                result[i] = 'G';
                //to avoid reptation of same letter comparision - symbol used as input doesnot take symbol
                hidden_word[i] = '*';
            }
        }
        for (int i = 0; i < 5; i++)
        {
            //check for Y and X condition
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
            //if letter present
            if (check)
            {
                result[i] = 'Y';
            }
            //if letter not present
            else
            {
                result[i] = 'X';
            }
        }
        string final_result = new string(result);
        return final_result;
    }
}