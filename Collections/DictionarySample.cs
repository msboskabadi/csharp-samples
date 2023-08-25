using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class DictionarySample
    {
        Dictionary<string, string> dictionary;
        
        public void Add(string key, string value)
        {
            dictionary[key] = value;  
            
            // dictionary.Add(key, value);
        }

        public string Get(string key) => dictionary[key];

        public void PrintAll()
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}
