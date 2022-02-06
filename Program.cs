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
            int[] Output1 = new int[3];
            int[] Output2 = new int[3];
            int[] Output3 = new int[3];
            int[][] jOutput = new int[3][] { Output1, Output2, Output3 };
            int[] combination1 = new int[3] { 1, 1, 1 };
            int[] combination2 = new int[3] { 2, 2, 2 };
            int[] combination3 = new int[3] { 3, 3, 3 };
            int[][] jCombination = new int[3][] { combination1, combination2, combination3 };
            int bettingInt = 0;
            int jackpot = 100;
            int counter = 0;
            int prize = 0;
            bool firstLine = CheckLine(jOutput, jCombination,0);
            bool secondLine = CheckLine(jOutput, jCombination,1);
            bool thirtLine = CheckLine(jOutput, jCombination, 2);

            while (jackpot != 0)
            {
                UIMethods.WelcomeMessage(jackpot);
                bettingInt = UIMethods.GetBetting();
                jOutput = GenerateSlots();
                UIMethods.DisplaySlotMachine(jOutput);
                jackpot = calculateJackpot(jackpot, prize);
                UIMethods.showTheJackpot(jackpot);
                prize = calculatePrize(bettingInt, firstLine, secondLine, thirtLine);
                UIMethods.displayPrize(prize);
                jackpot += bettingInt;
                jackpot = calculateNewJackPot(jackpot, prize);

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
        public static bool CheckLine(int[][] jOutput, int[][] jCombination, int lineNumber)
        {
           
            bool isFirstLine = false;

            for (int i = 0; i < 3; i++)
            {
                if (jOutput[i][0] == jCombination[lineNumber][0] &&
                    jOutput[i][1] == jCombination[lineNumber][1] &&
                    jOutput[i][2] == jCombination[lineNumber][2])
                {
                    isFirstLine = true;
                }

            }
            return isFirstLine;
        }

    
        public static int calculateJackpot(int jackpot, int prize)
        {
            int total = jackpot + prize;

            return total;


        }
        public static int calculatePrize(int bettingInt, bool checkFirstLine, bool checkSecondLine, bool checkThirthLine)
        {
            int prize = 0;
            if (checkFirstLine == true)
            {
                prize = bettingInt + 1;
            }
            if (checkSecondLine == true)
            {
                prize = bettingInt + 2;
            }
            if (checkThirthLine == true)
            {
                prize = bettingInt + 3;
            }
            return prize;

        }
        public static int calculateNewJackPot(int jackpot, int prize)
        {
            return jackpot - prize;
        }
    }

}










