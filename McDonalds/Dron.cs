using System;
using McDonalds.Role;

namespace McDonalds
{
    public class Dron : IDeliver
    {
        public double Cost(string address)
        {
            return 20;
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
