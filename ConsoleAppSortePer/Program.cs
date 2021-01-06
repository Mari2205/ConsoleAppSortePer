using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSortePer
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager game = new GameManager(1, 3); // antal human players og antal bots
            game.Start();


            Console.Read();
        }
    }
}
