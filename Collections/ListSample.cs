using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class ListSample
    {
        // the best practice is pass init capacity
        // List<string> lst = new List<string>(10);
        List<string> lst = new List<string>(); 
        public void PrintCountAndCapacity()
        {
            Console.WriteLine($"capacity is : {lst.Capacity} " +
                $"and count is {lst.Count}");
        }

        public void AddMember(string member)
        {
            lst.Add(member);    
        }

        public void Ensure()
        {
            lst.EnsureCapacity(20); // when we start 
        }

        public void Remove()
        {
            lst.Remove("1");
            lst.RemoveAll(x => x.StartsWith("s"));
            lst.RemoveAt(1);
            lst.RemoveRange(2, 4);
            lst.Clear();
        }

        public void Insert()
        {
            lst.Insert(5, "sina");
        }

        public void Find()
        {
            // findlast and findlastindex search at last
            var result = lst.Find(x => x.StartsWith("s")); // single
            var result01 = lst.FindAll(x => x.StartsWith("sa")); // list
        }
    }
}
