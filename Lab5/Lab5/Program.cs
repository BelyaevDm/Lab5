using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишите число, факториал которого хотите посчитать - ");
            string aN = Console.ReadLine();
            int aNumber = Convert.ToInt32(aN);
            Console.Clear();
            Console.WriteLine($"Для числа {aNumber}, факториалом является:\n");
            int k = 1;
            int k1 = -1;
            int aFactorial = 1;
            if (aNumber > 0)
            {
                for (int i = 0; k <= aNumber; k++)
                {
                    aFactorial = aFactorial * k;
                    Console.Write($"| {aFactorial} ");
                }
            }
            else if (aNumber == 0)
            {
                Console.Write($"| 0 ");
            }
            else
            {
                for (int i = 0; k1 >= aNumber; k1--)
                {
                    aFactorial = aFactorial * k1;
                    Console.Write($"| {aFactorial} ");
                }
            }
            Console.Write("|");
        }
    }
}
