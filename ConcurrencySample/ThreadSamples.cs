using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencySample
{
    public class ThreadSamples
    {
        public void CreateThreadSmaples()
        {
            CharPrinter sample = new CharPrinter();
            Thread printDashWorker = new Thread(sample.PrintDash);

            printDashWorker.Name = "DashPriterWorker";
            printDashWorker.Start();

            Console.WriteLine(printDashWorker.IsAlive);

            sample.PrintStar();

            Console.ReadKey();


        }

        public void JoinSample()
        {
            CharPrinter sample = new CharPrinter();
            Thread printDashWorker = new Thread(sample.PrintDash);
            printDashWorker.Start();
            var res = printDashWorker.Join(2);
            sample.PrintStar();
            Console.ReadKey();
        }
    }
}
