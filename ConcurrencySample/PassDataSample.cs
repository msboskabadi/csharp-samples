using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencySample
{
    public class PassDataSample
    {
        public void Start()
        {
            Thread worker = new Thread(()=>PrintFullName("mohammad sajjad", "Boskabadi"));
            worker.Start();
            Console.Read();
        }

        public void ObjectSampleInStart()
        {
            Thread worker = new Thread(PrintObject);
            string passDataVariable = "hello world";
            worker.Start(passDataVariable);
            Console.Read();
        }

        public void PrintObject(object input)
        {
            Console.WriteLine(input.ToString());
        }

        public void PrintFullName(string firstName, string lastName)
        {
            Console.WriteLine($"{firstName} {lastName}");
        }

        public void PrintNumber()
        {
            for(int i = 0; i < 10; i++)
            {
                int temp = i;
                new Thread(() => Console.WriteLine(temp)).Start();
            }
        }
    }
}
