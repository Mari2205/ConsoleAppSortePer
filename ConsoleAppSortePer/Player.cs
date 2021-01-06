using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSortePer
{
    class Player
    {
        public List<Card> hand = new List<Card>();
        public string playerName;
        public bool isOut = false;
        public bool lost = false;

        public Player(string name)
        {
            playerName = name;
        }

        public void DrawFromDeck(Card card)
        {
            hand.Add(card);
        }

        public virtual void DrawFromPlayer(Player player, int index)
        {
            if (hand.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(playerName + " has no cards left and is out of the game \n");
                Console.ResetColor();
                isOut = true;
                return;
            }
            Console.WriteLine(playerName + " choose a card between 1 and " + player.hand.Count() + "\n");
            index = UserInput();
            hand.Add(player.hand.ElementAt(index - 1));
            player.hand.RemoveAt(index - 1);
        }

        public int UserInput()
        {
            bool valid = false;
            int value = 0;
            while (!valid)
            {
                if (Int32.TryParse(Console.ReadLine(), out value))
                {
                    valid = true;
                }
            }
            return value;
        }
        public void PlayerTurn(Player player)
        {
            if (hand.Count == 1 && hand.First().CardValue == 10 && hand.First().CardSuit == Card.Suit.Spades)
            {
                lost = true;
                return;
            }
            DrawFromPlayer(player, 0);
            CheckMatches();
        }

        public void CheckMatches()
        {
            for (int i = 0; i < hand.Count; i++)
            {
                foreach (Card card in hand.ToList())
                {
                    if (card.CardValue == hand[i].CardValue && card.CardSuit != hand[i].CardSuit)
                    {
                        if (card.CardColor == hand[i].CardColor)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(playerName + " found a pair! \n");
                            Console.WriteLine("They matched " + card.ToString());
                            Console.WriteLine("with " + hand[i].ToString() + "\n");
                            Console.ResetColor();
                            hand.Remove(hand[i]);
                            hand.Remove(card);
                        }
                    }
                }
            }
        }
    
}
}
