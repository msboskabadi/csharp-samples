using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void PrintMethodName();
    public class MethodNamePrinter
    {
        public void Method01()
        {
            Console.WriteLine(nameof(Method01));
        }

        public void Method02()
        {
            Console.WriteLine(nameof(Method02));
        }
        public void Method03()
        {
            Console.WriteLine(nameof(Method03));
        }
        public void Method04()
        {
            Console.WriteLine(nameof(Method04));
        }
        public void Method05()
        {
            Console.WriteLine(nameof(Method05));
        }
        public void Method06()
        {
            Console.WriteLine(nameof(Method06));
        }
    }
}
