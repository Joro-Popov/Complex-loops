using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int row = 0; row < count; row++)
            {

                /* След края на втория цикъл с променлива col ще имаме следната форма:
                                                               
                1 2 3 4 5
                2 3 4 5 
                3 4 5 
                4 5 
                5  */

                for (int col = 0; col < count - row; col++)                  

                {
                    int numberToPrint = row + col + 1;

                    Console.Write($"{numberToPrint} ");

                }

                // Третия цикъл ще допълни фигурата:

                for (int i = 0; i < row; i++)
                {
                   
                    Console.Write($"{count - i-1} ");
                }
                Console.WriteLine();
            }
        }
    }
}
