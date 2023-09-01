using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    public class StudentCourse 
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public static List<StudentCourse> GetStudentCourses() =>
            new List<StudentCourse>
            {
                new StudentCourse { Id = 1, StudentId = 2, Name = "SQL Server", Score = 9 },
                new StudentCourse { Id = 2, StudentId = 3, Name = "Asp.NET", Score = 7 },
                new StudentCourse { Id = 3, StudentId = 4, Name = "Django", Score = 8 },
                new StudentCourse { Id = 4, StudentId = 5, Name = "Python", Score = 9 },
                new StudentCourse { Id = 5, StudentId = 2, Name = "Mongo DB", Score = 10 },
                new StudentCourse { Id = 6, StudentId = 2, Name = "Redis", Score = 4 },
                new StudentCourse { Id = 7, StudentId = 7, Name = "Postgre SQL", Score = 5 },
                new StudentCourse { Id = 8, StudentId = 3, Name = "Laravel", Score = 10 }
            };
    }

    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }

        public static List<Student> GetStudents() =>
            new List<Student>
            {
                new Student { Id = 1, FirstName = "arshia", LastName = "saremi", Grade = 10},
                new Student { Id = 2, FirstName = "sajjad", LastName = "boskabadi", Grade = 20},
                new Student { Id = 3, FirstName = "sina", LastName = "hemati", Grade = 12},
                new Student { Id = 4, FirstName = "ahmad", LastName = "mahboubi", Grade = 14},
                new Student { Id = 5, FirstName = "hasan", LastName = "sahbi", Grade = 8},
                new Student { Id = 6, FirstName = "arman", LastName = "kazemi", Grade = 16},
                new Student { Id = 7, FirstName = "sonhan", LastName = "hemati", Grade = 12},
                new Student { Id = 8, FirstName = "amir mohammad", LastName = "usefi", Grade = 12}
            };

        public static void PrintFilterStudent(List<Student> st)
        {
            foreach(Student student in st)
            {
                Console.WriteLine(student);
            }
        }
    }
}
