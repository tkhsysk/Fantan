using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantan
{
    class Card
    {
        public const int SUIT_SPADE =1;
        public const int SUIT_DIAMOND = 2;
        public const int SUIT_CLUB = 3;
        public const int SUIT_HEART = 4;

        public const int SUIT_NUM = 4;
        public const int CARD_NUM = 13;

        protected int _suit;
        protected int _number;

        public Card(int suit, int number)
        {
            _suit = suit;
            _number = number;
        }

        public int GetNumber()
        {
            return _number;
        }

        public int GetSuit()
        {
            return _suit;
        }

    }
}
