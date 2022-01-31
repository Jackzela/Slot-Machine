using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_Machine
{

    public static class UIMethods
    {

        public static void WelcomeMessage(int jack)
        {
            Console.WriteLine($"The Jackpot is: {jack} €");
            Console.WriteLine("Insert coin!");
        }

        public static int GetBetting()
        {
            int betInt = 0;
            string betString = Console.ReadLine();
            betInt = int.Parse(betString);
            return betInt;

        }

        public static void DisplaySlotMachine(int[][] slots)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.Write(slots[i][y]);
                }
                Console.WriteLine();
            }

        }

    }
}
