using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_3
{
    public class myList<T>
    {
        private T[] arr;
        private int Count;
        public myList()
        {
            this.arr = new T[10];
        }
        public void Add(T value)
        {
            if (Count == arr.Length)
            {
                var newArray = new T[Count+1];
                for (int i = 0; i < Count; i++)
                {
                    newArray[i] = arr[i];
                }
                newArray[Count++] = value;
                arr = newArray;
                Count++;
            }
            else
            {
                arr[Count] = value;
                Count++;
            }
        }

        public void Insert(int id, T value)
        {
            if (id < 0 || id > Count)
            {
                throw new ArgumentOutOfRangeException("Index doesn't exist");
            }

            if (Count == arr.Length)
            {
                var newArray = new T[arr.Length + 1];
                Array.Copy(arr, newArray, id);
                newArray[id] = value;
                Array.Copy(arr, id, newArray, id + 1, Count - id);
                arr = newArray;
            }
            else
            {
                Array.Copy(arr, id, arr, id + 1, Count - id);
                arr[id] = value;
            }
            Count++;
        }

        public void Remove(T value)
        {
            if (Count == 0)
            {
                throw new Exception("List is empty");
            }
            var newArray = new T[arr.Length];
            int j = 0;
            for (int i = 0; i < Count; i++)
            {
                if (arr[i].Equals(value))
                {
                    continue;
                }
                newArray[j] = arr[i];
                j++;
            }
            arr = newArray;
            Count--;
        }
  
        public void RemoveAt(int id)
        {
            if (Count == 0)
            {
                throw new Exception("List is empty");
            }
            var newArray = new T[arr.Length];
            int j = 0;
            for (int i = 0; i < Count; i++)
            {
                if (i == id)
                {
                    continue;
                }
                newArray[j] = arr[i];
                j++;
            }
            arr = newArray;
            Count--;
        }

  
        public void Clear()
        {
            var newArray = new T[arr.Length];
            arr = newArray;

            Count = 0;
        }

        public bool Contains(T value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (arr[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(int value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (arr[i].Equals(value))
                {
                    return i;
                }
            }
            throw new InvalidOperationException("Value doesn't exist in list");

        }

        public T[] ToArray()
        {
            var newArray = new T[Count-1];
            for(int i = 0; i<Count; i++)
            {
                newArray[i] = arr[i];
            }
            return newArray;
        }

        public void Reverse()
        {
            if (Count != 0)
            {
                var newArray = new T[Count];
                int j = 0;
                for (int i = Count - 1; i >= 0; i--)
                {
                    newArray[j] = arr[i];
                    j++;
                }
                arr = newArray;
            }
            else
            {
                throw new InvalidOperationException("List is empty");
            }
        }
        public T this[int index]
        {
            get
            {
                if (index < Count && index >= 0)
                {
                    return arr[index];
                }
                throw new IndexOutOfRangeException("Index is out of bounds");
            }
            set
            {
                if (index < arr.Length && Count != 0 && index >= 0)
                {
                    arr[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of bounds");
                }
            }
        }
        public int GetCount
        {
            get { return Count; }
        }
       public  void Print()
        {
            if(Count == 0)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                for (int i = 0; i < Count; i++)
                {
                    Console.Write(arr[i] + "   ");
                }
                Console.WriteLine();
            }
        }

    }

}
