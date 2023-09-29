// See https://aka.ms/new-console-template for more information


using AttributeSample.Domain01;
using System.Reflection;


// when development mede this data very usage
Person person = new Person();

Type personType00 = person.GetType();

var test00 = personType00.GetConstructors();


// whithout create instance

Type personType01 = typeof(Person);


// in final 

Type personType02 = Type.GetType("ReflectionSample.Teacher", true, true);

Console.ReadLine();


