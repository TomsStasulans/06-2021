﻿using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int result = 1;

            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
