
using System;
using System.Collections.Generic;

namespace Question10
{
    public class MultiplyNumbers
    {
        public static void MultiplyLargeAndSmallNumbers()
        {
            List<int> Numbers = new List<int>();
            Console.Write("Enter Integers seperated with space: ");
            string input = Console.ReadLine();
            string[] userInput = input.Split(" ");
            int smallestNumber = 0;
            int biggestNumber = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                int num = Convert.ToInt32(userInput[i]);
                Numbers.Add(num);
            }

            int smallest = Numbers[0];
            int biggest = Numbers[1];

            for (int i = 0; i < Numbers.Count; i++)
            {
                if (Numbers[i] <= smallest)
                {
                    smallestNumber = Numbers[i];
                }

                else if(Numbers[i] >= biggest)
                {
                    biggestNumber = Numbers[i];
                }
            }
            Console.WriteLine($"The multiplication of the smallest number and the biggest number is {smallestNumber*biggestNumber}");
        }
    }
}