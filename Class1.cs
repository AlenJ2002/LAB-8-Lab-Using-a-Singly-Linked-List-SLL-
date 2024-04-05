using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLL
{
    public class Node // class
    {
        public string Value { get; set; } // property
        public Node Next { get; set; } // property

        public Node(string value) // constructor
        {
            Value = value;
            Next = null;
        }
    }

    public class LinkedList // class
    {
        public Node Head { get; private set; } // property
        public int Count { get; private set; } // property

        public LinkedList() // constructor
        {
            Head = null;
            Count = 0;
        }

        public void AddFirst(string value) // method
        {
            var newNode = new Node(value); // create a new node
            newNode.Next = Head;
            Head = newNode;
            Count++;
        }

        public void AddLast(string value) // method
        {
            var newNode = new Node(value); // create a new node
            if (Head == null)
            {
                Head = newNode;
            }
            else
            { 
                Node current = Head; // start at the beginning
                while (current.Next != null) // traverse the list
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            Count++;
        }

        public void RemoveFirst() // method
        {
            if (Head != null)
            {
                Head = Head.Next;
                Count--;
            }
        }

        public void RemoveLast() // method
        {
            if (Head == null) return;
            if (Head.Next == null)
            {
                Head = null;
            }
            else
            {
                Node current = Head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
            Count--;
        }

        public string GetValue(int index) // method
        {
            if (index < 0 || index >= Count) throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range."); // check for invalid index

            Node current = Head;
            for (int i = 0; i < index; i++)    // traverse the list
            {
                current = current.Next;
            }
            return current.Value;
        }
    }
}
