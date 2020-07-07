
using System.Collections;
using System.Collections.Generic;

namespace SinglyLinkedList
{

    public class Node<T>
    {
        public T Value { get; set; }

        public Node<T> Next { get; set; }

        public Node(T value) => Value = value;
        public Node() => Value = default;  
    }

    class MyList<T> : IEnumerable<T>
    {
        private Node<T> Head { get; set; }
        private Node<T> Tail { get; set; }
        public int Size { get; private set; }

        public T this[int index]
        {
            get
            {
                Node<T> current = Head;

                if (current != null)
                {
                    for (int i = 0; i < index; i++)
                        current = current.Next;
                    return current.Value;
                }
                return default;
            }
            set
            {


                if (index <= Size)
                {
                    Node<T> current = Head;
                    for (int i = 0; i < index; i++)
                        current = current.Next;
                    current.Value = value;

                }

            }
        }

        public MyList()
        {
            Head = null;
            Tail = null;
            Size = 0;
        }

        public MyList(T value)
        {
            Node<T> node = new Node<T>(value);
            Head = node;
            Tail = node;
            Size = 1;
        }
        public MyList(T value, params T[] values) : this(value)
        {
            foreach (T val in values)
                Add(val);
        }

        public void Add(T value)
        {
            var node = new Node<T>(value);

            if (Head == null)
                Head = node;
            else
                Tail.Next = node;

            Tail = node;
            Size++;
        }


        public void Delete(T value)
        {
            var curr = Head;
            var prev = curr;

            while (curr != null)
            {
                if (curr.Value.Equals(value))
                {
                    if (curr == Head)
                        Head = curr.Next;
                    else if (curr == Tail)
                        Tail = prev;
                    else
                        prev.Next = curr.Next;
                    return;
                }
                prev = curr;
                curr = curr.Next;
            }
        }

        public IEnumerator<T> GetEnumerator() => new SinglyLinkedListEnumerator<T>(new Node<T> { Next = Head });

        IEnumerator IEnumerable.GetEnumerator() => new SinglyLinkedListEnumerator<T>(new Node<T> { Next = Head });


    }
}
