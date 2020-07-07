
using System.Collections;


namespace SinglyLinkedList
{
    interface ISinglyLinkedList<T>
    {
        void Add(T item);

        T this[int index] { get; }

        void Delete(T item);
    }

    public class Node<T>
    {
        public T Value { get; set; }

        public Node<T> Next { get; set; }

        public Node(T value)
        {
            Value = value;
        }
        public Node() => Value = default; //дефолтное значение этого типа
    }

    class MyList<T> : IEnumerable, ISinglyLinkedList<T>
    {
        public Node<T> Head { get; protected set; }
        public Node<T> Tail { get; protected set; }
        public int Count { get; protected set; }

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
        }

        public MyList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public MyList(T value)
        {
            Node<T> node = new Node<T>(value);
            Head = node;
            Tail = node;
            Count = 1;
        }
        public MyList(T value, params T[] values) : this(value)
        {
            foreach (var val in values)
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
            Count++;
        }


        public void Delete(T value)
        {
            var current = Head;
            var previous = current;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    if (current == Head)
                        Head = current.Next;
                    else if(current == Tail)
                        Tail = previous;
                    else
                        previous.Next = current.Next;
                    return;
                }
                previous = current;
                current = current.Next;
            }
        }

        public IEnumerator GetEnumerator()
        {
            Node<T> preHead = new Node<T>
            {
                Next = Head
            };
            return new SinglyLinkedListEnumerator<T>(preHead);
        }

    }
}
