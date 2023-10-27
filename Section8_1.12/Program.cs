using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueueLibrary;

namespace Section8_1._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
            Console.ReadLine();
        }

        private static void runApp()
        {
            Queue queue = new Queue();

            // Enqueue elements into the queue
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("Queue elements:");
            while (!queue.IsEmpty())
            {
                int element = queue.Dequeue();
                Console.WriteLine(element);
            }
        }
    }
}
