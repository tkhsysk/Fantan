using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantan
{
    class FantanPlayer : Player
    {
        private int _pass;

        public FantanPlayer(string name, Master master, Table table, Rule rule) : base(name, master, table, rule)
        {
        }

        public override void Play(Player nextPlayer)
        {
            Card[] candidate = _rule.FindCandidate(_hand, _table);

            if(candidate != null)
            {
                _table.PutCard(candidate);

                if(_hand.GetNumberOfCards() == 0)
                {
                    _master.DeclareWin(this);
                }
            }
            else
            {
                _pass++;
                ((FantanMaster)_master).Pass(this);

                if(_pass > FantanMaster.PASS_LIMIT)
                {
                    int numberOfHand = _hand.GetNumberOfCards();
                    for(int count = 0; count < numberOfHand; count++)
                    {
                        _table.PutCard(new Card[]{ _hand.PickCard(0) });
                    }
                }
            }
        }

        public void ReceiveCard(Card card)
        {
            if(card.GetNumber() == 7)
            {
                _table.PutCard(new Card[] { card });
            }
            else
            {
                base.ReceiveCard(card);
            }
        }

        public int GetPass()
        {
            return _pass;
        }
    }
}
