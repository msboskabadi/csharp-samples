using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Animals
{
    public class Animal
    {
        public virtual void Voice()
        {
            Console.WriteLine("animal voice");
        }
    }

    public class Cat : Animal 
    {
        public override void Voice()
        {
            base.Voice();
            Console.WriteLine("Mio");
        }
    }

    public class Dog : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Vagh");
        }
    }

    public class Cow : Animal
    {

    }

}
