using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter scores seperated by space: ");
            string input = Console.ReadLine();
            string[] scores = input.Split(" ");

            int addUserInput = 0;
            int noOfInput = 0;
            //int average = 0;
            int aboveAverage = 0;
            int belowAverage = 0;
            int equalTo = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                int num = Convert.ToInt32(scores[i]);
                addUserInput += num;
                noOfInput++;
            }

            int average = addUserInput / noOfInput;

            for (int i = 0; i < scores.Length; i++)
            {
                int num = Convert.ToInt32(scores[i]);
                if(num > average)
                {
                    aboveAverage++;
                }   

                else if(num < average)
                {
                    belowAverage++;
                }
                else if(num == average)
                {
                    equalTo++;
                }
            }
            Console.WriteLine($"Number greater than average: {aboveAverage}. ");
            Console.WriteLine($"Number equal to average: {equalTo}. ");
            Console.WriteLine($"Number below average: {belowAverage}. ");
        }
    }
}
