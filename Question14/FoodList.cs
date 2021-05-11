using System;
using System.Collections.Generic;

namespace Question14
{
    public class FoodList
    {
        static List<string> Food = new List<string>();

        public static void PrintFoodSentence()
        {
            Console.Write("Enter first favorite food: ");
            string input1 = Console.ReadLine().Trim();
            Food.Add(input1);

            Console.Write("Enter second favorite food: ");
            string input2 = Console.ReadLine().Trim();
            Food.Add(input2);

            Console.Write("Enter third favorite food: ");
            string input3 = Console.ReadLine().Trim();
            Food.Add(input3);

            Console.WriteLine($"I like {input1} very much.");
            Console.WriteLine($"I like {input2} very much.");
            Console.WriteLine($"I like {input3} very much.");
        }
    }
}