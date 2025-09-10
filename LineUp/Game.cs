using System;

namespace LineUp
{
    public class Game
    {
        private Grid grid;
        private Player player1;
        private Player player2;
        private int turnCounter;

        public Game(int rows, int columns)
        {
            turnCounter = 0;
            grid = new Grid(rows, columns);
        }

        public int PlayerTurn()
        {
            return turnCounter % 2 == 0 ? 1 : 2;
        }

        public void Play()
        {
            do
            {
                grid.Display();
                int currentPlayerNum = PlayerTurn();

                Console.WriteLine($"Player {currentPlayerNum}'s turn");
                int column;
                do
                {
                    Console.Write($"Enter column number (1-{grid.Columns}): ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out column))
                    {
                        column--;
                        if (column >= 0 && column < grid.Columns)
                        {
                            break;
                        }
                    }
                    Console.WriteLine("Invalid column. Try again.");
                } while (true);

                DiscType discType;
                do
                {
                    Console.Write("Enter disc type (o for Ordinary, b for Boring, m for Magnetic): ");
                    string input = Console.ReadLine().ToLower();

                    if (input == "o")
                    {
                        discType = DiscType.Ordinary;
                        break;
                    }
                    else if (input == "b")
                    {
                        discType = DiscType.Boring;
                        break;
                    }
                    else if (input == "m")
                    {
                        discType = DiscType.Magnetic;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid disc type. Use o, b, or m.");
                    }
                } while (true);

                Disc newDisc = new Disc(currentPlayerNum, discType);
                grid.PlaceDisc(column, newDisc);
                grid.Display();

                turnCounter++;
            } while (!grid.EndCondition() && !grid.IsFull());
            
            // After the while loop ends
            if (grid.EndCondition())
            {
                int winner = PlayerTurn() == 1 ? 2 : 1;
                Console.WriteLine($"Player {PlayerTurn()} wins!");
            }
            else if (grid.IsFull())
            {
                Console.WriteLine("It's a tie! The grid is full.");
            }
        }
    }

}