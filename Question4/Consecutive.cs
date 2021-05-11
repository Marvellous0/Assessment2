using System;
using System.Collections.Generic;

namespace Question4
{
    public class Consecutive
    {
        static List<int> Numbers = new List<int>();
        public static void ConsecutiveNumbers()
        {
            Console.Write("Enter Integers seperated with space: ");
            string input = Console.ReadLine();
            string[] userInput = input.Split(" ");
            

            for (int i = 0; i < userInput.Length; i++)
            {
                int num = Convert.ToInt32(userInput[i]);
                Numbers.Add(num);
            }

            if(Numbers[0] == Numbers[1]-1 && Numbers[1] == Numbers[2]-1 && Numbers[2] == Numbers[3]-1)
            {
                Console.Write("True");
            }

            else
            {
                Console.Write("False");
            }
        }
    }
}