using System;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 110; i++)
            {
                string str = "";
                if (i % 3 == 0)
                {
                    str += "Coza";
                } 
                
                if (i % 5 == 0)
                {
                    str += "Loza";
                }
                
                if (i % 7 == 0)
                {
                    str += "Woza";
                }
                 if(i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                {
                    str += i;
                }

                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}