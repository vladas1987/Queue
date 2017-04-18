using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQueue = new Queue();
            myQueue.Enqueue("Item1");
            myQueue.Enqueue("Item2");
            myQueue.Enqueue("Item3");
            myQueue.Enqueue("Item4");
            myQueue.Enqueue("Item5");
            myQueue.Enqueue("Item6");
            myQueue.Enqueue("Item7");
            myQueue.Enqueue("Item8");
            myQueue.Enqueue("Item9");
            myQueue.Enqueue("Item10");

            Console.WriteLine("First Item is : " + myQueue.Peek());
            Console.WriteLine("Items in Queue : " + myQueue.Count);
            Console.WriteLine();

            while (myQueue.Count > 0)
            {
                Object qValue = myQueue.Dequeue();
                Console.WriteLine(qValue.ToString());
                Console.WriteLine("Queue count is: " + myQueue.Count);
                
            }
        }
    }
}
