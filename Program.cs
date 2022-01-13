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
            int[] slot = new int[3];
            int[] Output1 = new int[3];
            int[] Output2 = new int[3];
            int[] Output3 = new int[3];
            int[][] jArray1 = new int[3][] { Output1, Output2, Output3 };
            int min = 1;
            int max = 3;
            int numberChoosen = '0';
            string bettingstring = "";
            int bettingint = 0;
            char bettingchar = '0';
            int prize = 0;
            int[] combination1 = new int[3] { 1, 1, 1 };
            int[] combination2 = new int[3] { 2, 2, 2 };
            int[] combination3 = new int[3] { 3, 3, 3 };
            jArray1[0] = Output1;
            jArray1[1] = Output2;
            Random randNum = new Random();
            Console.WriteLine("Do the bet!");
            bettingstring = Console.ReadLine();
            for (int y = 0; y < 3; y++)
            {
                for (int i = 0; i < 3; i++)
                {
                    slot[i] = randNum.Next(min, max);
                    jArray1[i][i] = slot[i];

                    Console.Write($"{slot[i]}");
                }
                Console.WriteLine();

            }
            if (combination1 == Output2)
            {
                prize = bettingint * 5;
            }
            if (combination2 == Output2)
            {
                prize = bettingint * 10;
            }
            if (combination3 == Output2)
            {
                prize = bettingint*15;
            }
            if (combination1 == Output1)
            {
                prize = bettingint * 1;
            }
            if (combination2 == Output1)
            {
                prize = bettingint * 3;
            }
            if (combination3 == Output1)
            {
                prize = bettingint * 5;
                if (combination1 == Output3)
            {
                    prize = bettingint * 3;
                }
                if (combination2 == Output3)
                {
                    prize = bettingint * 4;
                }
                if (combination3 == Output3)
                {
                    prize = bettingint * 6;
                }
            }
            if (prize != 0)
            {
                Console.WriteLine($"{prize}");
            }
            
            else
            {
                Console.WriteLine("You Lose!");
            }

        }
    }
}

         
