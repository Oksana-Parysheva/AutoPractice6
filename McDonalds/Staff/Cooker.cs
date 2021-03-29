using System;
using McDonalds.Role;

namespace McDonalds.Staff
{
    public class Cooker : Employee, ICooker, ICleaner
    {
        public Cooker(string firstName, string lastName, DateTime dob)
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

        public void Cook()
        {
        }
    }
}
