using System;

namespace MiniGolfGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MiniGolf Game!");

            // Variable to track if the game is running
            bool isGameRunning = true;

            // Game loop
            while (isGameRunning)
            {
                Console.WriteLine("\nEnter command (play, exit):");

                // Get the user command
                string command = Console.ReadLine();

                switch (command.ToLower())
                {
                    case "play":
                        // Start playing the game
                        PlayGame();
                        break;
                    case "exit":
                        // Exit the game loop
                        isGameRunning = false;
                        break;
                    default:
                        // Invalid command
                        Console.WriteLine("Invalid command, please try again.");
                        break;
                }
            }

            Console.WriteLine("Thank you for playing MiniGolf Game!");
        }

        static void PlayGame()
        {
            // Game initialization logic here
            Console.WriteLine("Game Started!");

            // Temporary: just a placeholder for the game logic
            Console.WriteLine("This is where the game plays.");

            // Game finish logic here
            Console.WriteLine("Game Finished!");
        }
    }
}
