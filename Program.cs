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
            string bettingString = "";
            int bettingInt = 0;
            int jackpot = 100;
            int counter = 0;

            while (jackpot != 0)
            {
                UIMethods.WelcomeMessage(jackpot);
                jOutput = GenerateSlots();
                UIMethods.DisplaySlotMachine(jOutput);



                bettingInt = UIMethods.GetBetting();
                jackpot += bettingInt;


                int prize = 0;

                //compare every line with the first combination

                {


                    for (int i = 0; i < 3; i++)
                    {
                        if (jOutput[i][0] == jCombination[0][0] &&
                            jOutput[i][1] == jCombination[0][1] &&
                            jOutput[i][2] == jCombination[0][2])
                        {

                            prize = prize + 1;


                        }


                        if (jOutput[i][0] == jCombination[1][0] &&
                            jOutput[i][1] == jCombination[1][1] &&
                            jOutput[i][2] == jCombination[1][2])
                        {
                            prize = prize + 2;

                        }

                        if (jOutput[i][0] == jCombination[2][0] &&
                            jOutput[i][1] == jCombination[2][1] &&
                            jOutput[i][2] == jCombination[2][2])
                        {
                            prize = prize + 3;


                        }

                    }

                }
                bool isJackpot = CheckJackpot(jOutput, jCombination);

                if (isJackpot == true)
                    prize = jackpot;
                for (int i = 0; i < 3; i++)
                {

                    for (int j = 0; j < 3; j++)//with this loop the program check if user's won the jackpot
                    {
                        if (jOutput[i][j] == jCombination[i][j])
                        {
                            counter++;
                        }
                    }
                    if (counter == 9)
                    {
                        prize = jackpot;
                    }
                    counter = 0;
                }

                if (jOutput[0][0] == jOutput[1][1] && jOutput[1][1] == jOutput[2][2])//this rewards the user for diagonals combination
                {
                    prize = jOutput[0][0];
                }
                if (jOutput[0][2] == jOutput[1][1] && jOutput[1][1] == jOutput[2][0])//this rewards the user for diagonals combination
                {
                    prize = jOutput[0][2];
                }
                jackpot = jackpot - prize;
                Console.WriteLine($"You win {prize} €");
                prize = 0;

            }
        }

        private static bool CheckJackpot(int[][] jOutput, int[][] jCombination)
        {
            int counter = 0;
            bool isJackpot = false;
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)//with this loop the program check if user's won the jackpot
                {
                    if (jOutput[i][j] == jCombination[i][j])
                    {
                        counter++;
                    }
                }
                if (counter == 9)
                {
                    isJackpot = true;
                }

                counter = 0;
            }

            return isJackpot;
        }

        public static int[][] GenerateSlots()
        {
            Random randNum = new Random();
            int min = 1;
            int max = 4;
            int[] slot = new int[3];
            int[] Output1 = new int[3];
            int[] Output2 = new int[3];
            int[] Output3 = new int[3];
            int[][] jOutput = new int[3][] { Output1, Output2, Output3 };
            //UIMethods.DisplaySlotMachine(jOutput);
            for (int y = 0; y < 3; y++)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (y = 0; y < 3; y++)
                    {
                        slot[i] = randNum.Next(min, max);
                        jOutput[i][y] = slot[i];

                    }

                }
            }
            return jOutput;
        }
        public static bool checkFirstLine(int[][] jOutput, int[][] jCombination)
        {
            bool isFirstLine = false;
            for (int i = 0; i < 3; i++)
            {
                if (jOutput[i][0] == jCombination[0][0] &&
                    jOutput[i][1] == jCombination[0][1] &&
                    jOutput[i][2] == jCombination[0][2])
                {

                    isFirstLine = true;
                }

            }
            return isFirstLine;
        }
    }

}










