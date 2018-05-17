using System;

//C#
//namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();

            while (true)
            {

                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;

                //ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    //error handle not number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColor(ConsoleColor.Yellow, "Error: '{0}' is not a number please try again", input);
                        continue;
                    };


                    //cast int and put in guess
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColor(ConsoleColor.Yellow, "{0} is the wrong number please try again", input);
                    }
                }

                PrintColor(ConsoleColor.Green, "You are correct", "");

                Console.WriteLine("Play Again ? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") { continue; }
                else if (answer == "N") { return; }
                else { return; }
            }
        }

        static void GetAppInfo()
        {
            // set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuther = "Derek Evanson";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} written by {2}", appName, appVersion, appAuther);
            Console.ResetColor();
        }

        static void GreetUser()
        {  //ask user name
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, Lets play a game...", inputName);
        }

        static void PrintColor(ConsoleColor color, string text, string userInput)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text, userInput);
            Console.ResetColor();
        }
    }
}
