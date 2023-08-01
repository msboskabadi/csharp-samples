//// See https://aka.ms/new-console-template for more information
//using Generics;

//Console.WriteLine("Hello, World!");


//GenericConcate<int> genericConcateInt = new GenericConcate<int>();
//Console.WriteLine(genericConcateInt.Concat(3, 5));

//GenericConcate<string> genericConcateStr = new GenericConcate<string>();
//Console.WriteLine(genericConcateStr.Concat("sajjad", " sina"));

//Person person1 = new Person
//{
//    FirstName = "mohammad sajjad",
//    LastName = "boskabadi"
//};

//Person person2 = new Person
//{
//    FirstName = "negin",
//    LastName = "niksersht"
//};

//GenericConcate<Person> genericConcatePerson = new GenericConcate<Person>();
//Console.WriteLine(genericConcatePerson.Concat(person1, person2));

using Generics;

Teacher teacher = new Teacher
{
    FirstName = "teacherName",
    LastName = "teacherFamily",
    TeacherNumber = "teacherNumber"
};

Student student = new Student
{
    FirstName = "studentName",
    LastName = "studentFamily",
    StudentNumber = "studentNumber"
};

PersonPrinter<Teacher> teacherPrinter = new PersonPrinter<Teacher>();
teacherPrinter.Print(teacher);


PersonPrinter<Student> studentPrinter = new PersonPrinter<Student>();
studentPrinter.Print(student);

PersonPrinter<Car> carPrinter = new PersonPrinter<Car>();
carPrinter.Print(new Car { Id=1234});
Console.ReadKey();