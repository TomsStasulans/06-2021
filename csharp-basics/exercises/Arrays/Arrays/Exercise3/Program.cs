﻿using System;


namespace Exercise3
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = {20, 30, 25, 35, -16, 60, -100};

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            int average = sum / numbers.Length;
            Console.WriteLine("Average value of the array elements is : " + average);
        }
    }
}
