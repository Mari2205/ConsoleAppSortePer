using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSortePer
{
    class SortePer : CardGame
    {
        public SortePer()
        {
            this.CardAmount = 52;
            CreateDeck();
            foreach (Card card in Cards.ToList())
            {
                if (card.CardSuit == Card.Suit.Clubs && card.CardValue == 10)
                {
                    this.Cards.Remove(card);
                }
            }
        }

        public override void Play(List<Player> players)
        {
            while (!GameOver)
            {
                int nextPlayer = 1;




                foreach (Player player in players.ToList())
                {
                    if (nextPlayer >= players.Count)
                    {
                        nextPlayer = 0;
                    }

                    if (players[nextPlayer].hand.Count == 0)
                    {
                        players.Remove(players[nextPlayer]);
                    }
                    if (nextPlayer >= players.Count)
                    {
                        nextPlayer = 0;
                    }

                    player.PlayerTurn(players[nextPlayer]);

                    if (players.Count <= 2)
                    {

                        if (player.lost)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(player.playerName + " lost the game");
                            GameOver = true;
                            return;
                        }
                    }

                    if (player.isOut)
                    {
                        players.Remove(player);
                    }

                    nextPlayer++;

                }
            }
        }
    }
}
