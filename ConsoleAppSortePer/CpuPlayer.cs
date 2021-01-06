using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSortePer
{
    class CpuPlayer : Player
    {
        Random random = new Random();
        public CpuPlayer(string name) : base(name)
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
            index = random.Next(0, player.hand.Count());
            DrawFromDeck(player.hand.ElementAt(index));
            player.hand.RemoveAt(index);
        }
    }
}
