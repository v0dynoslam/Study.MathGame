namespace MyFirstProgram
{
    internal class Menu
    {
        GameEngine gameClass = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear(); //clear the console everytime the menu runs
            Console.WriteLine("------------------------");
            Console.WriteLine($"Hello {name}. It's {date}. This is your math game. It's going to be awesome!");
            Console.WriteLine("Press any key to show the menu");
            Console.ReadLine();
            Console.WriteLine("\n");

            var isGameOn = true;

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
Q - Quit");

                Console.WriteLine("---------------------------------------------------");

                var gameSelected = Console.ReadLine();

                //Switch statement to select the game operation

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
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
                        isGameOn = false; //this stops the game
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (isGameOn);
        }

    }
}
