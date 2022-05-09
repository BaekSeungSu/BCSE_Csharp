using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TETRISSCREEN NewSC = new TETRISSCREEN(8, 15, true);

            AccScreen NewASC = new AccScreen(NewSC);
            Block NewBlock = new Block(NewSC, NewASC);

            
            while (true)
            {
                for (int i = 0; i < 30000000; i++)
                {
                    int a = 0;
                }
                Console.Clear();
                NewSC.Render();
                NewSC.Clear();
                NewASC.DestroyCheck();
                NewASC.Render();
                NewBlock.Move();
            }
        }
    }
}