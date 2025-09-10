using System;

namespace LineUp
{
    public class Grid
    {
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public int WinConditionDisc { get; private set; }
        private Disc[,] grid;
        public Grid(int rows, int columns)
        {
            Rows = Math.Max(rows, 6);
            Columns = Math.Max(columns, 7);
            grid = new Disc[Rows, Columns];
            if (Rows > Columns)
            {
                Console.WriteLine("Cannot have more rows than columns. Adjusting grid to make it square.");
                //Rows = int.Parse(Console.ReadLine());
                Rows = Columns;
            }

            WinConditionDisc = (int)Math.Floor(Rows * Columns * 0.1);
        }

        public int GetLowestEmptyRow(int column)
        {
            for (int row = Rows - 1; row >= 0; row--)
            {
                if (grid[row, column] == null)
                {
                    return row;
                }
            }
            return -1; // Column is full
        }
        public bool PlaceDisc(int column, Disc disc)
        {
            if (column < 0 || column >= Columns)
            {
                Console.WriteLine("Invalid column. Please choose a valid column.");
                return false;
            }

            for (int row = Rows - 1; row >= 0; row--)
            {
                if (grid[row, column] == null)
                {
                    grid[row, column] = disc;
                    return true;
                }
            }

            Console.WriteLine("Column is full. Please choose another column.");
            return false;
        }

        public bool IsFull()
        {
            for (int col = 0; col < Columns; col++)
            {
                if (grid[0, col] == null)
                {
                    return false;
                }
            }
            return true;
        }
        
        public bool EndCondition()
        {
            int winLength = WinConditionDisc;
            
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                {
                    if (grid[row, col] != null) 
                    {
                        int player = grid[row, col].PlayerNumber;
                        
                        if (CheckDirection(row, col, 1, 0, player, winLength) ||   
                            CheckDirection(row, col, 0, 1, player, winLength) ||   
                            CheckDirection(row, col, 1, 1, player, winLength) ||  
                            CheckDirection(row, col, 1, -1, player, winLength))   
                        {
                            return true; 
                        }
                    }
                }
            }
            return false;
        }

        private bool CheckDirection(int startRow, int startCol, int deltaRow, int deltaCol, int player, int winLength)
        {
            int count = 0;
            
            for (int i = 0; i < winLength; i++)
            {
                int row = startRow + (i * deltaRow);
                int col = startCol + (i * deltaCol);
                
                if (row >= 0 && row < Rows && col >= 0 && col < Columns &&
                    grid[row, col] != null && grid[row, col].PlayerNumber == player)
                {
                    count++;
                }
                else
                {
                    break; 
                }
            }
            
            return count == winLength;
        }

        public void Display()
        {

            for (int row = 0; row < Rows; row++)
            {

                Console.Write("  ");
                for (int col = 0; col < Columns; col++)
                {
                    if (grid[row, col] == null)
                        Console.Write("|   ");
                    else
                        Console.Write("| " + grid[row, col].Symbol + " ");
                }
                Console.WriteLine("|");
            }

            Console.WriteLine($"\nWin condition: Connect {WinConditionDisc} discs");
        }
    }

}