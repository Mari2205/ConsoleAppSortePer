using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSortePer
{
    class Gui
    {
        public void LostGame(string plyerName)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(plyerName + " lost the game");
            Console.ResetColor();
        }

        public void NoCardsLeft(string plyerName)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(plyerName + " has no cards left and is out of the game \n");
            Console.ResetColor();
        }

        public void ChooseCard(string playerName, int PlayerCardCount)
        {
            Console.WriteLine(playerName + " choose a card between 1 and " + PlayerCardCount + "\n");
        }

        public void CheckCard(string playerName, string card, string hand)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(playerName + " found a pair! \n");
            Console.WriteLine("They matched " + card);
            Console.WriteLine("with " + hand + "\n");
            Console.ResetColor();
        }
    }
}
