using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantan
{
    class FantanTable : Table
    {
        private Card[,] _table = new Card[Card.SUIT_NUM, Card.CARD_NUM];

        public void PutCard(Card[] card)
        {
            int number = card[0].GetNumber();
            int suit = card[0].GetSuit();

            _table[suit - 1, number - 1] = card[0];
        }

        public Card[,] GetCards()
        {
            return _table;
        }
    }
}
