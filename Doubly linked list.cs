using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hw_3;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hw_3
{
    public class DoublyLinkedList<T>
    {
        public class Node2<T>
        {
            private T data2;
            private Node2<T> next2;
            private Node2<T> prev2;
            public Node2(T data2)
            {
                this.data2 = data2;
            }
            public Node2(T data2, Node2<T> next2)
            {
                this.data2 = data2;
                this.next2 = next2;
            }
            public T Data
            {
                get { return data2; }
                set { data2 = value; }
            }

            public Node2<T> Next
            {
                get { return next2; }
                set { next2 = value; }
            }
            public Node2<T> Previous
            {
                get { return prev2; }
                set { prev2 = value; }
            }

        }

        private Node2<T> First2;
        private Node2<T> Last2;
        private int Count2;

        public DoublyLinkedList()
        {
            First2 = null;
            Last2 = null;
            Count2 = 0;
        }
        public void Add(T data)
        {
            var newNode = new Node2<T>(data);
            if (Last2 == null)
            {
                First2 = newNode;
                Last2 = newNode;
            }
            else
            {
                newNode.Previous = Last2;
                Last2.Next = newNode;
                Last2 = newNode;
            }
            Count2++;

        }
        public void AddFirst(T data)
        {
            var newNode = new Node2<T>(data, First2);
            if (First2 == null)
            {
                First2 = newNode;
                Last2 = newNode;
                Count2++;
            }
            else
            {
                newNode.Next = First2;
                First2.Previous = newNode;
                First2 = newNode;
                Count2++;
            }
        }
        public void Remove(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("Data can't be null");
            }
            if (First2 == null)
            {
                throw new InvalidOperationException("List is empty");
            }
            if (First2.Data.Equals(data) && Last2.Data.Equals(data))
            {
                First2 = null;
                Last2 = null;
                Count2--;
                return;
            }
            if (First2.Data.Equals(data))
            {
                First2.Next.Previous = null;
                First2 = First2.Next;
                Count2--;
                return;
            }
            if (Last2.Data.Equals(data))
            {
                Last2.Previous.Next = null;
                Last2 = Last2.Previous;
                Count2--;
                return;
            }
            var cur = First2;
            while (cur != null)
            {
                if (cur.Data.Equals(data))
                {
                    cur.Next.Previous = cur.Previous;
                    cur.Previous.Next = cur.Next;
                    Count2--;
                    break;
                }
                cur = cur.Next;
            }
        }
        public void RemoveFirst()
        {
            if (First2 == null)
            {
                throw new InvalidOperationException("List is empty");
            }
            if (First2 == Last2)
            {
                First2 = null;
                Last2 = null;
                Count2--;
                return;
            }
            First2 = First2.Next;
            First2.Previous = null;
            Count2--;
        }

        public void RemoveLast()
        {
            if (Last2 == null)
            {
                throw new InvalidOperationException("List is empty");

            }

            if (First2 == Last2)
            {
                First2 = null;
                Last2 = null;
            }
            else
            {
                Last2 = Last2.Previous;
                Last2.Next = null;
            }

            Count2--;
        }
        public bool Contains(T value)
        {
            if (First2 == null)
            {
                return false;
            }
            var cur = First2;
            while (cur != null)
            {
                if (cur.Data.Equals(value))
                {
                    return true;
                }
                cur = cur.Next;
            }
            return false;
        }

        public T[] ToArray()
        {
            var arr = new T[Count2];
            var cur = First2;
            for (int i = 0; i < Count2; i++)
            {
                arr[i] = cur.Data;
                cur = cur.Next;
            }
            return arr;
        }

        public void Clear()
        {
            First2 = null;
            Last2 = null;
            Count2 = 0;
        }
        public int count { get { return Count2; } }
        public Node2<T> First 
        {
            get { 
                if (First2 == null) 
                { 
                    throw new Exception("List is empty"); 
                } 
                return First2; 
            } 
        }
        public Node2<T> Last
        {
            get { 
                if (Last2 == null) 
                { 
                    throw new Exception("List is empty"); 
                } 
                return Last2; 
            }

        }
        public void PrintAllElements()
        {
            if (First2 == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                var cur = First2;
                while (cur != null)
                {
                    Console.Write(cur.Data + "   ");
                    cur = cur.Next;
                }
                Console.WriteLine();
            }
        }

    }
}
