using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Constructor
{
    public class Product
    {
        public Product()
        {
            Console.WriteLine("this is product constructor");
        }
    }

    public class Mobile : Product
    {
        public Mobile()
        {
            Console.WriteLine("this is mobile constructor");
        }
    }
}
