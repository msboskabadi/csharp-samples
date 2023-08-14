using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate string PersonToStringDelegate(Person person);   
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }    
    }
    public class PersonFullName
    {
        public static string GetPersonFullName(Person person)
        {
            return $"{person.FirstName} {person.LastName}"
        }
    }

    public class PersonFullNameReverse
    {
        public static string GetPersonFullName(Person person)
        {
            return $"{person.LastName} {person.FirstName}"
        }
    }
}
