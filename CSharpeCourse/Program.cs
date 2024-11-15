using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpeCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Batman";
            customer.Id = 1;
            customer.FirstName = "Muhammmed";
            customer.LastName = "Sali";

            Customer customer2 = new Customer
            {
                Id = 2, FirstName = "Gül", LastName = "Ekinci", City = "Batman"
            };
            Console.WriteLine(customer2.FirstName);

            //Array
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //cars[1] = "Opel";
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}

            Console.ReadLine();


            

           


        }
    }
}
