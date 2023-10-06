
using System.Reflection;

var assembly = Assembly.LoadFrom(@"path");

var types = assembly.GetTypes();

Console.WriteLine(assembly.FullName);
foreach (var type in types)
{
    Console.WriteLine($"{type}");
}