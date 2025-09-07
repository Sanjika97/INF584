using System;

namespace LineUp
{
    public class Player
    {
        public int Number { get; private set; }
        public bool IsHuman { get; private set; }
        public int OrdinaryDiscs { get; private set; }
        public int BoringDiscs { get; private set; }
        public int MagneticDiscs { get; private set; }


        public char OrdinarySymbol {
            get
            {
                if (Number == 1)
                {
                    return '@';
                }
                else
                {
                    return '#';
                }
            }
        }

        public char BoringSymbol {
            get
            {
                if (Number == 1)
                {
                    return 'B';
                }
                else
                {
                    return 'b';
                }
            }
        }

        public char MagneticSymbol {
            get
            {
                if (Number == 1)
                {
                    return 'M';
                }
                else
                {
                    return 'm';
                }
            }
        }

        public Player(int number, bool isHuman)
        {
            Number = number;
            IsHuman = isHuman;
        }
    }
}