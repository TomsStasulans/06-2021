using System;

namespace Hierarchy
{
    internal class Employee : Person
    {
        private string _jobTitle { get; set; }

        public Employee(string firstName, string lastName, string address, int id, string jobTitle) : base(firstName, lastName, address, id)
        {
            _jobTitle = jobTitle;
        }

        public override void Display()
        {
            Console.WriteLine($"Employees {FirstName} {LastName} job is {_jobTitle}. Address is {Address}. And his Id is {Id}");
        }
    }
}
