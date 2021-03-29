using System;
using McDonalds.Role;

namespace McDonalds.Staff
{
    public class Cleaner : Employee, ICleaner
    {
        public Cleaner(string firstName, string lastName, DateTime dob)
            : base(firstName, lastName, dob)
        {
        }

        public bool Clean()
        {
            return true;
        }

        public bool CleanTable()
        {
            return true;
        }
    }
}
