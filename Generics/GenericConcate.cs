using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericConcate<TInoput>
    {
        public string Concat(TInoput right, TInoput left)
        {
            // this is detect default value for every type
            var defaultValue = default(TInoput);
 
                throw new ArgumentNullException(nameof(right));
                
            var stringRight = right.ToString();
            var stringLeft = left.ToString();
            return stringRight + " " + stringLeft;    
        }
    }

    public class Person
    {  
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"first name {FirstName}, last name {LastName}";
        }
    }

    public class Student : Person
    {
        public string StudentNumber { get; set; }
    }

    public class Teacher : Person
    {
        public string TeacherNumber { get; set; }
    }

    public class PersonPrinter<TInput>
    {
        public void Print(TInput input)
        {
            var person = input as Person;
            Console.WriteLine($"name is {person.FirstName} and family is {person.LastName}");
        }
    }

    public class Car
    {
        public int Id { get; set; }
    }
}
