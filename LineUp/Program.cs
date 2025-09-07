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

            // Test placing some discs
            Console.WriteLine("\nTesting disc placement:");
            Disc disc1 = new Disc(1, DiscType.Ordinary);
            Disc disc2 = new Disc(2, DiscType.Boring);

            grid.PlaceDisc(3, disc1);  // Place @ in column 3
            grid.PlaceDisc(3, disc2);  // Place b in column 3 (should stack)
            grid.PlaceDisc(5, disc1);  // Place @ in column 5

            grid.Display();


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