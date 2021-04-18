using System;

namespace Multiples3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, number = 0;
            Console.Write("bir sayı girin: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("0'dan büyük bir sayı giriniz");
            }
            else
            {
                Console.WriteLine("***************************");
                for (int i = 1; i < number; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {                       
                        Console.Write(" " + i + " ");
                        sum += i;
                    }
                }
            }
            Console.WriteLine("\n***************************\nToplam= {0}",sum);
            Console.ReadLine();
        }
    }
}
