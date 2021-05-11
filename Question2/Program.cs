using System;
using System.Collections.Generic;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 9, 2, 56, 8, 10 };
            list.Reverse();

            Console.WriteLine(String.Join(',', list));
        }
    }
}
