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
            int counter = int.Parse(Console.ReadLine());
            int number = 1;

            for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{number} ");
                    number++;

                    if (number == counter + 1)
                    {
                        return;
                    }

                }
                Console.WriteLine();
            }
        }

    }
}
