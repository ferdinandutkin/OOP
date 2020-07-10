using System.Collections;
using System.Collections.Generic;


//приеиньте писать энумератор чтобы узнать о yield
/*
namespace SinglyLinkedList
{
    class SinglyLinkedListEnumerator<T> : IEnumerator<T>
    {
        private Node<T> current;
        private Node<T> head;

        public SinglyLinkedListEnumerator(Node<T> node)
        {
            current = node;
            head = node;
        }
        public T Current => current.Value;
        object IEnumerator.Current => Current;

        void System.IDisposable.Dispose() { }


        public bool MoveNext()
        {
            if (current.Next != null)
            {
                current = current.Next;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset() => current = head;
    }
}
*/