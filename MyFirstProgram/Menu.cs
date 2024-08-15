namespace MyFirstProgram
{
    internal class Menu
    {
        GameEngine gameClass = new(); //Integration; utilize GameEngine method to run different type of games
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear(); //clear the console everytime the menu runs 
            Console.WriteLine("------------------------");
            Console.WriteLine($"Hello {name}. It's {date}. This is your math game. It's going to be awesome!");
            Console.WriteLine("Press any key to show the menu");
            Console.ReadLine();
            Console.WriteLine("\n");

            var isGameOn = true; //Main menu loop 

            do
            {
                Console.Clear(); //clear the console everytime the menu runs
                Console.WriteLine($@"
What type of game would you like to play? Please choose one of the following options  below:
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit"); //DIsplays the game option to the user

                

                var gameSelected = Console.ReadLine();

                //Switch statement to select the game operation

                switch (gameSelected.Trim().ToLower()) //Normalize input by trimming whitespace and converting to lowercase
                {
                    case "v":
                        Helpers.PrintGames(); //This will call the method to print previous game results
                        break;
                    case "a":
                        gameClass.AdditionGame("Addition game");
                        break;
                    case "s":
                        gameClass.SubtractionGame("Subtraction Game");
                        break;
                    case "d":
                        gameClass.DivisionGame("Division Game");
                        break;
                    case "m":
                        gameClass.MultiplicationGame("Multiplication Game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye!");
                        isGameOn = false; //this stops the game, calls false and ends
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (isGameOn); //Menu loop, will run if isGameOn is true
        }

    }
}
