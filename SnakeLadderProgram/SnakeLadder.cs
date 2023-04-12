using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProgram
{
    public class SnakeLadder
    {
        internal int PlayerPossition = 0;
        public void Game()
        {
            Random random = new Random();
            int DieRoll = random.Next(1, 7);
            Console.WriteLine("Die Rolled No:" + DieRoll);
            PlayerPossition += DieRoll;
            
            int Option = random.Next(0, 3);
            switch (Option)
            {
                case 1:
                    Console.WriteLine("No Play : " + PlayerPossition);
                    break;
                case 2:
                    PlayerPossition += DieRoll;
                    Console.WriteLine("lader : " + PlayerPossition);
                    break;
                case 3:
                    PlayerPossition -= DieRoll;
                    Console.WriteLine("Snake : " + PlayerPossition);
                    break;
            }
            if (PlayerPossition < 0)
                PlayerPossition = 0;
        }
        public void PlayingTillWin()
        {
            while (PlayerPossition < 100)
            {
                Game();
            }
            Console.WriteLine("Player Win");
        }
         
    }
    
}
