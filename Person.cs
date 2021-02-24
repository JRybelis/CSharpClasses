using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Person
    {
        public string FirstName;
        public string LastName;
        private DateTime dateOfBirth;
        private string contactNumber;

        public static int Count = 0;

        public string ContactNumber
        {
            get { return contactNumber; }
            set { 
                if (value.Length < 9)
                {
                    Console.WriteLine("Invalid contact number length.");
                } else
                {
                    contactNumber = value;
                }
            }
        }
        // public string ContactNumber { get; set; }; // auto implemented getters and setters sould only used if there is no additional logic in the code block, i.e. input validation. 
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Count++;
        }
        public Person(DateTime dateOfBirth,string firstName, string lastName) : this(firstName, lastName)
        {
            SetDateOfBirth(dateOfBirth);
        }

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
