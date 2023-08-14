// See https://aka.ms/new-console-template for more information
using Operators;

//Console.WriteLine("Hello, World!");
// compound operator : += -= ++ --

//OperatorSamples sample = new();

//Person person = new Person();
//Student student = new Student();    

//sample.CheckAs(person); 
//sample.CheckAs(student);

//sample.CheckIs(person);
//sample.CheckIs(student);

//sample.Check();

//sample.TypeOf();

//sample.NullOperation01();
//sample.NullOperation02(null);


//var birthDay = "13771116";
//var year = birthDay[0..4];
//var month = birthDay[4..6]; 
//var day = birthDay[6..8];
//string? completeDate = $"{year}-{month}-{day}";
//Console.WriteLine(completeDate);
//Console.WriteLine(birthDay.Length);
Money money01 = new Money(10000);
Money money02 = new Money(20000);

var sum = money01.Value + money02.Value;
Console.WriteLine(sum);

var sum02 = money01.Add(money02);
Console.WriteLine(sum02);

var sum03 = money01 + money02;
Console.WriteLine($"this operator overloading {sum03.Value}");


var equalityRef01 = new Money(10000);
var equalityRef02 = new Money(10000);

Console.WriteLine($"are two object equal {equalityRef01 == equalityRef02}");
Console.WriteLine($"are two ref object equal {object.ReferenceEquals(equalityRef01, equalityRef02)}");
Console.WriteLine($"are two ref object equal {equalityRef01.Equals(equalityRef02)}");


var test01 = new Wallet();
test01[0, "0910173532"] = new Money(10000);
test01[1, "0910173532"] = new Money(20000);
test01[1, "0910173532"] = 300000;

Console.WriteLine(test01[0, "0910173532"].Value);






Console.ReadKey();