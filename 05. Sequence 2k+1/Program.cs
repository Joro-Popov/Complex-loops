﻿using System;
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
            int n = int.Parse(Console.ReadLine());
            

            for (int num = 1; num <= n; num = num * 2 + 1)
            {
                Console.WriteLine(num);
            }
        }

    }
}
