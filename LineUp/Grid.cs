using System;

namespace LineUp
{
    public class Grid
    {
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public int WinCondition { get; private set; }
        public Grid(int rows, int columns)
        {
            Rows = Math.Max(rows, 6);
            Columns = Math.Max(columns, 7);

            if (Rows > Columns)
            {
                Rows = Columns;
            }

            WinCondition = (int)Math.Floor(Rows * Columns * 0.1);
        }

        public void Display() {
            for (int row = 0; row < Rows; row++)
            {

                for (int col = 0; col < Columns; col++)
                {
                    Console.Write("|");
                    Console.Write("  ");
                    
                }
            }

            Console.WriteLine($"\nWin condition: Connect {WinCondition} discs");
        }
    }

}