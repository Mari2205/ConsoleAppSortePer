using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSortePer
{
    class CpuPlayer : Player
    {
        Random rng = new Random();
        public CpuPlayer(string name) : base(name)
        {
        }

        public override void DrawFromPlayer(Player player, int index)
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
            index = rng.Next(0, player.hand.Count());
            DrawFromDeck(player.hand.ElementAt(index));
            player.hand.RemoveAt(index);
        }
    }
}
