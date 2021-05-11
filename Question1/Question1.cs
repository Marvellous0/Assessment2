using System;
using System.Collections.Generic;

namespace Question1
{
    public class RegisterScore
    {
        static List<int> Numbers = new List<int>();

        public static void StudentGrades()
        {
            Console.WriteLine("Enter Integers seperated by space: ");
            string input = Console.ReadLine();
            string[] userInput = input.Split(" ");
            char grade;

            for (int i = 0; i < userInput.Length; i++)
            {
                int num = Convert.ToInt32(userInput[i]);
                Numbers.Add(num);
            }


            foreach (var item in Numbers)
            {
                if (item >= 80)
                {
                    grade = 'A';
                    Console.WriteLine($"Score: {item}, Grade: {grade}");
                }

                else if (item >= 70 )
                {
                    grade = 'B';
                    Console.WriteLine($"Score: {item}, Grade: {grade}");
                }

                else if(item >= 50)
                {
                    grade = 'C';
                    Console.WriteLine($"Score: {item}, Grade: {grade}");
                }

                else if(item >= 40)
                {
                    grade = 'D';
                    Console.WriteLine($"Score: {item}, Grade: {grade}");
                }

                else 
                { 
                    grade = 'F';
                    Console.WriteLine($"Score: {item}, Grade: {grade}");
                }
            }
        }
    }
}