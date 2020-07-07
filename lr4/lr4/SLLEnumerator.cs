using System.Collections;

namespace SinglyLinkedList
{
    class SinglyLinkedListEnumerator<T> : IEnumerator
    {
        private Node<T> current;
        private Node<T> head;

        public SinglyLinkedListEnumerator(Node<T> node)
        {
            current = node;
            head = node;

        }
        public object Current { get { return current.Value; } }

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
        public void Reset()
        {
            current = head;
        }
    }
}
