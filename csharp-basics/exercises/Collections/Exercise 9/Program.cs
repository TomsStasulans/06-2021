using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myList = new HashSet<string>();
            myList.Add("art");
            myList.Add("snake");
            myList.Add("tail");
            myList.Add("eyes");
            myList.Add("ears");
            myList.Clear();
            myList.Add("aaa");
            myList.Add("aaa");

            Console.WriteLine(string.Join(" ", myList));
            Console.ReadKey();
        }
    }
}
