using System;
using System.Reflection;

namespace hw1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Country = "Ukraine";
            address.Apartment = "123";
            address.Street = "Keleskaya";
            address.House = "123";
            address.City = "Vinnitsa";
            address.Index = 123;

            foreach (PropertyInfo property in address.GetType().GetProperties())
            {
                Console.WriteLine(property.Name + " : " + property.GetValue(address, null));
            }

            Console.ReadLine();
        }
    }
}