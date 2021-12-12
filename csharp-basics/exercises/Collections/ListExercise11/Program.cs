using System;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<string>();

            myList.Add("one");
            myList.Add("two");
            myList.Add("three");
            myList.Add("four");
            myList.Add("five");
            myList.Add("six");
            myList.Add("seven");
            myList.Add("eight");
            myList.Add("nine");
            myList.Add("ten");

            myList.Insert(4, "wow");

            myList.RemoveAt(myList.Count - 1);
            myList.Insert(myList.Count - 1, "not ten");

            myList.Sort();

            myList.Contains("FooBar");

            foreach (var number in myList)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
