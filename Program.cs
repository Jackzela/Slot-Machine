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
            //int[,] slot = new int[3, 3];
            int[] slot = new int[3];
            int[] Output1 = new int[3];
            int[] Output2 = new int[3];
            int[] Output3 = new int[3];
            int[][] jArray1 = new int[3][] {Output1, Output2, Output3};
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
            Console.WriteLine(jArray1[0][1]);
;           int counter = 0;
            Random randNum = new Random();
            Console.WriteLine("Do the bet!");
            bettingstring = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                for (int y = 0; y < 3; y++)
                {
                    slot[i] = randNum.Next(min, max);
                    jArray1[i][i] = slot[i];
                    for (int j = 0; j < slot.Length; j++) //print 1d array
                    {
                        Console.Write($"{slot[j]}");
                    }
                }
                Console.WriteLine();
            }
            //            for (int x = 0; x < slot.GetLength(0); x++)
            //            {
            //                for (int y = 0; y < slot.GetLength(1); y++)
            //                {
            //                    slot[x, y] = randNum.Next(max);
            //                    Console.Write(slot[x, y]);

            //                }
            //                if (combination1 == Output)
            //                {
            //                    bettingint *= 3;
            //                }
            //                else if (combination2 == Output)
            //                {
            //                    bettingint *= 6;
            //                }
            //                else if (combination3 == Output)
            //                {
            //                    bettingint *= 9;
            //                }
            //                Console.WriteLine();

            //            }
        }
    }
}

