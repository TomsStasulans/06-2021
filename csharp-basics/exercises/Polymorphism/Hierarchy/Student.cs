using System;

namespace Hierarchy
{
    public class Student : Person
    {
        private double _gpa { get; set; }

        public Student(string firstName, string lastName, string address, int id, double gpa) : base(firstName, lastName, address, id)
        {
            _gpa = gpa;
        }

        public override void Display()
        {
            Console.WriteLine($"Students {FirstName} {LastName} GPA is {_gpa}. Address is {Address}. And his Id is {Id}");
        }
    }
}
