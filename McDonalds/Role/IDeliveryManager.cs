using System;

namespace McDonalds.Role
{
    public interface IDeliveryManager
    {
        bool Deliver(string address, DateTime expectedTime);
    }
}
