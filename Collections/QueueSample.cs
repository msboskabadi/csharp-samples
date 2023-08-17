using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class QueueSample
    {
        Queue<string> queue = new Queue<string>();

        public void Enqueue(string input)
        {
            queue.Enqueue(input);   
        }

        public string Peek()
        {
            return queue.Peek();
        }

        public string Dequeue()
        {
            return queue.Dequeue(); 
        }

        public void Count()
        {
            Console.WriteLine($"count of queue is {queue.Count}");
        }
    }
}
