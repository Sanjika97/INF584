using System;

namespace LineUp
{
    public class Player
    {
        public int Number { get; private set; }
        public bool IsHuman { get; private set; }
        
        public Player(int number, bool isHuman)
        {
            Number = number;
            IsHuman = isHuman;
        }
    }
}