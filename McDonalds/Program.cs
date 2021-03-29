using ListExample;
using McDonalds.Role;
using McDonalds.Staff;
using System;
using System.Collections.Generic;

namespace McDonalds
{
    static class Program
    {
        static List<Employee> employees;

        static void Main(string[] args)
        {
            employees = new List<Employee>
            {
                new DeliveryManager("Alina", "Petrosian", new DateTime(1987, 2, 2)),
                new Cooker("Inna", "Kravtsova", new DateTime(1999, 11, 24)),
                new Manager("Igor", "Petrov", new DateTime(2001, 8, 11)),
                new Manager("Igor222", "Petrov", new DateTime(2001, 8, 11)),
                new Manager("Kirill", "Dorn", new DateTime(1995, 3, 10)),
                new Manager("Valentin", "Skorohod", new DateTime(2004, 3, 7)),
                new Cleaner("Sergey", "Vasnetsov", new DateTime(1993, 8, 8))  
            };

            ListObj<Employee> list = new ListObj<Employee>(employees, "Available employees");
            var item = list["Petrov"];
            var item2 = list[0];

            var isCleaned = UrgentTableClean();
            Console.ReadKey();
        }

        public static bool UrgentTableClean()
        {
            foreach (var employee in employees)
            {
                if (employee is ICleaner)
                {
                    return (employee as ICleaner).CleanTable();
                }
            }

            return false;
        }
    }
}
