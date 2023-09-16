

using AttributeSample.Domain01;

Person Person = new Person()
{
    FirstName = "hamid",
    LastName = "lavasani",
    Age = 24
};


PersonPrinter PersonPrinter = new(Person);

PersonPrinter.Print();
Console.ReadLine();