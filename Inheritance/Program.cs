using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance//Kalıtım, Miras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[2] {
                new Customer(), new Student()
            };
        }
    }



    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
