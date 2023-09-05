using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    public class LinqOperation
    {
        public void NamesPrinterWithoutLinq()
        {
            List<string> names = new List<string>()
            {
                "Ali Ahmadi",
                "Mohammad Sajjad Boskabadi",
                "Hassan Boskabadi",
                "Hamed Lak",
                "Alireza Oroumand"
            };

            List<string> startWithA = new List<string>();
            
            foreach(string name in names)
            {
                if(name.StartsWith("A"))
                    startWithA.Add(name);
            }

            startWithA.Sort();

            if(startWithA.Count > 0)
            {
                foreach(string name in startWithA)
                    Console.WriteLine(name);
            }
        }

        // this is query syantax
        public void NamesPrinterLinqQuery()
        {
            List<string> names = new List<string>()
            {
                "Ali Ahmadi",
                "Mohammad Sajjad Boskabadi",
                "Hassan Boskabadi",
                "Hamed Lak",
                "Alireza Oroumand"
            };

            var startWithA = from name in names where name.StartsWith("A") orderby name select name;

            if (startWithA.Count() > 0)
            {
                foreach(string name in startWithA)
                    Console.WriteLine(name);
            }

        }

        // this is method syntax
        public void NamesPrinterLinqMethod()
        {
            List<string> names = new List<string>()
            {
                "Ali Ahmadi",
                "Mohammad Sajjad Boskabadi",
                "Hassan Boskabadi",
                "Hamed Lak",
                "Alireza Oroumand"
            };

            var startWithA = names.Where(q => q.StartsWith("A")).OrderBy(q => q).Select(c => c);

            if (startWithA.Count() > 0)
            {
                foreach (string name in startWithA)
                    Console.WriteLine(name);
            }

        }


        public void PrintNumbersDiferred()
        {
            List<int> Numbers = new List<int>
            {
                1, 2, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15
            };

            var lessThan10 = from num in Numbers where num < 10  select num;

            foreach (var item in lessThan10)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*************");
            Numbers.Add(3);
            Numbers.Add(5);

            foreach (var item in lessThan10)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintNumbersImediate()
        {
            List<int> Numbers = new List<int>
            {
                1, 2, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15
            };

            var lessThan10 = (from num in Numbers where num < 10 select num).ToList();
            // tolist, toarray, todictionary, tolookup, first, count
            foreach (var item in lessThan10)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*************");
            Numbers.Add(3);
            Numbers.Add(5);

            foreach (var item in lessThan10)
            {
                Console.WriteLine(item);
            }
        }

        public void StudentFilterQuery()
        {
            var students = Student.GetStudents();

            var result = (from student in students where student.Grade > 15 select student).ToList();
            Student.PrintFilterStudent(result);
        }

        public void StudentFilterMethod()
        {
            var students = Student.GetStudents();

            var result = students.Where((q, index) => q.Grade > 15 || q.Grade < index).ToList();

            Student.PrintFilterStudent(result);
        }

        public void FilterByType()
        {
            List<object> list = new List<object> { 1, 2, 3, "sajjad", "hasan", true, 84984 };
            var numbers = list.OfType<int>().ToList();  
            foreach(var item in numbers)
                Console.WriteLine(item);
        }

        public void SortStudents()
        {
            var students = Student.GetStudents();

            var sortedStudent = students.OrderBy(c => c.FirstName).ToList();
            Student.PrintFilterStudent(sortedStudent);
        }


        public void SortGradeAndNameStudents()
        {
            var students = Student.GetStudents();

            var sortedStudent = students.OrderBy(c => c.Grade).ThenBy(c => c.FirstName).ToList();
            Student.PrintFilterStudent(sortedStudent);
        }

        public void SortDescStudents()
        {
            var students = Student.GetStudents();

            var sortedStudent = students.OrderByDescending(c => c.FirstName).ToList();
            Student.PrintFilterStudent(sortedStudent);
        }

        public void GroupStudents()
        {
            var students = Student.GetStudents();

            var groupByGrade = students.GroupBy(q => q.Grade).ToList();

            foreach (var item in groupByGrade)
            {
                Console.WriteLine(item.Key);

                foreach(var student in item)
                    Console.WriteLine(student.FirstName);
                Console.WriteLine(item);
            }
        }

        public void InnerJoin()
        {
            var students = Student.GetStudents();
            var courses = StudentCourse.GetStudentCourses();

            var result = students.Join(courses, s => s.Id, c => c.StudentId, (s, c) =>
                     new
                     {
                         StudentId = s.Id,
                         CourseId = c.Id,
                         StudentName = s.FirstName,
                         c.Name,
                         c.Score
                     }
            );

            foreach(var item in result)
            {
                Console.WriteLine($"{item.StudentName} {item.Name}={item.Score}");
            }
        }

        public void GroupJoin()
        {
            var students = Student.GetStudents();
            var courses = StudentCourse.GetStudentCourses();

            var groupJoin = students.GroupJoin(courses, s => s.Id, c => c.StudentId, (s, c) =>
            new
            {
                s.Id,
                s.FirstName,
                s.Grade,
                StuCourse = c
            }).ToList();

            foreach(var item in groupJoin)
            {
                Console.WriteLine($"{item.FirstName}-{item.StuCourse?.Count()}");

                //foreach(var detailCourse in item.StuCourse)
                //{
                //    Console.WriteLine(detailCourse.Score);
                //}
            }
        }


        public void LeftJoin()
        {
            var students = Student.GetStudents();
            var courses = StudentCourse.GetStudentCourses();

            var leftJoin = students.GroupJoin(courses, s => s.Id, c => c.StudentId, (s, c) =>
            new
            {
                s.Id,
                s.FirstName,
                s.LastName,
                s.Grade,
                StuCourse = c
            }).SelectMany(c=>c.StuCourse.DefaultIfEmpty(), (s,c)=>
            {
                return new
                {
                    s.Id,
                    s.FirstName,
                    s.LastName,
                    s.Grade,
                    courseName = c?.Name ?? "----",
                    courseScore = c?.Score ?? 0
                };
            }
            ).ToList();

            foreach (var item in leftJoin)
            {
                Console.WriteLine($"{item.FirstName}-{item.courseName}-{item.courseScore}");

                //foreach(var detailCourse in item.StuCourse)
                //{
                //    Console.WriteLine(detailCourse.Score);
                //}
            }
        }

        public void ExceptBy()
        {
            List<StudentCourse> lst = new List<StudentCourse>
            {
                new StudentCourse { Id = 1},
                new StudentCourse { Id = 2},
                new StudentCourse { Id = 3},
                new StudentCourse { Id = 3},
                new StudentCourse { Id = 4},
            };

            var res = lst.ExceptBy(new int[] { 2, 3 }, sc => sc.Id);
            foreach(var item in res)
                Console.WriteLine(item.Id);
        }

        public void Pagination(int pageIndex = 0, int pageCount = 3)
        {
            List<int> lst = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            
            var res = lst.Skip(pageIndex * pageCount).Take(pageCount);

            foreach(var item in res)
                Console.WriteLine(item);
        }

        
    }
}
