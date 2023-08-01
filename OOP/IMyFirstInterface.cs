using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IMyFirstInterface
    {
        public void Test();
        public void Temp();
        public void ExplicitTest();
        public void ExplicitTemp();
    }

    public interface IMySecondInterface
    {
        public void ExplicitTest();
        public void ExplicitTemp();
    }

    public class MyFirstInterfaceImplement : IMyFirstInterface, IMySecondInterface
    {
        void IMyFirstInterface.ExplicitTemp()
        {
            Console.WriteLine("explicit temp first class");
        }

        void IMyFirstInterface.ExplicitTest()
        {
            Console.WriteLine("explicit test first class");
        }

        public void Temp()
        {
            Console.WriteLine("implicit temp first class");
        }

        public void Test()
        {
            Console.WriteLine("implicit test first class");
        }

        public void ExplicitTest()
        {
            Console.WriteLine("explicit temp second");
        }

        public void ExplicitTemp()
        {
            Console.WriteLine("explicit temp second");
        }
    }
}
