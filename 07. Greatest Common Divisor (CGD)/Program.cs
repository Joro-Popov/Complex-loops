using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Deviser__GCD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int temp = 0;
            while (b != 0)
            {
                temp = b;
                b = a % b;
                a = temp;

            }
            Console.WriteLine(a);





        }
    }
}
