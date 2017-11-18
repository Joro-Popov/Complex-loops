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

            while (num < 1 || num > 100)
            {
                Console.WriteLine($"Invalid number!");
                Console.WriteLine("Enter number:");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {num}");
        }

    }
}
