using System;
using System.Collections.Generic;

namespace _10001StPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = false;
            int number = 0;
            List<int> primeNumbers = new List<int>();

            Console.Write("örn: 10 => 10'a kadar olan asal sayıları listeler\nbir sayı girin: ");
            number = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i < number; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = true;
                        break;
                    }
                }

                if (!isPrime)
                    primeNumbers.Add(i);

                isPrime = false;
            }

            for (int i = 1; i < primeNumbers.Count; i++)
            {
                Console.WriteLine(string.Format("{0,-3}. asal sayi = {1,3}", i, primeNumbers[i]));
            }

            Console.ReadLine();
        }
    }
}
