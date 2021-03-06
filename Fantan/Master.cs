﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantan
{
    class Master
    {
        private ArrayList _players = new ArrayList();

        public void DeclareWin(Player winner)
        {
            Console.WriteLine(winner.Name + "さんが勝ち抜けです。");
            DeregisterPlayer(winner);
        }

        public void PrepareGame(Hand cards)
        {
            cards.Suffle();

            int numberOfCards = cards.GetNumberOfCards();

            int numberOfPlayers = _players.Count;

            for(int index = 0; index < numberOfCards; index++)
            {
                Card card = cards.PickCard(0);
                Player player = (Player)_players[index % numberOfPlayers];
                player.ReceiveCard(card);
            }
        }

        public void StartGame()
        {
            for(int count = 0; _players.Count > 1; count++)
            {
                int playerIndex = count % _players.Count;
                int nextPlayerIndex = (count + 1) % _players.Count;

                Player player = (Player)_players[playerIndex];
                Player nextPlayer = (Player)_players[nextPlayerIndex];

                player.Play(nextPlayer);
            }
        }

        public void RegisterPlayer(Player player)
        {
            _players.Add(player);
        }

        public void DeregisterPlayer(Player player)
        {
            // Remove RemoveAt どちらも削除後つめる
            _players.Remove(player);

            if (_players.Count == 1)
            {
                Player loser = (Player)_players[0];
                Console.WriteLine(loser.Name + "さんが敗者です。");
            }
        }
    }
}
