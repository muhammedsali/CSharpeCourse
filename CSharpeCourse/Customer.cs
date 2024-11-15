using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpeCourse
{
    internal class Customer
    {

        //field - değişken tanımlamak --> public string FirstName;


        //Property tanımlamak, Clasın içine özellikleri tanımlamak için kullanırız.

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }    
        

    }
}
