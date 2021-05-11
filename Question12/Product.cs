using System;
using System.Collections.Generic;

namespace Question12
{
    public class Product
    {
        static List<int> Numbers = new List<int>();

        public static void ProductOfThreeLargestNumbers()
        {
            Console.Write("Enter Integers seperated by space: ");
            string input = Console.ReadLine();
            string[] userInput = input.Split(" ");

            int temp;

            for (int i = 0; i < userInput.Length; i++)
            {
                int num = Convert.ToInt32(userInput[i]);
                Numbers.Add(num);
            }

            for (int j = 0; j <= userInput.Length - 2; j++)
            {
                for (int i = 0; i <= userInput.Length - 2; i++)
                {
                    if (Numbers[i] > Numbers[i + 1])
                    {
                        temp = Numbers[i + 1];
                        Numbers[i + 1] = Numbers[i];
                        Numbers[i] = temp;
                    }
                }
            }

            int Largest = Numbers[0];
            int secondLargest = Numbers[2];
            int thirdLargest = Numbers[1];

            if (Largest < secondLargest)
            {
                temp = Largest;
                Largest = secondLargest;
                secondLargest = temp;
            }

            else if (secondLargest < thirdLargest)
            {
                temp = secondLargest;
                secondLargest = thirdLargest;
                thirdLargest = temp;
            }

            for (int i = 3; i < Numbers.Count; i++)
            {
                if (Numbers[i] > Largest)
                {
                    secondLargest = Largest;
                    Largest = Numbers[i];
                }

                else if (Numbers[i] > secondLargest && Numbers[i] != Largest)
                {
                    secondLargest = Numbers[i];
                }

                else if (Numbers[i] > thirdLargest)
                {
                    secondLargest = thirdLargest;
                    thirdLargest = Numbers[i];
                }
            }
            Console.WriteLine($"The Largest three numbers are: {Largest} {secondLargest} and {thirdLargest}. ");
            Console.WriteLine($"The product of the first three largest numbers is {Largest * secondLargest * thirdLargest}");
        }
    }
}