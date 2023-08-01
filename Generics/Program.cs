// See https://aka.ms/new-console-template for more information
using Generics;

Console.WriteLine("Hello, World!");


GenericConcate<int> genericConcateInt = new GenericConcate<int>();
Console.WriteLine(genericConcateInt.Concat(3, 5));

GenericConcate<string> genericConcateStr = new GenericConcate<string>();
Console.WriteLine(genericConcateStr.Concat("sajjad", " sina"));

Person person1 = new Person
{
    FirstName = "mohammad sajjad",
    LastName = "boskabadi"
};

Person person2 = new Person
{
    FirstName = "negin",
    LastName = "niksersht"
};

GenericConcate<Person> genericConcatePerson = new GenericConcate<Person>();
Console.WriteLine(genericConcatePerson.Concat(person1, person2));

Console.ReadKey();