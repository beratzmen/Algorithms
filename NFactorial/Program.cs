using System;
using System.Numerics;

namespace NFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger factorial = 1;
            uint number;
            Console.Write("bir sayı giriniz: ");
            number = Convert.ToUInt32(Console.ReadLine());

            if (number <= 0 || number > 50)
            {
                if (number == 0)
                {
                    Console.WriteLine("0' ın faktoriyeli = {0}", 1);
                }
                Console.WriteLine("girilen sayı 0 ile 50 arasında olmalı");
            }
            else
            {
                while (number <= 50)
                {
                    factorial = 1;
                    for (uint i = number; i > 0; i--)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine("Sayı {0} - faktoriyel {1}", number, factorial);
                    number++;
                }

                Console.WriteLine(factorial);
            }
        }
    }
}
