using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] slot = new int[3, 3];
            int betting = 0;
            int min=1;
            int max = 3;
            Random randNum = new Random();
                       for (int x = 0; x < slot.GetLength(0); x += 1)
            {
                for (int y = 0; y < slot.GetLength(1); y += 1)
                {
                    Console.Write(slot[x, y]);
                }
            }
           
        }
    }
}
