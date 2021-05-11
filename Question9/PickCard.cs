using System;
using System.Collections.Generic;

namespace Question9
{
    public class PickCard
    {
        static List<string> Numbers = new List<string>();

        public static void pickCard()
        {
            Console.WriteLine("Pick number 4 numbers in words sepeated with space from 0-52. ");
            string input = Console.ReadLine();
            string[] userInput = input.Split(" ");
            int sum = 0;

            Numbers.Add(input);

            if (input == "One")
            {
                Console.WriteLine("You picked Ace. ");
            }

            else if (input == "Thirteen")
            {
                Console.WriteLine("You picked King. ");
            }

            else if (input == "Twelve")
            {
                Console.WriteLine("You picked Queen. ");
            }

            else if (input == "Eleven")
            {
                Console.WriteLine("You picked Jack. ");
            }

            for (int i = 0; i < Numbers.Count; i++)
            {
                sum = input[0] + input[1] + input[2] + input[3];
                Console.WriteLine(sum);
            }

            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
            }
        }

    }
}