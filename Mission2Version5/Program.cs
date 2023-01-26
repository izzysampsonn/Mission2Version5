using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mission2Version5
{
    class Program
    {
        public static void Main(string[] args)
        {
            int NumOfRolls = 0; // blank is better than null, must instantiate

            // initial text
            Console.Write("Welcome to the dice throwing simulator! \n");
            Console.Write("How many dice rolls would you like to simulate? ");

            // store dice roll count 
            NumOfRolls = Convert.ToInt32(Console.ReadLine());

            // print roll count for testing
            Console.WriteLine("Number of rolls: " + NumOfRolls);

            // declare array
            int[] rollTotals = new int[12];
            int[] percentageTotals = new int[12];
            Random rnd = new Random();

            // iterate through number of rounds, simulate dice roll
            for (int roundNum = 0; roundNum < NumOfRolls; roundNum++)
            {
                // create two random numbers for each round
                int roll1 = rnd.Next(6) + 1;
                int roll2 = rnd.Next(6) + 1;

                int rollSum = roll1 + roll2;

                rollTotals[(rollSum - 2)]++;

            }

            // printing
            for (int roundNum = 0; roundNum < 11; roundNum++)
            {
                double percent = ((double)rollTotals[roundNum] / NumOfRolls) * 100; // calculate percentage
                Console.Write((roundNum + 2) + "\t");
                int hist = (int)Math.Round(percent);

                for (int count = 0; count < hist; count++) // create histogram w asterisks
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
