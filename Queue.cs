using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_3
{
    public class Queue<T> 
    {
        private List<T> items = new List<T>();
        private int Count;
        public Queue() 
        { 
          var list = new List<T>();
          
        }
        public void Enqueue(T data)
        {
            items.Insert(0, data);
        }
        public void Dequeue()
        {
            if (items.Count == 0)
                throw new InvalidOperationException();
            items.RemoveAt(0);
        }
        public void Clear()
        {
            items.Clear();
        }
        public bool Contains(T item)
        {
            return items.Contains(item);
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return items[0];
        }
        public  T[]  ToArray() 
        { 
            return items.ToArray(); 
        }
        public  int _Count
        {
            get { return items.Count; }
        }
        public void Print()
        {
           if(items.Count == 0)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                foreach (var item in items)
                {
                    Console.Write(item + "   ");
                }
                Console.WriteLine();
            }
        }

    }

}
