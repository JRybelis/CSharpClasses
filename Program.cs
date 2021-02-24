using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Edward = new Person("Edward", "Snowden");
            Edward.SetDateOfBirth(new DateTime(1982, 2, 14));
            Edward.greeting();
            Edward.ContactNumber = "74946565923";
            Console.WriteLine($"My phone number is :{Edward.ContactNumber}.");

            Person Wallace = new Person(new DateTime(1952, 4, 29), "Wallace", "Breen");
            Wallace.greeting();

            Console.WriteLine($"Object of Person type count: {Person.Count}");
        }
    }
}
