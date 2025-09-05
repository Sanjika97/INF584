using System;

namespace LineUp
{
    public class Disc
    {
        public char Symbol { get; private set; }
        public int PlayerNumber { get; private set; }
        public DiscType Type { get; private set; }

        public Disc(int playerNumber, DiscType type)
        {
            PlayerNumber = playerNumber;
            Type = type;

            if (type == DiscType.Ordinary)
            {
                Symbol = playerNumber == 1 ? '@' : '#';
            }
            else if (type == DiscType.Boring)
            {
                Symbol = playerNumber == 1 ? 'B' : 'b';
            }
            else if (type == DiscType.Magnetic)
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