using WordGame.Exceptions;

namespace WordGame.Validation;

public class GuessValidator
{
    //validation function created for checking the inputs
    public void ValidateFunction(string guessed_word,List<string> guessed_words)
    {
        //check for whitespace
        if(guessed_word.Trim() == "")
        {
            throw new InvalidGuessException("Input cannot be empty");
        }
        //check if the word greater than length 5
        if(guessed_word.Length<5)
        {
            throw new InvalidGuessException("Input Length cannot be less than 5. Need to enter exactly 5 letter word");
        }
        //check if the word lesser than length 5
        if(guessed_word.Length>5)
        {
            throw new InvalidGuessException("Input Length cannot be greater than 5. Need to enter exactly 5 letter word");
        }
        //check for numbers and special symbols
        if(!guessed_word.All(char.IsLetter))
        {
            throw new InvalidGuessException("Input should be only characters not any other symbols or numbers");
        }
        //check if no previously entered words used.
        if(guessed_words.Contains(guessed_word))
        {
            throw new InvalidGuessException("Aldready tried that word. Enter another word");
        }
    }
}