using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Point_in_the_figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int result = 0;

            while (num != 0)
            {
                result += num % 10;
                num = num / 10;
            }

            Console.WriteLine(result);
        }

    }
}
