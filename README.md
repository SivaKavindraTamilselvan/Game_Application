## WORD GAME

Game Rules

- The system should secretly choose one 5-letter word.
- The player gets a maximum of 6 attempts.
- The user should enter one guess per attempt.
- If the word is guessed correctly, the game should end immediately.


FOLDER STRUCTURE

Exception

- Custom Exception defined for InvaidGuess for the words

Word Generator

- cointains the 5 letter word list
- random fucntion to generate the random 5 letter word from the list

Validation

- validation of input
- cannot be more than 5 letter word
- cannot be less than 5 letter word
- cannot contain any kind of special character
- cannot be whitespace

Feedback

Here usage of partial class for modular structure of code to avoid long code lines

- GetFeedback.cs

    - function to compare from the hidden word and the guessed word
    - generate the X,Y,G As per the rule
    - G = Correct letter and position
    - Y = Correct letter and wroung position
    - X = Wroug letter and position
    - Usage of * to avoid repeated loop count
- PrintFeedback.cs
    - Usage of Console.ForegroundColor for usage of color print in the console and print the result of each feedback

GameFlow

- main game 
- while loop for attempts
- validation
- get feedback
- print feedback
- score calculate
- if Y - +5
- if G - +10
- End of loop result in score calculate
- replay option on click 1
- have 3 levels
- easy = maximum attempt 6
- medium = maximum attempt 5
- hard = maximum attempt 4

ScoreCalculator

- if won addition of bonus if lost reduction of score
- here print the score and correct guessed word of lost

InputCheck

- print the console statments
- to avoid long length of code

## EXPECTED USAGE

- Classes and Objects – Game,WordProvider,GuessValidator,FeedbackGenerator,InvalidGuessException,InputAndOutput,ScoreCalculator
- Encapsulation – Usage of Private access modifiers
- Constructors – In Custom Exception
- Methods – For Every class and each functionality implemented using function
- Collections / Lists – For storing previous guessed words
- Loops – for max attempt and retry option
- Conditional Statements – for difficulty level,score calculation,custom exception,print etc
- Custom Exceptions - Implemented
- String Handling – Conversion to upper,trim and char array mainly used

## SCREENSHOTS
