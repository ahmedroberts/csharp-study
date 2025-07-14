using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyPlayerOne.App.People
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public bool HasPet { get; set; } = false;
        public Person(string firstName, string lastName, int age, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
        }

        public void Greeting()
        {
            Console.WriteLine($"HI! {FirstName} {LastName}, Age: {Age}, Email: {Email}");
        }
    }
}
