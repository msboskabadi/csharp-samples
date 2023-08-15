using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class TestFunctions
    {
        public void TestFunction01()
        {
            

            Console.WriteLine("Hello, World!");


            Person person = new Person()
            {
                FirstName = "sajjad",
                LastName = "boskabadi"
            };
            PersonPrinter<int> personDelegate = new PersonPrinter<int>();

            PersonToStringDelegate myDelegate = PersonFullName.GetPersonFullName; // this is copy 
            var result = myDelegate(person); // this is execute

            personDelegate.Print(PersonFullName.GetPersonFullName, person);
            personDelegate.Print(PersonFullNameReverse.GetPersonFullName, person);

            // -----------------

            Func<int, int, int, string> func = ForFunc.IntToString;
            var res = func(1, 3, 5);
            Console.WriteLine(res);

            personDelegate.PrintFunc(PersonFullName.GetPersonFullName, person);
            personDelegate.PrintFunc(PersonFullNameReverse.GetPersonFullName, person);

            //ForFunc 

            //personDelegate.PrintAction(ForAction.IntToString);
            personDelegate.PrintAction(ForAction<int>.NumericToString, 1, 7, 10);

        }

        public void TestMultiCateDelegate()
        {
            MethodNamePrinter test = new MethodNamePrinter();
            PrintMethodName sample = test.Method01;
            sample += test.Method02;
            sample += test.Method03;


            var list = sample.GetInvocationList();
            foreach(var item in list)
            {
                try
                {
                    item.DynamicInvoke();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());   
                }
            }

            var test01 = sample.Method;

            
            // execute
            //sample();

            Console.WriteLine("///////////");
            Console.WriteLine(test01);
        }

        public void AnonymousMethodSample()
        {
            Person person = new Person()
            {
                FirstName = "mohammad sajjad",
                LastName = "boskabadi" 
            };

            PersonToStringDelegate myDelegate = delegate (Person person)
            {
                return $"{person.FirstName} {person.LastName}";
            };

            var res = myDelegate(person);
            Console.WriteLine(res);
        }

        public void LambdaTest()
        {
            Func<int, string> func = delegate (int x)
            {
                return x.ToString();
            };

            var result = func(1);
            Console.WriteLine(result);

            ///////// lambda expression

            Func<int, string> fucn02 = x => x.ToString();

            Func<int, int, string> fucn03 = (x,y) => $"{x} and {y}";

            Func<int, int, string> fucn04 = (x, y) =>
            {
                return $"{x} and {y}";
            };
        }

        public void TestClosure()
        {
            int localVariable = 1;

            Func<int, int> func = x =>
            {
                return x + localVariable;
            };

            localVariable = 100;

            func(1);
        }
    }
}
