using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class PriorityQueueSample
    {
        PriorityQueue<string, int> priorityQueue00 = new PriorityQueue<string, int>();

        public void AddWithSamePriority()
        {
            priorityQueue00.Enqueue("1", 1);
            priorityQueue00.Enqueue("2", 2);
            priorityQueue00.Enqueue("3", 3);

            Console.WriteLine(priorityQueue00.Dequeue());
            Console.WriteLine(priorityQueue00.Dequeue());
            Console.WriteLine(priorityQueue00.Dequeue());
        }
    }
}
