using System;
using SinglyLinkedList;

namespace lr4
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList<uint>(1, 2, 4, 5, 6, 7, 7);
       //     list = !list;

            var list2 = new MyList<uint>(2, 4, 5);

            _ = list > list2;
            foreach (var el in list2)
                Console.WriteLine(el);


            var t = new MyList<int>(1, 3, 5, 4, 9, 7);
            int i = t.Sum();
            string b = "3334";
            string c = b.ShrinkToFit(2);
            Console.WriteLine($"{i} {c}");




            Console.WriteLine("Hello World!");
        }
    }
}
