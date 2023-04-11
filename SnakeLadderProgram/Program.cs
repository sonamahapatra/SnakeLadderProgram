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
            snakeLadder.Game();
            Console.ReadLine();
        }
    }
}
