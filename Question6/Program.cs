using System;
using System.Collections.Generic;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> PrimeNumbers = new List<int>();
            int ct = 0, n = 0, i = 1, j = 1;

            while (n < 10)
            {
                j = 1;
                ct = 0;
                while (j <= i)
                {
                    if (i % j == 0)
                        ct++;
                    j++;
                }
                if (ct == 2)
                {
                    Console.Write(i);
                    Console.Write(" ");
                    PrimeNumbers.Add(i);
                    n++;
                }
                i++;
            }
        }
    }
}
