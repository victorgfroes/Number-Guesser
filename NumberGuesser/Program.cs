using System;

namespace NumberGuesser {
    class Program {
        static void Main(string[] args) {
            string appName = "Number Guesser", appVersion = "1.0.0",
                appAuthor = "Victor Grossi Fróes";
            //Trocar cor da fonte
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");
            //Resetar cor da fonte
            Console.ResetColor();
            Console.Write("\nTell me your name: ");
            string inputName = Console.ReadLine();
            Console.WriteLine($"\nHello {inputName}! Let's play a game!");
            while (true) {
                Random random = new Random();
                int correctNumer = random.Next(1, 11);
                int guess = 0;
                Console.WriteLine("\nGuess a number between 1 and 10");
                while (guess != correctNumer) {
                    string input = Console.ReadLine();                    
                    guess = Int32.Parse(input);
                    if (guess == correctNumer) {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You are Goddamn right son!");
                        Console.ResetColor();
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Try again!");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine("\nWanna play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N") {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Thanks for playing!");
                    Console.ResetColor();
                    return;
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Thanks for playing!");
                    Console.ResetColor();
                    return;
                }
            }
        }
    }
}
