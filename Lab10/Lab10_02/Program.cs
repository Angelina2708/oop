using System;

namespace OneWayListChar
{
    class Program
    {
        static void Main(string[] args)
        {
            OneWayList list1 = new OneWayList();
            list1 = 'a' + list1;
            list1 = 'b' + list1;
            list1 = 'c' + list1;
            Console.WriteLine("List 1:");
            list1.Print();

            OneWayList list2 = new OneWayList();
            list2 = 'c' + list2;
            list2 = 'b' + list2;
            list2 = 'a' + list2;
            Console.WriteLine("List 2:");
            list2.Print();

            if (list1 == list2)
                Console.WriteLine("List 1 and List 2 are equal.");
            else
                Console.WriteLine("List 1 and List 2 are not equal.");

            list1 = --list1;
            Console.WriteLine("List 1 after removing first element:");
            list1.Print();

            Console.ReadLine();
        }
    }

    class Node
    {
        public char Value;
        public Node Next;
    }

    class OneWayList
    {
        private Node _head;

        public static OneWayList operator +(char value, OneWayList list)
        {
            Node newNode = new Node { Value = value, Next = list._head };
            list._head = newNode;
            return list;
        }

        public static OneWayList operator --(OneWayList list)
        {
            if (list._head != null)
            {
                list._head = list._head.Next;
            }
            return list;
        }

        public static bool operator ==(OneWayList list1, OneWayList list2)
        {
            Node current1 = list1._head;
            Node current2 = list2._head;

            while (current1 != null && current2 != null)
            {
                if (current1.Value != current2.Value)
                    return false;

                current1 = current1.Next;
                current2 = current2.Next;
            }

            return current1 == null && current2 == null;
        }

        public static bool operator !=(OneWayList list1, OneWayList list2)
        {
            return !(list1 == list2);
        }

        public override bool Equals(object obj)
        {
            return obj is OneWayList list && this == list;
        }

        public override int GetHashCode()
        {
            return (_head != null ? _head.GetHashCode() : 0);
        }

        public void Print()
        {
            Node current = _head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}