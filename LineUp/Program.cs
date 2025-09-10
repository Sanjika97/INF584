using System;

namespace LineUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LineUp!");
            
            // Start a basic game
            Game game = new Game(6, 7);  // Standard 6x7 grid
            game.Play();
            
            Console.WriteLine("Game Over! Press any key to exit...");
            Console.ReadKey();
        }
    }

    // class Game
    // {

    // }

    // class Player
    // {

    // }

    // class Grid
    // {

    // }

    // class Disc
    // {

    // }
}