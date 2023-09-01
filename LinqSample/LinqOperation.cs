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

            var sortedStudent = students.OrderBy(c => c.Name).ToList();
            Student.PrintFilterStudent(sortedStudent);
        }


        public void SortGradeAndNameStudents()
        {
            var students = Student.GetStudents();

            var sortedStudent = students.OrderBy(c => c.Grade).ThenBy(c => c.Name).ToList();
            Student.PrintFilterStudent(sortedStudent);
        }

        public void SortDescStudents()
        {
            var students = Student.GetStudents();

            var sortedStudent = students.OrderByDescending(c => c.Name).ToList();
            Student.PrintFilterStudent(sortedStudent);
        }
    }
}
