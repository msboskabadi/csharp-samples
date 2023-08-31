using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    public class LinqOperation
    {
        public void NamesPrinterWithoutLinq()
        {
            List<string> names = new List<string>()
            {
                "Ali Ahmadi",
                "Mohammad Sajjad Boskabadi",
                "Hassan Boskabadi",
                "Hamed Lak",
                "Alireza Oroumand"
            };

            List<string> startWithA = new List<string>();
            
            foreach(string name in names)
            {
                if(name.StartsWith("A"))
                    startWithA.Add(name);
            }

            startWithA.Sort();

            if(startWithA.Count > 0)
            {
                foreach(string name in startWithA)
                    Console.WriteLine(name);
            }
        }

        // this is query syantax
        public void NamesPrinterLinqQuery()
        {
            List<string> names = new List<string>()
            {
                "Ali Ahmadi",
                "Mohammad Sajjad Boskabadi",
                "Hassan Boskabadi",
                "Hamed Lak",
                "Alireza Oroumand"
            };

            var startWithA = from name in names where name.StartsWith("A") orderby name select name;

            if (startWithA.Count() > 0)
            {
                foreach(string name in startWithA)
                    Console.WriteLine(name);
            }

        }

        // this is method syntax
        public void NamesPrinterLinqMethod()
        {
            List<string> names = new List<string>()
            {
                "Ali Ahmadi",
                "Mohammad Sajjad Boskabadi",
                "Hassan Boskabadi",
                "Hamed Lak",
                "Alireza Oroumand"
            };

            var startWithA = names.Where(q => q.StartsWith("A")).OrderBy(q => q).Select(c => c);

            if (startWithA.Count() > 0)
            {
                foreach (string name in startWithA)
                    Console.WriteLine(name);
            }

        }
    }
}
