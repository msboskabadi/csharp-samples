using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class SortedListSample
    {
        SortedList<int, string> lst = new SortedList<int, string>();

        public void Add(int key, string value)
        {
            lst.Add(key, value);    
        }
    }
}
