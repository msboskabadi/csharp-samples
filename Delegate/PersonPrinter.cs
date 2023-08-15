using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class PersonPrinter<TInput>
    {
        public void Print(PersonToStringDelegate personToString, Person person)
        {
            string s = personToString(person);
        }
        public void PrintFunc(Func<Person, string> personToString, Person person)
        {
            string s = personToString(person);
        }

        public void PrintAction(Action<TInput, TInput, TInput> action, TInput input, TInput input1, TInput input2)
        {
            action(input, input1, input2);
        }
    }
}
