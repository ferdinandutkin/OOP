using System;
using SinglyLinkedList;

namespace lr4
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList<int>(1, 2, 4, 5, 6, 7, 7);
            list[2] = 2;
            foreach (var el in list)
                Console.WriteLine(el);
            Console.WriteLine("Hello World!");
        }
    }
}
