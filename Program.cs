//Namespace
namespace NumberGuesser
{   
    //Main Class    
    internal class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            
            GetAppInfo();
            
            GreetUser();

            int gameover = 0;

            while (gameover == 0)
            {
                Random random = new Random();

                int correctNumber = random.Next(1, 11);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        ColorPrint(ConsoleColor.Red, "Please use actual number");

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        ColorPrint(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                ColorPrint(ConsoleColor.Green, "Correct! You Win!");



                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                while (answer != "Y" & answer != "N")
                {
                    ColorPrint(ConsoleColor.Red, "Invalid input. Please try again.");
                    Console.WriteLine("Play Again? [Y or N]");
                    answer = Console.ReadLine().ToUpper();
                }

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    ColorPrint(ConsoleColor.Magenta, "Game Over");
                    gameover = 1;
                }
       
                
            }






        }

        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Ronak Patel";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");

            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", input);
        }

        static void ColorPrint(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        
    }
}