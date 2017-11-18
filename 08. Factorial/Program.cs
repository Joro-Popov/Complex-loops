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
            int factoriel = 1;

            do
            {
                factoriel *= num;
                num--;

            } while (num > 0);
            Console.WriteLine(factoriel);
        }

    }
}
