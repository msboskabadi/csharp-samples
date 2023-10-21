using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencySample
{
    public class RunTaskSamples
    {
        // for computed work this is more suitable !!!!
        public void Start()
        {
            Task result = Task.Run(() => PrintName());
            Console.WriteLine("finshed !!!");
            Console.WriteLine($"state of task {result.Status}");
            result.Wait();
            Console.WriteLine($"state of task {result.Status}");
        }
        // for i/o bound work this is more suitable !!!
        public void StartLongRunning()
        {
            Task result = Task.Factory.StartNew(() => PrintName(), TaskCreationOptions.LongRunning);
            Console.WriteLine("finshed !!!");
            Console.WriteLine($"state of task {result.Status}");
            result.Wait();
            Console.WriteLine($"state of task {result.Status}");
        }

        public void StartColdTask()
        {
            Task result = new Task(PrintName);
            Console.WriteLine($"state of task {result.Status}");

            // this is very important
            // cold task must be manual start
            result.Start();

            Console.WriteLine("finshed !!!");
            Console.WriteLine($"state of task {result.Status}");
            result.Wait();
            Console.WriteLine($"state of task {result.Status}");
        }

        public void PrintName()
        {
            Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);
            Console.WriteLine(Thread.CurrentThread.IsBackground);
            Thread.Sleep(3000);
            Console.WriteLine("mohammad sajjad boskabadi");
        }
    }
}
