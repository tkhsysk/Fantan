using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantan
{
    class Hand
    {
        private ArrayList _hand = new ArrayList();

        public void AddCard(Card card)
        {
            _hand.Add(card);
        }

        public Card PickCard(int position)
        {
            Card pickedCard = null;
            
            if((0 <= position) && (position < _hand.Count))
            {
                pickedCard = (Card)_hand[position];
                _hand.RemoveAt(position);
            }

            return pickedCard;
        }

        public void Suffle()
        {
            int number = _hand.Count;
            int pos;

            for(int count = 0; count < number * 2; count++)
            {
                Random rand = new Random();
                pos = rand.Next(number);

                Card pickedCard = (Card)_hand[pos];
                _hand.RemoveAt(pos);
                _hand.Add(pickedCard);
            }
        }

        public int GetNumberOfCards()
        {
            return _hand.Count;
        }

        public Card LookrCard(int position)
        {
            Card lookingCard = null;

            if ((0 <= position) && (position < _hand.Count))
            {
                lookingCard = (Card)_hand[position];
            }

            return lookingCard;
        }
    }
}
