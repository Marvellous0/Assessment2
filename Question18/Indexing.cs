using System;
using System.Collections.Generic;

namespace Question18
{
    public class Indexing
    {
        static List<int> Numbers = new List<int>();

        public static void FindSmallestIndex()
        {
            Console.Write("Enter Integers seperated with space: ");
            string input = Console.ReadLine();
            string[] userInput = input.Split(" ");
            int index = 0;
            int smallestNumber = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                int num = Convert.ToInt32(userInput[i]);
                Numbers.Add(num);
            }

            int smaller = Numbers[0];
            for (int i = 0; i < Numbers.Count; i++)
            {
                if (Numbers[i] <= smaller)
                {
                    index = i;
                    smallestNumber = Numbers[i];
                }
            }
            Console.WriteLine($"The smallest number is: {smallestNumber}");
            Console.WriteLine($"The index of the smallest number is: {index}");
        }
    }
}