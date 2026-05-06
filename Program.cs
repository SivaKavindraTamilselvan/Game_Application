using Game.Exceptions;
using Game.Validation;
using Game.GameFlow;
public class Program
{
    static void Main(string[] args)
    {
        WordGuessGame game = new WordGuessGame();
        game.Start();
    }
}