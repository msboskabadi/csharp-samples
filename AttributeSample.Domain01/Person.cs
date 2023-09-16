using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSample.Domain01;

public class Person
{
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


