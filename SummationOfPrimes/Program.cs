using System;
using System.Collections.Generic;
using System.Numerics;

namespace SummationOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = false;
            ulong sum = 0;
            List<ulong> primeNumbers = new List<ulong>();

            for (ulong i = 2; i < 1000; i++)
            {
                for (ulong j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = true;
                        break;
                    }
                }

                if (!isPrime)
                {
                    sum += i;
                    primeNumbers.Add(Convert.ToUInt64(i));
                }

                isPrime = false;
            }

            for (ulong i = 0; i < Convert.ToUInt64(primeNumbers.Count); i++)
                Console.WriteLine(string.Format("{0,-1}. asal sayi = {1,3}", i + 1, primeNumbers[Convert.ToInt32(i)]));

            Console.WriteLine($"Asal Sayıların Toplamı : {sum}");
            Console.ReadLine();
        }
    }
}
