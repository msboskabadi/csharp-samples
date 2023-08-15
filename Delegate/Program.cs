// See https://aka.ms/new-console-template for more information


using Delegate;

//TestFunctions test = new TestFunctions();

//test.TestMultiCateDelegate();
//test.AnonymousMethodSample();

Teacher teacher = new("mohammad sajjad", "the best teacher");
TeacherChangeNameLogger tl = new TeacherChangeNameLogger();
teacher.TeacherNameChange += tl.Log;

teacher.SetName("sina");


Console.ReadKey();
