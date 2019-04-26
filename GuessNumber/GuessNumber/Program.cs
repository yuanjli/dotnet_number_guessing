﻿using System;

// Namespace 
namespace GuessNumber
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Runs the function to print out the app information:
            GetAppInfo();
            // Runs the function to engage the user:
            Greeting();

            while (true)
            {
                // Init correct number and the guess variable:
                //int correctnumber = 7;
                // Create a rondom object: 
                Random random = new Random();
                int correctnumber = random.Next(1, 10);
                int guessNumber = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                // while loop for checking the number: 
                while (guessNumber != correctnumber)
                {
                    // Get users input:
                    string inputNumber = Console.ReadLine();

                    //check if the input is a number
                    if (!int.TryParse(inputNumber, out guessNumber))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("It looks like the input wasn't a number, please try again!");
                        Console.ResetColor();

                        //Keep going:
                        continue;
                    }

                    // Cast to int and put in guess variable
                    guessNumber = Int32.Parse(inputNumber);

                    // Match guess to correct number 
                    if (guessNumber != correctnumber)
                    {
                        // Change text color 
                        Console.ForegroundColor = ConsoleColor.Red;
                        // Write out app info
                        Console.WriteLine("Wrong number, please try again");
                        // Reset text color
                        Console.ResetColor();

                    }
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Congradulations, you have guessed the correct number!");
                Console.ResetColor();

                // Ask the user to play again? 
                Console.WriteLine("Play Again?  [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            // Change text color 
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            // Write out app info
            Console.WriteLine("{0}: Version {1}", appName, appVersion);
            // Reset text color
            Console.ResetColor();
        }

        static void Greeting()
        {
            // Ask user's name
            Console.WriteLine("What is your name?");
            // Get user name input:
            string input = Console.ReadLine();
            // Greetings: 
            Console.WriteLine("Hello {0}, let's play a game...", input);
        }
    }
}
