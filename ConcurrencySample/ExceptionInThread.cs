using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencySample
{
    public class ExceptionInThread
    {
        public void StartWithoutExceptionHandling()
        {
            try
            {
                Thread thread = new Thread(BadMethod);
                thread.Start();
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception");
            }
        }

        public void StartWithExceptionHandling()
        {
            Thread thread = new Thread(ThreadStartPoint);
            thread.Start();
            Console.Read();
        }

        public void ThreadStartPoint()
        {
            try
            {
                BadMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception");
            }
        }

        public void BadMethod()
        {
            throw new Exception("Bad Method Exception");
        }
    }
}
