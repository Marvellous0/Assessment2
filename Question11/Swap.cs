using System;
using System.Collections.Generic;

namespace Question11
{
    public class Swap
    {
        static List<int> Numbers = new List<int>();

        public static void SwapNumbers()
        {
            Console.WriteLine("Ënter Integers seperated by space: ");
            string input = Console.ReadLine();
            string[] userInput = input.Split(" ");

            for (int i = 0; i < userInput.Length; i++)
            {
                int num = Convert.ToInt32(userInput[i]);
                Numbers.Add(num);
            }

            int temp = 0;
            temp = Numbers[0];
            Numbers[0] = Numbers[Numbers.Count - 1];
            Numbers[Numbers.Count - 1] = temp;
            
            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}