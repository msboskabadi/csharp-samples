// See https://aka.ms/new-console-template for more information
using OOP.MyClasses;

Console.WriteLine("Hello, World!");


Parent parent = new();

var parentClassName = parent.GetParentClassName();
Console.WriteLine(parentClassName);

FirstChild firstChild = new();
var childClassName = firstChild.GetChildName(); 
Console.WriteLine(childClassName);  

Console.ReadKey();