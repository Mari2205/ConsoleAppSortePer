using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSortePer
{
    class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
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
            index = UserInput();
            hand.Add(player.hand.ElementAt(index - 1));
            player.hand.RemoveAt(index - 1);

        }
    }
}

