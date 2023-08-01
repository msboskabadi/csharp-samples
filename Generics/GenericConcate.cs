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
}
