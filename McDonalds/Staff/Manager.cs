using System;
using McDonalds.Role;

namespace McDonalds.Staff
{
    public class Manager : Employee, IManager, IIssueResolver, ICooker, IAnimator, ICashier
    {
        public Manager(string firstName, string lastName, DateTime dob)
            : base(firstName, lastName, dob)
        {
        }

        public void Animate()
        {
        }

        public void CompleteOrder()
        {
        }

        public void Cook()
        {
        }

        public string[] GetOrder()
        {
            throw new System.NotImplementedException();
        }

        public void Manage()
        {
        }

        public void ResolveIssue()
        {
        }
    }
}
