// See https://aka.ms/new-console-template for more information
using static ArraySample.ArrayClassSample;

Console.WriteLine("Hello, World!");

int a = 1;

int[] b = new int[] {1, 3, 4, 5};

int[] c = { 1, 4, 7, 8, 0 };

// ii 

int[,] d = new int[2, 2];
d[0, 0] = 1;
d[1, 0] ^= 1;

Console.WriteLine(d[1, 0]);
Console.WriteLine(d[0, 1]);


Person[] test = new Person[3];

test[0] = new Person()
{
    Id = 1,
    FirstName = "zahra"
};

test[1] = new Person()
{
    Id = 5,
    FirstName = "ali"
};

test[2] = new Person()
{
    Id = 3,
    FirstName = "iman"
};



Array.Sort(test, Person.);

foreach (var item in test)
{
    Console.WriteLine(item.FirstName + " " + item.Id);
}

//Console.WriteLine(test);
