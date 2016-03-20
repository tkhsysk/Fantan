using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantan
{
    class Program
    {
        static void Main(string[] args)
        {
            Master master = new FantanMaster();

            Table field = new FantanTable();

            Rule rule = new FantanRule();

            Player murata = new FantanPlayer("村田", master, field, rule);
            Player yamada = new FantanPlayer("山田", master, field, rule);
            Player saito = new FantanPlayer("斉藤", master, field, rule);

            master.RegisterPlayer(murata);
            master.RegisterPlayer(saito);
            master.RegisterPlayer(yamada);

            Hand trump = CreateTrump();

            master.PrepareGame(trump);

            master.StartGame();

            Console.ReadLine();
        }

        private static Hand CreateTrump()
        {
            Hand trump = new Hand();

            for (int i = 1; i <= Card.CARD_NUM; i++)
            {
                trump.AddCard(new Card(Card.SUIT_CLUB, i));
                trump.AddCard(new Card(Card.SUIT_DIAMOND, i));
                trump.AddCard(new Card(Card.SUIT_HEART, i));
                trump.AddCard(new Card(Card.SUIT_SPADE, i));
            }

            return trump;
        }
    }
}
