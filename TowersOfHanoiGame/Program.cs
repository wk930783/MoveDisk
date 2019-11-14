using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoiGame
{
    class Program
    {
        static void Main(string[] args)
        {
            IGame game = null;
            Console.WriteLine("想玩塔1想玩猜2");
            string input = Console.ReadLine();
            int re;
            int.TryParse(input, out re);
            switch (re)
            {
                case 1:
                    game = new HanoiGame();
                    break;
                case 2:
                    game = new GuessGame();
                    break;

            }
            game.Setup();
            game.Play();
        }





    }
}
