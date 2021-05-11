using System;
using System.Collections.Generic;

namespace Question7
{
    public class NumberGrouping
    {
        private static List<int> OddNumbers = new List<int>();

        private static List<int> EvenNumbers = new List<int>();

        private static List<int> PrimeNumbers = new List<int>();
        public static void GetNumbers()
        {
            Console.Write("Enter an Integer seperated by space: ");
            string input = Console.ReadLine();
            string[] userInput = input.Split(" ");

            for (int i = 0; i < userInput.Length; i++)
            {
                int num = Convert.ToInt32(userInput[i]);
                if(num % 2 == 0)
                {
                    EvenNumbers.Add(num);
                }

                else if(num % 2 == 1)
                {
                    OddNumbers.Add(num);
                }
            }
            PrintEvenNumbers();
            PrintOddNumbers();
            PrintPrimeNumbers();
        }

        public static void PrintOddNumbers()
        {
            Console.WriteLine($"List of Odd Numbers: ");
            foreach (var item in OddNumbers)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintEvenNumbers()
        {
            Console.WriteLine($"List of Even Numbers: ");
            foreach (var item in EvenNumbers)
            {
                Console.WriteLine(item);
            }
        } 

        public static void PrintPrimeNumbers()
        {
            Console.WriteLine("List Of Prime Numbers: ");
            foreach (var item in PrimeNumbers)
            {
                Console.WriteLine(item);
            }
        }       
    }
}