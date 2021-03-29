using System;
using McDonalds.Role;

namespace McDonalds
{
    public class Car : IDeliver
    {
        public bool IsAbleToPickUpPassanger { get; set; }

        public double Cost(string address)
        {
            return 12;
        }

        public bool Deliver(string address)
        {
            return true;
        }

        public DateTime GetExpectedTime(string address)
        {
            return new DateTime();
        }
    }
}
