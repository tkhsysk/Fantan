using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantan
{
    abstract class Player
    {
        protected Master _master;
        protected Table _table;
        protected Hand _hand = new Hand();
        public string Name { get; set; }
        protected Rule _rule;

        public Player(string name, Master master, Table table, Rule rule)
        {
            this.Name = name;
            _master = master;
            _table = table;
            _rule = rule;
        }

        public abstract void Play(Player nextPlayer);

        public void ReceiveCard(Card card)
        {
            _hand.AddCard(card);
        }
    }
}
