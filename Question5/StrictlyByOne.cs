using System;
using System.Collections.Generic;

namespace Question5
{
    public class StrictlyByOne
    {
        public static void IncreaseStrictlyByOne()
        {
            List<int> Numbers = new List<int>();
            Console.Write("Enter Integers seperated by space: ");
            string input = Console.ReadLine();
            string[] userInput = input.Split(" ");
            int biggestNumber = 0;
            int smallestNumber = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                int num = Convert.ToInt32(userInput[i]);

                Numbers.Add(num);
            }

            int small = Numbers[0];
            int biggest = Numbers[0];

            for (int i = 0; i < Numbers.Count; i++)
            {
                if(Numbers[i] <= small)
                {
                    smallestNumber = Numbers[i];
                }

                if(Numbers[i] >= biggest) 
                {
                    biggestNumber = Numbers[i];
                }
            }

            for (int i = smallestNumber; i <= biggestNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}