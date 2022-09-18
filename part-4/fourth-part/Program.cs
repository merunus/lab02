using System;
using System.Reflection;

namespace hw4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.Surname = "Smith";
            user.Name = "Bob";
            user.Login = "bobsmith1337";
            user.Age = 33;

            foreach (PropertyInfo property in user.GetType().GetProperties())
            {
                Console.WriteLine(property.Name + " : " + property.GetValue(user, null));
            }

            Console.ReadLine();
        }
    }
}