using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencySample
{
    public class CountiutionSample
    {
        public void Start()
        {
            Task<int> sumResult = Task.Run(() => Sum(100, 200));
            var awaiter = sumResult.GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                var result = awaiter.GetResult();
                Console.WriteLine($"sum result is {result}");
            });

            Console.WriteLine("finished");
            Console.ReadLine();
        }

        public void Start2()
        {
            Task<int> result = Task.Run(() => Sum(100, 200));
            result.ContinueWith(t => Console.WriteLine("hi"));
            Console.WriteLine("finished");
            Console.ReadLine();
        }

        public int Sum(int num1, int num2)
        {
            Console.WriteLine("Sum");
            Thread.Sleep(3000);
            Console.WriteLine("hi hi hi hi hi");
            return num1 + num2;
        }
    }
}
