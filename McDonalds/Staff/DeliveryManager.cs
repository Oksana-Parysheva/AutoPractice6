using McDonalds.Role;
using System;
using System.Collections.Generic;

namespace McDonalds.Staff
{
    public class DeliveryManager : Employee, IDeliveryManager
    {
        List<IDeliver> _delivery = new List<IDeliver> { new Car(), new Dron() };

        public DeliveryManager(string firstName, string lastName, DateTime dob)
            : base(firstName, lastName, dob)
        {
        }

        public bool Deliver(string address, DateTime expectedTime)
        {
            foreach (var item in _delivery)
            {
                if (item.GetExpectedTime(address) <= expectedTime)
                {
                    return item.Deliver(address);
                }
            }

            return false;
        }
    }
}