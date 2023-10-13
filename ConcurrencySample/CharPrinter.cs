using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencySample
{
    public class CharPrinter
    {
        public void PrintStar()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("*");
            }
        }

        public void PrintDash()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("-");
            }
        }
    }
}
