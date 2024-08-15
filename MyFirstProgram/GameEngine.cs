using MyFirstProgram.Models;

namespace MyFirstProgram;

internal class GameEngine
{
    internal void DivisionGame(string message)
    {
        var score = 0; //score will start at 0 

        for (int i = 0; i < 5; i++) //the for loop will repeat the game logic 5 times (5 questions)
        {
            Console.Clear(); //this will clear the console to prepare the next question
            Console.WriteLine(message);

            var divisionNumbers = Helpers.GetDivisionNumbers();
            var firstNumber = divisionNumbers[0];
            var secondNumber = divisionNumbers[1];

            Console.WriteLine($"{firstNumber} / {secondNumber}"); 

            var result = Console.ReadLine();
            result = Helpers.ValidateResult(result);


            if (int.Parse(result) == firstNumber / secondNumber) //Converts result string into an integer, int.parse converts result into a integer
            {
                Console.WriteLine("Your answer was correct! Type any key for the next question");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was wrong! Type any key for the next question");
                Console.ReadLine();
            }

            if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
        }
        Helpers.AddToHistory(score, GameType.Division);
    }

    internal void SubtractionGame(string message)
    {
        Console.WriteLine(message); //DIsplay the messge to the user

        var random = new Random(); //Create a random object to generate random numbers
        var score = 0; //WIll initialize the score counter, starts at 0

        int firstNumber; //Declare the variables for numbers
        int secondNumber;

        for (int i = 0; i < 5; i++) //Loop for 5 rounds of the game. Initialize, condition, and iteration
        {
            Console.Clear(); //Clear the consoles 
            Console.WriteLine(message); //Display the message again

            firstNumber = random.Next(1, 9); //Generate a random number between 1 and 8
            secondNumber = random.Next(1, 9); //Generate another random number

            Console.WriteLine($"{firstNumber} - {secondNumber}"); //Display the subtraction problem

            var result = Console.ReadLine(); //Read the user's answer from the console
            result = Helpers.ValidateResult(result); //Validate the user's input


            if (int.Parse(result) == firstNumber - secondNumber) //Check if the user's answer is correct
            {
                Console.WriteLine("Your answer was correct! Type any key for the next question");
                score++;
                Console.ReadLine(); //Wait for the user to press a key for the next question
            }
            else
            {
                Console.WriteLine("Your answer was wrong! Type any key for the next question");
                Console.ReadLine();
            }

            if (i == 4) Console.WriteLine($"Game over. Your final score is {score}"); //After the last question, prints the final message
        }

        Helpers.AddToHistory(score, Models.GameType.Subtraction); //Record the game score and type in the history
    }

    internal void AdditionGame(string message)
    {
        Console.WriteLine("Multiplication Game Selected");

        var random = new Random();
        var score = 0;

        int firstNumber;
        int secondNumber;

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);

            Console.WriteLine($"{firstNumber} + {secondNumber}");

            var result = Console.ReadLine();

            result = Helpers.ValidateResult(result);

            if (int.Parse(result) == firstNumber + secondNumber)
            {
                Console.WriteLine("Your answer was correct! Type any key for the next question");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was wrong! Type any key for the next question");
                Console.ReadLine();
            }

            if (i == 4)
            {
                Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                Console.ReadLine();
            }
        }

        Helpers.AddToHistory(score, GameType.Addition);

    }
    internal void MultiplicationGame(string message)
    {
        Console.WriteLine("Multiplication Game Selected");

        var random = new Random();
        var score = 0;
        int firstNumber;
        int secondNumber;

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);

            Console.WriteLine($"{firstNumber} * {secondNumber}");
            var result = Console.ReadLine();

            result = Helpers.ValidateResult(result);


            if (int.Parse(result) == firstNumber * secondNumber)
            {
                Console.WriteLine("Your answer was correct! Type any key for the next question");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was wrong! Type any key for the next question");
                Console.ReadLine();
            }

            if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
        }

        Helpers.AddToHistory(score, GameType.Multiplication);
    }

}
