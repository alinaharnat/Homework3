using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hw_3;

namespace Hw_3
{
    class LinkedList<T>
    {
        public class Node<T>
        {
            private T data;
            private Node<T> next;
            public Node(T data)
            {
                this.data = data;
            }
            public Node(T data, Node<T> next)
            {
                this.data = data;
                this.next = next;
            }
            public T Data
            {
                get { return data; }
                set { data = value; }
            }

            public Node<T> Next
            {
                get { return next; }
                set { next = value; }
            }

        }
        public Node<T> First
        {
            get; private set;
        }
        public Node<T> Last
        {
            get; private set;
        }

        public int _Count
        {
            get; private set;
        }

        public void AddFirst(T data)
        {
            var newNode = new Node<T>(data);
            if (First == null)
            {
                First = newNode;
                Last = newNode;
            }
            else
            {
                newNode.Next = First;
                First = newNode;
            }
            _Count++;
        }

        public void Add(T data)
        {
            var newNode = new Node<T>(data);
            if (First == null)
            {
                First = newNode;
                Last = newNode;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
            }
            _Count++;
        }

        public void Insert(int index, T data)
        {
            if (index < 0 || index > _Count +1)
                throw new ArgumentOutOfRangeException("Index is out of bounds");

            if (index == 0)
            {
                AddFirst(data);
                return;
            }
            if (index == _Count)
            {
                Add(data);
                return;
            }

            var newNode = new Node<T>(data);
            var cur = First;
            for (int i = 0; i < index - 1; i++)
            {
                cur = cur.Next;
            }
            newNode.Next = cur.Next;
            cur.Next = newNode;
            _Count++;

        }
        public void Clear()
        {
            First = null;
            Last = null;
            _Count = 0;
        }
        public bool Contains(T value)
        {
            if (First == null)
            {
                return false;
            }
            var cur = First;
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
            var arr = new T[_Count];
            var cur = First;
            for (int i = 0;i< _Count; i++)
            {
                arr[i] = cur.Data;
                cur = cur.Next;
            }
            return arr;
        }
        public void PrintAllElements()
        {
            if (First == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                var cur = First;
                while (cur != null)
                {
                    Console.Write(cur.Data + "  ");
                    cur = cur.Next;
                }
                Console.WriteLine();
            }
        }


    }
}
