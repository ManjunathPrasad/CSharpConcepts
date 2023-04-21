using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Constructor.Demo.Interfaces;

namespace Constructor.Demo
{
    public class Person : IPerson
    {
        public static Guid IdentificationNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FullName { get; set; }
        public Address? Location { get; set; }

        //Default Constructor
        public Person()
        {
            IdentificationNumber = Guid.NewGuid();
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Location = Location;
        }

        //Parameterzed constructor
        public Person(Guid guid, string firstName, string lastName)
        {
            IdentificationNumber = guid;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        //Overloaded Parameterized constructor
        public Person(string firstName, string lastName, string fullName)
        {
            IdentificationNumber = Guid.NewGuid();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FullName = fullName;
        }
        public void PrintGuid()
        {
            Console.WriteLine(IdentificationNumber.ToString());
        }
    }
}
