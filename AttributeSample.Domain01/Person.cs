using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using CustomeAttributeLib;

namespace AttributeSample.Domain01;

[DebuggerDisplay("Person Name is {FirstName} and Famly is {LastName}")]
[DebuggerTypeProxy(typeof(PersonDebuggerProxy))]

public class Person
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [Required]
    public string FirstName { get; set; }
    [StringLength(100)]
    public string LastName { get; set; }
    public int Age  { get; set; }
}

[AutoScanForDependencyFor]
public class PersonPrinter
{
    private readonly Person _person;

    public PersonPrinter(Person person)
    {
        _person = person;
    }

    public void Print()
    {
        ShowDebugData();
        PrintFullName();
        PrintAge();
    }

    [Conditional("DEBUG")]
    private void ShowDebugData() => Console.WriteLine("this code compiled by debug mode");

    public void PrintAge()
    {
        Console.WriteLine($"{_person.FirstName} {_person.LastName}"); ;
    }

    public void PrintFullName()
    {
        Console.WriteLine($"{_person.Age}"); ;
    }
}


