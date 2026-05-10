## WORD GAME

Game Rules

- The system should secretly choose one 5-letter word.
- The player gets a maximum of 6 attempts.
- The user should enter one guess per attempt.
- If the word is guessed correctly, the game should end immediately.

## FOLDER STRUCTURE

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

<img width="3024" height="1964" alt="image" src="https://github.com/user-attachments/assets/6cc2a1fd-355b-4578-83bb-cb853aa952b5" />

- starting of the application

<img width="3024" height="1964" alt="image" src="https://github.com/user-attachments/assets/6897c99b-3591-4cee-b75a-56afaa23340f" />

- E letter correct but wroug position

<img width="3024" height="1964" alt="image" src="https://github.com/user-attachments/assets/bfe9a405-1f22-4188-ba33-fca864adae1d" />

- E letter correct but wroug position

<img width="3024" height="1964" alt="image" src="https://github.com/user-attachments/assets/c1e6da28-7eea-40b3-9692-411dbe4085d1" />

- Input length greater than 5 throw exception

<img width="3024" height="1964" alt="image" src="https://github.com/user-attachments/assets/7d509f31-9942-42dd-8ff2-f463d75849ce" />

- E position correct
- M and L position wrong but position incorrect

<img width="3024" height="1964" alt="image" src="https://github.com/user-attachments/assets/0502e4bd-e102-4862-a6cc-73387b9b7064" />

- Input length less than 5 throw exception

<img width="3024" height="1964" alt="image" src="https://github.com/user-attachments/assets/6b2ef463-6355-427a-8f11-41fcde9361d2" />

- Input with numbers and symbol throw exception

<img width="3024" height="1964" alt="image" src="https://github.com/user-attachments/assets/3d78af7f-d9ea-4c07-90be-cd9af5666d17" />

- Already entered word repeated then throw exception

<img width="3024" height="1964" alt="image" src="https://github.com/user-attachments/assets/b12d2a7d-fd5f-4272-9c89-c4f9eaffd701" />

- correct word guessed
- game won
- score calculation bonus added

<img width="3024" height="1964" alt="image" src="https://github.com/user-attachments/assets/06143077-a804-4d81-8694-e55c6febeaed" />

- replay option when 1 clicked

<img width="3024" height="1964" alt="image" src="https://github.com/user-attachments/assets/40645273-1c4a-42da-a942-018fe11d9539" />

- game lost
- then guesse word displayed

<img width="3024" height="1964" alt="image" src="https://github.com/user-attachments/assets/d113fdb3-4d4c-4471-b3d8-b40b98b8b03f" />

- medium level (max attempt - 5)

<img width="3024" height="1964" alt="image" src="https://github.com/user-attachments/assets/fdebe666-8b93-4625-a65a-0c38079cdced" />

- hard level (max attempt - 4)
