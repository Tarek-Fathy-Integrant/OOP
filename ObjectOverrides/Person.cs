using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    internal class Person
    {
        //Properites
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }
        public string SSN { get; }
        //Constructors
        public Person(string firstName, string lastName, int personAge, string ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = personAge;
            SSN = ssn;
        }
        public Person() { }
        //Methods
        public override string ToString() => $"[First Name: {FirstName}; Last Name: {LastName}; Age: {Age}]";
        public override bool Equals(object obj) => obj?.ToString() == ToString();
        public override int GetHashCode() => SSN.GetHashCode();
    }
}
