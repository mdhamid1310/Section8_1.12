using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLibrary
{
    public class Queue
    {
        private List<int> items = new List<int>();

        public void Enqueue(int data)
        {
            items.Add(data);
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            int data = items[0];
            items.RemoveAt(0);
            return data;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return items[0];
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }
    }

}
