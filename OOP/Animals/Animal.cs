using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Animals
{
    public abstract class Animal
    {
        public virtual void Voice()
        {
            Console.WriteLine("animal voice");
        }

        public abstract void Feed();
    }

    public class Cat : Animal 
    {
        public override void Feed()
        {
            Console.WriteLine("Milk");
        }

        public override void Voice()
        {
            base.Voice();
            Console.WriteLine("Mio");
        }
    }

    public class Dog : Animal
    {
        public override void Feed()
        {
            Console.WriteLine("ghoosht");
        }

        public override void Voice()
        {
            Console.WriteLine("Vagh");
        }
    }

    public class Cow : Animal
    {
        public override void Feed()
        {
            Console.WriteLine("alaf");
        }
    }

}
