using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class PersonPrinter
    {
        public void Print(PersonToStringDelegate personToString, Person person)
        {
            string s = personToString(person);
        }
    }
}
