using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AttributeSample.Domain01;

[DebuggerDisplay("Person Name is {FirstName} and Famly is {LastName}")]
[DebuggerTypeProxy(typeof(PersonDebuggerProxy))]
public class Person
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age  { get; set; }
}

public class PersonPrinter
{
    private readonly Person _person;

    public PersonPrinter(Person person)
    {
        _person = person;
    }

    public void Print()
    {
        PrintFullName();
        PrintAge();
    }

    public void PrintAge()
    {
        Console.WriteLine($"{_person.FirstName} {_person.LastName}"); ;
    }

    public void PrintFullName()
    {
        Console.WriteLine($"{_person.Age}"); ;
    }
}


