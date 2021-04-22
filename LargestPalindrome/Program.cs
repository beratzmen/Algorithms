using System;
using System.Collections.Generic;

namespace LargestPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {

            int nreversed = 0, result = 0, number = 0;

            for (int i = 999; i > 100; i--)
            {
                for (int j = i - 1; j > 100; j--)
                {
                    result = i * j;
                    number = result;
                    while (result != 0)
                    {
                        nreversed = nreversed * 10;
                        nreversed = nreversed + result % 10;
                        result /= 10;
                    }
                    if (number == nreversed)
                    {
                        Console.WriteLine(string.Format("{0,-2} X {1,-2} = {2,5}", i, j, number));
                        break;
                    }
                    nreversed = 0;
                }
            }

            Console.ReadLine();
        }
    }
}
