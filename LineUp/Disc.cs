using System;

namespace LineUp
{
    public class Disc
    {
        public char Symbol { get; private set; }
        public int PlayerNumber { get; private set; }
        public string Type { get; private set; }

        public Disc(int playerNumber, string type)
        {
            PlayerNumber = playerNumber;
            Type = type;

            if (type == "Ordinary")
            {
                Symbol = playerNumber == 1 ? '@' : '#';
            }
            else if (type == "Boring")
            {
                Symbol = playerNumber == 1 ? 'B' : 'b';
            }
            else if (type == "Magnetic")
            {
                Symbol = playerNumber == 1 ? 'M' : 'm';
            }
            else
            {
                throw new ArgumentException("Invalid disc type");
            }
        }
    }
}