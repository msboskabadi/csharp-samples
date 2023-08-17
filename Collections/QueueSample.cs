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

        //public void Dequeue(string input)
        //{
        //    queue.Dequeue(input);
        //}
    }
}
