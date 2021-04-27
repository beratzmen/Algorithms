using System;
using System.Collections.Generic;

namespace SpecialPythagoreanTriplet
{
    class Program
    {
        static void Main(string[] args)
        {
            //PisagorV1();

            List<int> number1 = new List<int>();
            List<int> number2 = new List<int>();
            List<int> number3 = new List<int>();


            for (int a = 1; a < 100; a++)
            {
                for (int b = a+1; b < 100; b++)
                {
                    for (int c = 1; c < 100; c++)
                    {
                        if ((Math.Pow(a, 2) + Math.Pow(b, 2)) == Math.Pow(c, 2))
                        {
                            number1.Add(a);
                            number2.Add(b);
                            number3.Add(c);
                        }
                    }


                }
            }

            for (int i = 0; i < number1.Count; i++)
            {
                Console.Write(string.Format("{0,-2} - {1,-3} = {2,5}", number1[i], number2[i], number3[i] + "\n"));
            }
            Console.ReadLine();
        }

        private static void PisagorV1()
        {
            List<int> number1 = new List<int>();
            List<int> number2 = new List<int>();
            List<int> number3 = new List<int>();

            for (int i = 1; i < 101; i++)
            {
                number1.Add(2 * i + 1);
                number2.Add((2 * (i * i)) + (2 * i));
                number3.Add((2 * (i * i)) + (2 * i) + 1);
            }

            for (int i = 0; i < number1.Count; i++)
            {
                Console.Write(string.Format("{0,-2} - {1,-3} = {2,5}", number1[i], number2[i], number3[i] + "\n"));
            }
        }
    }
}
