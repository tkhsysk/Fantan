using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantan
{
    class FantanRule : Rule
    {
        public Card[] FindCandidate(Hand hand, Table table)
        {
            Card[] candidate = null;

            int numberOfHand = hand.GetNumberOfCards();
            for(int position = 0; position < numberOfHand; position++)
            {
                Card lokkingCard = hand.LookrCard(position);
                int number = lokkingCard.GetNumber();
                int suit = lokkingCard.GetSuit();

                // AとKは隣り合うものとする
                int leftNumber = (number != 1) ? number - 1 : Card.CARD_NUM;
                int rightNumber = (number != Card.CARD_NUM) ? number + 1 : 1;

                if (IsThereCard(table, suit, leftNumber) || IsThereCard(table, suit, rightNumber) )
                {
                    candidate = new Card[1];
                    candidate[0] = hand.PickCard(position);
                    break;
                }
            }

            return candidate;
        }

        private bool IsThereCard(Table table, int suit, int number)
        {
            Card[,] cards = table.GetCards();

            if(cards[suit - 1, number - 1] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
