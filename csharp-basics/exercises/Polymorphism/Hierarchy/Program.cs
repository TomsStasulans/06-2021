using System;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Bob = new Student("Bob", "Field", "Osa 3", 12344321, 82.5);
            Employee Jon = new Employee("Rob", "Lake", "Vaku 5", 43211234, "SandMan");

            Bob.Display();
            Jon.Display();
            Console.ReadKey();
        }
    }
}