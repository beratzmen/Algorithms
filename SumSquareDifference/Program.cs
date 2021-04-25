using System;

namespace SumSquareDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int square = 1;

            for (int i = 1; i < 101; i++)
            {
                sum += i;
                square += i * i;
            }

            Console.WriteLine(string.Format($"Toplamlarının Karesi = {sum * sum} || Karelerinin Toplamı = {square - 1}"));
            Console.WriteLine(string.Format($"Farkları = {(sum * sum) - (square - 1)}"));
            Console.ReadLine();
        }
    }
}
