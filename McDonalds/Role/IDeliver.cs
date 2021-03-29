using System;

namespace McDonalds.Role
{
    public interface IDeliver
    {
        bool Deliver(string address);
        DateTime GetExpectedTime(string address);
        double Cost(string address);
    }
}
