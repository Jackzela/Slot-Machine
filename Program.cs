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
            int[][] jOutput = new int[3][] { Output1, Output2, Output3 };
            int[] combination1 = new int[3] { 1, 1, 1 };
            int[] combination2 = new int[3] { 2, 2, 2 };
            int[] combination3 = new int[3] { 3, 3, 3 };
            int[][] jCombination = new int[3][] { combination1, combination2, combination3 };
            int min = 1;
            int max = 4;
            int numberChoosen = '0';
            string bettingstring = "";
            int bettingint = 0;
            char bettingchar = '0';
            int jackpot = 100;

            int counter = 0;
            while (jackpot!=0)
            {
                Random randNum = new Random();
                Console.WriteLine($"The Jackpot is: {jackpot} €");
                Console.WriteLine("Insert coin!");
                bettingstring = Console.ReadLine();
                bettingint = int.Parse(bettingstring);
                jackpot += bettingint;
                for (int y = 0; y < 3; y++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (y = 0; y < 3; y++)
                        {
                            slot[i] = randNum.Next(min, max);
                            jOutput[i][y] = slot[i];
                            Console.Write($"{slot[i]}");
                        }
                        Console.WriteLine();
                    }
                }

                int prize = 0;

                //compare every line with the first combination
                for (int i = 0; i < 3; i++)
                {
                    if (jOutput[i][0] == jCombination[0][0] &&
                        jOutput[i][1] == jCombination[0][1] &&
                        jOutput[i][2] == jCombination[0][2])
                    {
                        prize = bettingint +1;
                        jackpot = jackpot - prize;
                    }

                    if (jOutput[i][0] == jCombination[1][0] &&
                        jOutput[i][1] == jCombination[1][1] &&
                        jOutput[i][2] == jCombination[1][2])
                    {
                        prize = bettingint +2;
                        jackpot = jackpot - prize;
                    }

                    if (jOutput[i][0] == jCombination[2][0] &&
                        jOutput[i][1] == jCombination[2][1] &&
                        jOutput[i][2] == jCombination[2][2])
                    {
                        prize = bettingint +3;
                        jackpot = jackpot - prize;
                    }
                    if ((jOutput[i][0] == jCombination[0][0] &&
                        jOutput[i][1] == jCombination[0][1] &&
                        jOutput[i][2] == jCombination[0][2])&&((jOutput[i][0] == jCombination[2][0] &&
                        jOutput[i][1] == jCombination[2][1] &&
                        jOutput[i][2] == jCombination[2][2])&& (jOutput[i][0] == jCombination[2][0] &&
                        jOutput[i][1] == jCombination[2][1] &&
                        jOutput[i][2] == jCombination[2][2])))
                        {
                        prize = bettingint +10;
                    }

                        if (jOutput[0][0] == jCombination[0][0] &&
                        jOutput[0][1] == jCombination[0][1] &&
                        jOutput[0][2] == jCombination[0][2] &&
                        jOutput[1][0] == jCombination[1][0] &&
                        jOutput[1][1] == jCombination[1][1] &&
                        jOutput[1][2] == jCombination[1][2] &&
                        jOutput[2][0] == jCombination[2][0] &&
                        jOutput[2][1] == jCombination[2][1] &&
                        jOutput[2][2] == jCombination[2][2])
                    {
                        prize = jackpot;
                        jackpot = 0;
                    }
                        if (jOutput[0][0] == jOutput[1][1] && jOutput[2][2] == jOutput[1][1])
                        {
                        prize = jOutput[0][0]*3;
                    }

                }

                Console.WriteLine($"You win {prize} €");
                prize = 0;



            }
        }
    }
}
            


