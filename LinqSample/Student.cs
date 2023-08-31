using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }

        public static List<Student> GetStudents() =>
            new List<Student>
            {
                new Student { Id = 1, Name = "arshia", LastName = "saremi", Grade = 10},
                new Student { Id = 1, Name = "sajjad", LastName = "boskabadi", Grade = 20},
                new Student { Id = 1, Name = "sina", LastName = "hemati", Grade = 12},
                new Student { Id = 1, Name = "ahmad", LastName = "mahboubi", Grade = 14},
                new Student { Id = 1, Name = "hasan", LastName = "sahbi", Grade = 8},
                new Student { Id = 1, Name = "arman", LastName = "kazemi", Grade = 16},
                new Student { Id = 1, Name = "sonhan", LastName = "hemati", Grade = 12},
                new Student { Id = 1, Name = "amir mohammad", LastName = "usefi", Grade = 9}
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
