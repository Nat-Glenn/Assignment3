using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

namespace Assignment3.Utility
{
    [DataContract]
    public class SLL : ILinkedListADT
    {
        private Node head;
        private int size;

        public SLL()
        {
            head = null;
            size = 0;
        }

       
        [DataMember]
        public List<User> Users
        {
            get
            {
                List<User> userList = new List<User>();
                Node current = head;
                while (current != null)
                {
                    userList.Add(current.Value);
                    current = current.Next;
                }
                return userList;
            }
            set
            {
                Clear();
                foreach (User user in value)
                {
                    AddLast(user);
                }
            }
        }

       
        public bool IsEmpty() => size == 0;

        public void Clear()
        {
            head = null;
            size = 0;
        }

        public void AddLast(User value)
        {
            Node newNode = new Node(value);
            if (IsEmpty())
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            size++;
        }

        public void AddFirst(User value)
        {
            Node newNode = new Node(value);
            newNode.Next = head;
            head = newNode;
            size++;
        }

        public void Add(User value, int index)
        {
            if (index < 0 || index > size)
                throw new IndexOutOfRangeException("Index out of range.");

            if (index == 0)
            {
                AddFirst(value);
            }
            else
            {
                Node newNode = new Node(value);
                Node current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
                size++;
            }
        }

        public void Replace(User value, int index)
        {
            if (index < 0 || index >= size)
                throw new IndexOutOfRangeException("Index out of range.");

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            current.Value = value;
        }

        public int Count() => size;

        public void RemoveFirst()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Cannot remove from an empty list.");

            head = head.Next;
            size--;
        }

        public void RemoveLast()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Cannot remove from an empty list.");

            if (size == 1)
            {
                head = null;
            }
            else
            {
                Node current = head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
            size--;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= size)
                throw new IndexOutOfRangeException("Index out of range.");

            if (index == 0)
            {
                RemoveFirst();
            }
            else
            {
                Node current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;
                size--;
            }
        }

        public User GetValue(int index)
        {
            if (index < 0 || index >= size)
                throw new IndexOutOfRangeException("Index out of range.");

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Value;
        }

        public int IndexOf(User value)
        {
            Node current = head;
            for (int i = 0; i < size; i++)
            {
                if (current.Value.Equals(value))
                    return i;
                current = current.Next;
            }
            return -1; // Not found
        }

        public bool Contains(User value)
        {
            return IndexOf(value) != -1;
        }

        public void Reverse()
        {
            Node prev = null;
            Node current = head;
            while (current != null)
            {
                Node next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }
    }
}