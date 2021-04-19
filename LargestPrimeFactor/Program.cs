using System;
using System.Collections.Generic;
using System.Numerics;

namespace LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 0;
            List<double> divisors = new List<double>();
            List<double> primes = new List<double>();

            Console.Write("bir sayı girin: ");
            number =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nBölenler:");
            for (double i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(" " + i + " ");
                    divisors.Add(i);
                }
            }

            divisors.Reverse();
            bool control = false;
            for (double i = 0; i < divisors.Count; i++)
            {
                for (double j = 2; j < divisors[(int)i]; j++)
                {
                    if (divisors[(int)i] % j == 0)
                    {
                        control = true;
                        break;
                    }
                }
                if (!control)
                {
                    primes.Add(divisors[(int)i]);
                }
                control = false;
            }

            primes.Reverse();
            Console.WriteLine("\n\n****************************\n\nAsal Bölenler:");
            foreach (var item in primes)
            {
                Console.Write(" " + item + " ");
            }

            Console.ReadLine();
        }
    }
}
