using WordGame.Exceptions;

namespace WordGame.Validation;

public class WordGuessValidation
{
    public void ValidateFunction(string guessed_word,List<string> guessed_words)
    {
        if(guessed_word.Trim() == "")
        {
            throw new InvalidGuessException("Input cannot be empty");
        }
        if(guessed_word.Length<5)
        {
            throw new InvalidGuessException("Input Length cannot be less than 5. Need to enter exactly 5 letter word");
        }
        if(guessed_word.Length>5)
        {
            throw new InvalidGuessException("Input Length cannot be greater than 5. Need to enter exactly 5 letter word");
        }
        if(!guessed_word.All(char.IsLetter))
        {
            throw new InvalidGuessException("Input should be only characters not any other symbols or numbers");
        }
        if(guessed_words.Contains(guessed_word))
        {
            throw new InvalidGuessException("Aldready tried that word. Enter another word");
        }
    }
}