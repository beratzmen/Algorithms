using System;
using System.Collections.Generic;

namespace HighlyDivisibleTriangularNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0, number = 20;
            List<long> triangularNumber = new List<long>();

            for (int i = 1; i < number; i++)
            {
                sum += i;
                triangularNumber.Add(sum);
                Console.Write(i == number - 1 ? sum + "  " : sum + ",");
            }

            Console.WriteLine("\n");

            for (long i = 0; i < triangularNumber.Count; i++)
            {
                Console.Write(string.Format($"{triangularNumber[Convert.ToInt32(i)],-3} =>"));
                for (long j = 1; j <= triangularNumber[Convert.ToInt32(i)]; j++)
                {
                    if (triangularNumber[Convert.ToInt32(i)] % j == 0)
                    {
                        Console.Write(string.Format($" {j } "));

                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
