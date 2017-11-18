using System;
using System.Collections.Generic;

using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;



namespace Point_in_the_figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int f0 = 0;
            int f1 = 1;
            int fibonacciNumber = 0;

            for (int i = 0; i < num; i++)
            {
                fibonacciNumber = f0 + f1;

                f0 = f1;
                f1 = fibonacciNumber;
            }

            if (fibonacciNumber < 2)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(fibonacciNumber);
            }
        }

    }
}
