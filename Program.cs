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
            int[] combination1 = new int[3] { 1, 1, 1 };
            int[] combination2 = new int[3] { 2, 2, 2 };
            int[] combination3 = new int[3] { 3, 3, 3 };
            int[][] jArray2 = new int[3][] { combination1, combination2, combination3 };
            int min = 1;
            int max = 3;
            int numberChoosen = '0';
            string bettingstring = "";
            int bettingint = 0;
            char bettingchar = '0';
            int prize = 0;
            int counter = 0;
            Random randNum = new Random();
            Console.WriteLine("Do the bet!");
            bettingstring = Console.ReadLine();
            bettingint= int.Parse(bettingstring);
            for (int y = 0; y < 3; y++)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (y=0; y < 3;y++)
                    {
                        slot[i] = randNum.Next(min, max);
                        jArray1[i][y] = slot[i];
                        if (jArray1[i][y]==jArray2[i][y])
                        {
                            counter++;
                        }
                        if (counter== 3)
                        {
                            prize = slot[i] * bettingint;
                        }
                        Console.Write($"{slot[i]}");
                    }
                    Console.WriteLine();
                }
            }
              if (counter>3)
            {
                Console.WriteLine($"You Win {prize}");
            }
            else
            {
                Console.WriteLine("You Lose");
            }
        }
    }
}

