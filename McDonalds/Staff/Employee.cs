using ListExample;
using System;

namespace McDonalds.Staff
{
    public abstract class Employee : IElement
    {
        public Employee(string firstName, string lastName, DateTime dob)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Role { get; set; }

        public string Name
        {
            get { return LastName; }
        }
    }
}
