using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantan
{
    class Joker : Card
    {
        public Joker() : base(0, 0)
        {
        }

        public void SetNumber(int number)
        {
            _number = number;
        }

        public void SetSuit(int suit)
        {
            _suit = suit;
        }
    }
}
