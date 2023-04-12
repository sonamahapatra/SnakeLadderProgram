using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Snake And Ladder Program");
            SnakeLadder snakeLadder= new SnakeLadder();
            Console.WriteLine("Player Position :" + snakeLadder.PlayerPossition);
            snakeLadder.PlayingTillWin();
            snakeLadder.Game();
            Console.ReadLine();
        }
    }
}
