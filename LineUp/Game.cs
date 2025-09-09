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
            grid = new Grid(rows, columns);
            turnCounter = 0;
        }

        public int PlayerTurn()
        {
            return turnCounter % 2 == 0 ? 1 : 2;
        }

        public void Play()
        {
            while (true)
            {
                grid.Display();
                Player currentPlayer = PlayerTurn() == 1 ? player1 : player2;
                turnCounter++;
            }

        }
    }

}