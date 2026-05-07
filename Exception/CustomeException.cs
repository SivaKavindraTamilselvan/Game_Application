namespace WordGame.Exceptions;

//custom exception for input check
public class InvalidGuessException : Exception
{
    public InvalidGuessException(string message) : base(message) {}
}