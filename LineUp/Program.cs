using System;

namespace LineUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LineUp");

            Grid grid = new Grid(6, 7);
            grid.Display();

            Console.WriteLine("10x10");
            Grid customGrid = new Grid(10, 10);
            customGrid.Display();

            Console.WriteLine("4x5");   
            Grid smallGrid = new Grid(4, 5);
            smallGrid.Display();

            Console.WriteLine("8x5");
            Grid invalidGrid = new Grid(8, 5);
            invalidGrid.Display();


            Console.WriteLine("\nPress any key to exit...");
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