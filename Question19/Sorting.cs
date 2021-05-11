using System;
using System.Collections.Generic;

namespace Question19
{
    public class Sorting
    {
        static List<int> Numbers = new List<int>();

        public static void SortNumbers()
        {
            Console.Write("Enter 10 integers seperated with space: ");
            string input = Console.ReadLine();
            string[] userInput = input.Split(" ");

            for (int i = 0; i < userInput.Length; i++)
            {
                int num = Convert.ToInt32(userInput[i]);
                Numbers.Add(num);
            }

                if(Numbers[0] > Numbers[1] && Numbers[1] < Numbers[2] || Numbers[0] < Numbers[1] && Numbers[1] > Numbers[2])
                {
                    Console.WriteLine("The List is not Sorted at all. ");
                }

                else if(Numbers[0] > Numbers[0 + 1])
                {
                    Console.WriteLine("The List is in Descending Order. ");
                }

                else if(Numbers[0] < Numbers[0 + 1])
                {
                    Console.WriteLine("The List is in Ascending Order. ");
                }
        }
    }
}