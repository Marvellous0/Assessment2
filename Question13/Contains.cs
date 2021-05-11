using System;
using System.Collections.Generic;

namespace Question13
{
    public class Contains
    {
        static List<int> Numbers = new List<int>();

        public static void ContainsElement()
        {
            Console.WriteLine("Enter Integers seperated with space: ");
            string input = Console.ReadLine();
            string[] userInput = input.Split(" ");

            for (int i = 0; i < userInput.Length; i++)
            {
                int num = Convert.ToInt32(userInput[i]);
                Numbers.Add(num);
            }

            Console.Write("Enter Integer to search for: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            
            if (Numbers.Contains(userNum))
            {
                Console.Write($"{userNum} exists. ");   
            }

            else
            {
                Console.Write($"{userNum} does not exist. ");
            }
        }
    }
}