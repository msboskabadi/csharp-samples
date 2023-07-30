using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.People
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "No Name";
        public string LastName { get; set; } = "No LastName";
    }

    public sealed class Teacher : Person
    {

    }

    // this is errror
    //public class Student : Teacher
    //{

    //}
}
