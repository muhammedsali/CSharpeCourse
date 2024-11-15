using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //InterfacesIntro();
            // Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
               new SqlServerCustomerDal(),
               new OracleCustomerDal(),
               new MySqlCustomerDal(),

            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Muhammed",
                LastName = "Sali",
                Address = "Batman"
            };
            Student student = new Student
            {
                Id = 2,
                FirstName = "Gül",
                LastName = "Ekinci",
                Departmant = "Diş Hekimliği"
            };


            manager.Add(student);
            manager.Add(customer);
        }
    }




    interface IPerson //soyut nesne denir
    {
        int Id { get; set; }
        string FirstName { get; }
        string LastName { get; }
    }

    class Customer : IPerson//somut nesne denir
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }


    class PersonManager
    {
        public void Add(IPerson person)
        {

            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
        }
    }
}

