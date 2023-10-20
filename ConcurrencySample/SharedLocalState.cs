using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencySample
{
    public class SharedLocalState
    {
        int j = 0;
        public void Start()
        {
            Thread first = new Thread(PrintStart);
            Thread second = new Thread(PrintStart);
            first.Start();
            second.Start();
            Console.Read();
        }

        public void PrintStart()
        {
            int counter = 10;
            for(int i = 0; j < counter; j++)
            {
                Console.Write("*");
            }
        }
    }
}
