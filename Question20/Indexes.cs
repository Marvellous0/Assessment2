using System;
using System.Collections.Generic;

namespace Question20
{
    public class Indexes
    {
        public static void SumAtIndexes()
        {
            List<int> Numbers = new List<int>();
            Console.Write("Enter 10 integers seperated with space: ");
            string input = Console.ReadLine();
            string[] userInput = input.Split(" ");
            int sumAtOddIndexes = 0;
            int sumAtEvenIndexes = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                int num = Convert.ToInt32(userInput[i]);
                Numbers.Add(num);
            }

            for (int i = 0; i < Numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    sumAtEvenIndexes += Numbers[i];
                }

                else
                {
                    sumAtOddIndexes += Numbers[i];
                }
            }
            Console.WriteLine($"Sum at Odd indexes = {sumAtOddIndexes}");
            Console.WriteLine($"Sum at Even indexes = {sumAtEvenIndexes}");
        }
    }
}