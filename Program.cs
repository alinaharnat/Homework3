using System.Collections.Generic;

namespace Hw_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Complex number
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Complex number\n");
            Console.ForegroundColor = ConsoleColor.White;

            var num1 = new ComplexNumber<int>(3, 5);
            var num2 = new ComplexNumber<int>(1, 7);

            Console.WriteLine($"Addition: \n{(num1+num2).Print()}\n");
            Console.WriteLine($"Subtraction: \n{(num1 - num2).Print()}\n");

            //Point
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Point\n");
            Console.ForegroundColor = ConsoleColor.White;

            var point = new Point(2, 3);
            Console.WriteLine(point.PrintPoint()+"\n");

            //List
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("List\n");
            Console.ForegroundColor = ConsoleColor.White;

            var list = new myList<int>();
            list.Add(10);
            list.Add(-2);
            list.Add(4); 
            list.Add(5);
            list.Add(12);
            Console.WriteLine("Current list: ");
            list.Print();

            Console.WriteLine("\nInsert:");
            list.Insert(2, 500);
            list.Print();

            Console.WriteLine("\nRemove -2: ");
            list.Remove(-2);
            list.Print();

            Console.WriteLine("\nRemoving an element with index 3: ");
            list.RemoveAt(3); 
            list.Print();

            Console.WriteLine("\nContains 4:");
            Console.WriteLine(list.Contains(4));

            Console.WriteLine("\nContains 11:");
            Console.WriteLine(list.Contains(11));

            Console.WriteLine("\nIndexOf 12:");
            Console.WriteLine(list.IndexOf(12));

            Console.WriteLine("\nReverse:");
            list.Reverse();
            list.Print();

            Console.WriteLine("\nClear:");
            list.Clear();
            list.Print();

            //Linked list
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nLinked list");
            Console.ForegroundColor = ConsoleColor.White;

            var linkedList = new LinkedList<int>();
            linkedList.AddFirst(3);
            linkedList.AddFirst(27);
            linkedList.AddFirst(-10);
            linkedList.AddFirst(15);
            linkedList.AddFirst(12);
            linkedList.AddFirst(1);
            Console.WriteLine("\nCurrent Linked list:");
            linkedList.PrintAllElements();

            Console.WriteLine("\nAdd:");
            linkedList.Add(19);
            linkedList.PrintAllElements();

            Console.WriteLine("\nInsert:");
            linkedList.Insert(2, -54);
            linkedList.PrintAllElements();

            Console.WriteLine("\nContains 1: ");
            Console.WriteLine(linkedList.Contains(1));

            Console.WriteLine("\nContains 4:");
            Console.WriteLine(list.Contains(4));

            Console.WriteLine("\nClear:");
            linkedList.Clear();
            linkedList.PrintAllElements();

            //Doubly linked list
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDoubly linked list");
            Console.ForegroundColor = ConsoleColor.White;

            var doublyLinkedList = new DoublyLinkedList<int>();
            doublyLinkedList.AddFirst(31);
            doublyLinkedList.AddFirst(0);
            doublyLinkedList.AddFirst(-7);
            doublyLinkedList.AddFirst(12);
            doublyLinkedList.AddFirst(1);

            Console.WriteLine("\nCurrent list:");
            doublyLinkedList.PrintAllElements();

            Console.WriteLine("\nAdd:");
            doublyLinkedList.Add(99);
            doublyLinkedList.PrintAllElements();

            Console.WriteLine("\nRemove:");
            doublyLinkedList.Remove(-7);
            doublyLinkedList.PrintAllElements();

            Console.WriteLine("\nRemove first:");
            doublyLinkedList.RemoveFirst();
            doublyLinkedList.PrintAllElements();


            Console.WriteLine("\nRemove last:");
            doublyLinkedList.RemoveLast();
            doublyLinkedList.PrintAllElements();


            Console.WriteLine("\nContains 31:");
            Console.WriteLine(doublyLinkedList.Contains(31));

            Console.WriteLine("\nContains 2:");
            Console.WriteLine(doublyLinkedList.Contains(2));

            Console.WriteLine("\nClear:");
            doublyLinkedList.Clear();
            doublyLinkedList.PrintAllElements();

            //Queue
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nQueue");
            Console.ForegroundColor = ConsoleColor.White;

            var quequ = new Queue<int>();

            quequ.Enqueue(15);
            quequ.Enqueue(2);
            quequ.Enqueue(0);
            quequ.Enqueue(4);
            quequ.Enqueue(1);
            Console.WriteLine("\nCurrent queue:");
            quequ.Print();

            Console.WriteLine("\nDequeue:");
            quequ.Dequeue();
            quequ.Print();

            Console.WriteLine("\nPeek:");
            Console.WriteLine(quequ.Peek());

            Console.WriteLine("\nContains 15:");
            Console.WriteLine(quequ.Contains(15));

            Console.WriteLine("\nContains 1:");
            Console.WriteLine(quequ.Contains(1));

            Console.WriteLine("\nClear:");
            quequ.Clear(); 
            quequ.Print();
        }
    }
}
