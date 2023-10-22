using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencySample
{
    public class TaskResultSample
    {
        public void Start()
        {
            Task<int> res = Task.Run(() => Add(100, 200));
            Console.WriteLine(res.Status);
            res.Wait();
            Console.WriteLine(res.Status);
            Console.WriteLine(res.Result);
            //var sum = res.Result;
            Console.WriteLine(res.Status);
            //Console.WriteLine(sum.ToString());
            Console.WriteLine("finished");
        }

        public int Add(int num1, int num2)
        {
            Thread.Sleep(2000);
            return num1 + num2;
        }
    }
}
