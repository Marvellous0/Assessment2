using System;
using System.Collections.Generic;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>();
            Console.WriteLine("Enter Integers seperated by space: ");
            string input = Console.ReadLine();
            string[] userInput = input.Split(" ");

            for (int i = 0; i < userInput.Length; i++)
            {
                int num = Convert.ToInt32(userInput[i]);
                Numbers.Add(num);
            }

            int same = Numbers[0];
            for (int i = 0; i < Numbers.Count -1; i++)
            {
                if (Numbers[i]== same && Numbers[i] == Numbers[i + 1])
                {
                    Numbers.Remove(Numbers[i++]);
                }
            }
            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
