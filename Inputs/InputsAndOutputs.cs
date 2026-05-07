namespace WordGame.IO;

public class InputsAndOutputs
{
    //this is used for printing the console statements to avoid longer line of code
    public void Title()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("=================Word Game=========================");
        Console.WriteLine("---------------------------------------------------");
        Console.ResetColor();
    }
    public void PreviouslyUsedWords()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Previously Guessed Words");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine();
        Console.ResetColor();
    }
    public void EnterWordGuessed()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;

        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Enter the Words Guessed");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine();
        Console.ResetColor();
    }
    public void ChooseDifficulty()
    {
        Console.WriteLine("Choose Difficulty Level");
        Console.WriteLine("1. For Easy");
        Console.WriteLine("2. For Medium");
        Console.WriteLine("3. For Hard");
    }
}