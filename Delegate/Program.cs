// See https://aka.ms/new-console-template for more information
using Delegate;

Console.WriteLine("Hello, World!");


Person person = new Person()
{
    FirstName = "sajjad",
    LastName = "boskabadi"
};
PersonPrinter personFunc = new PersonPrinter();

PersonToStringDelegate myDelegate = PersonFullName.GetPersonFullName; // this is copy 
var result = myDelegate(person); // this is execute

personFunc.Print(PersonFullName.GetPersonFullName, person);
personFunc.Print(PersonFullNameReverse.GetPersonFullName, person);
