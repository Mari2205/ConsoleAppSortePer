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
                gui.NoCardsLeft(playerName);
                isOut = true;
                return;
            }
            gui.ChooseCard(playerName, player.hand.Count());
            index = UserInput();
            hand.Add(player.hand.ElementAt(index - 1));
            player.hand.RemoveAt(index - 1);

        }
    }
}

