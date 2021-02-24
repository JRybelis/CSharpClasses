using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Person(DateTime dateOfBirth,string firstName, string lastName) : this(firstName, lastName)
        {
            SetDateOfBirth(dateOfBirth);
        }

        private DateTime dateOfBirth;
        public void SetDateOfBirth(DateTime date)
        {
            if (date > DateTime.Now)
            {
                Console.WriteLine("Invalid date of birth provided.");
            } else
            {
                dateOfBirth = date;
            }
        }
        public DateTime GetDateOfBirth() => dateOfBirth;

        public void greeting()
        {
            Console.WriteLine($"Hello, my name is {this.FirstName} {this.LastName}, and I was born on {this.dateOfBirth}.");
        }
    }
}
