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

            Person Wallace = new Person(new DateTime(1952, 4, 29), "Wallace", "Breen");
            Wallace.greeting();
        }
    }
}
