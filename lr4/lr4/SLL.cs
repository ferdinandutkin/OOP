using System.Collections;
using System;
using System.Linq;
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

    public class MyList<T> : IEnumerable<T>
    {
        private Node<T> Head { get; set; }
        private Node<T> Tail { get; set; }
        public int Size { get; private set; }

        public T this[int index]
        {
            get
            {
                return this.ElementAtOrDefault(index);
            }
            set
            {
                if (index < Size)
                {
                    Node<T> current = Head;
                    for (int i = 0; i < index; i++)
                        current = current.Next;
                    current.Value = value;
                }
            }
        }

        public override bool Equals(object obj) => this == (MyList<T>)obj;

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
        public MyList(T value, params T[] values) : this(value) => Add(values);

        public void Add(params T[] values)
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

        public void Delete(int index)
        {
            int count = 0;
            var curr = Head;
            var prev = curr;

            while (count <= index)
            {
                if (count == index)
                {
                    prev.Next = curr.Next;
                    curr = null;
                }
                else
                {
                    prev = curr;
                    curr = curr.Next;
                }
            }

        }

        public void DeleteByVal(T value)
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

        static public bool operator ==(MyList<T> l, MyList<T> r)
        {
            if (l.Size != r.Size)
                return false;
            else
            {
                bool areEqual = true;
                for (int i = 0; i < l.Size && areEqual; i++)
                    areEqual &= l[i].Equals(r[i]);
                return areEqual;
            }

        }

        public static bool operator <(MyList<T> l, MyList<T> r) //ez
        {
            ref var refl = ref l;
            foreach (T el in r)
                refl.Add(el);
            return true;
        }

        static public bool operator >(MyList<T> l, MyList<T> r) => r < l;


        static public MyList<T> operator +(MyList<T> l, MyList<T> r)
        {
            foreach (var el in r)
                l.Add(el);
            return l;

        }


        static public bool operator !=(MyList<T> l, MyList<T> r) => !(l == r);

        static public MyList<T> operator !(MyList<T> list) //побитовое НЕ определено только для этих типов ничего не знаю
        {
            if (list is MyList<int> intlist)
            {
                for (int i = 0; i < intlist.Size; i++)
                    intlist[i] = ~intlist[i];
                return intlist as MyList<T>;
            }

            else if (list is MyList<uint> uintlist)
            {
                for (int i = 0; i < uintlist.Size; i++)
                    uintlist[i] = ~uintlist[i];
                return uintlist as MyList<T>;
            }

            else if (list is MyList<ulong> ulonglist)
            {
                for (int i = 0; i < ulonglist.Size; i++)
                    ulonglist[i] = ~ulonglist[i];
                return ulonglist as MyList<T>;
            }
            return list;


        }






        public IEnumerator<T> GetEnumerator()
        {
            var curr = Head;
            while (curr != null)
            {
                yield return curr.Value;
                curr = curr.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


}


