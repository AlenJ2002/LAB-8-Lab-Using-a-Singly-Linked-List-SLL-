using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLL
{
    public class Node
    {
        public string Value { get; set; }
        public Node Next { get; set; }

        public Node(string value)
        {
            Value = value;
            Next = null;
        }
    }

    public class LinkedList
    {
        public Node Head { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            Head = null;
            Count = 0;
        }

        public void AddFirst(string value)
        {
            var newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
            Count++;
        }

        public void AddLast(string value)
        {
            var newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            Count++;
        }

        public void RemoveFirst()
        {
            if (Head != null)
            {
                Head = Head.Next;
                Count--;
            }
        }

        public void RemoveLast()
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

        public string GetValue(int index)
        {
            if (index < 0 || index >= Count) throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            Node current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Value;
        }
    }
}
