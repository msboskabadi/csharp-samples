// See https://aka.ms/new-console-template for more information
using OOP.Animals;
using OOP.MyClasses;


Animal animal = new();
Console.WriteLine("animal voice is : ");
animal.Voice();

Console.WriteLine("---------");

Cat cat = new();
Console.WriteLine("cat voice is : ");
cat.Voice();

Console.WriteLine("---------");

Dog dog = new();
Console.WriteLine("dog voice is : ");
dog.Voice();

Console.WriteLine("---------");

Cow cow = new();
Console.WriteLine("cow voice is : ");
cow.Voice();

Console.WriteLine("---------");

//Console.WriteLine("Hello, World!");


//Parent parent = new();

//var parentClassName = parent.GetParentClassName();
//Console.WriteLine(parentClassName);

//FirstChild firstChild = new();
//var childClassName = firstChild.GetChildName(); 
//Console.WriteLine(childClassName);  

Console.ReadKey();