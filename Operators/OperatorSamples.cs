using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class OperatorSamples
    {
        public string ConditionalExpression(int input)
        {
            return input == 0 ? "zero" : "not zero";
        }

        public void Check()
        {
            try
            {
                checked
                {
                    byte b = byte.MaxValue;
                    Console.WriteLine(b);
                    b += 2; // b = checked(b++)
                    Console.WriteLine(b);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("has error occurred");   
            }


        }

        public void CheckIs(object input)
        {

            Console.WriteLine(input is Student);
        }

        public void CheckAs(object input)
        {
            var person = input as Student;   
            if(person != null)
            {
                Console.WriteLine("this is person");
            }
            else
            {
                Console.WriteLine("this is not person");
            }
            
        }

        public void TypeOf()
        {
            Type type = typeof(Student);
            Console.WriteLine(type.Namespace);
            Console.WriteLine(type.Namespace);
            Console.WriteLine(type.AssemblyQualifiedName);
            Console.WriteLine(type.Attributes);
            //Console.WriteLine(type.GetConstructors());

            foreach(var constructor in type.GetConstructors())
            {
                Console.WriteLine(constructor);
            }

            foreach(var prop in type.GetProperties())
            {
                Console.WriteLine(prop);
            }
        }

        public void NullOperation01()
        {
            int? number01 = 2;   
            int res = number01 == null ? 2 : number01.Value; // number01 can be has null or int
            int c = number01 ?? 2;
            Console.WriteLine(c);
            Console.WriteLine(res);
        }

        public void NullOperation02(Student student)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("this is cancel" + student?.Name + "this is cancel"); // this is not throw exception
        }
    }

    public class Teacher
    {

    }

    public class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
    }

    public class Student:Person
    {
        public string StudentNumber { get; set; }
    }
}
