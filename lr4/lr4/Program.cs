using System;
using SinglyLinkedList;

namespace lr4
{
    
    class Program
    {
        static void Main(string[] args)
        {





            var someList = new MyList<uint>(1, 3, 5, 4, 9, 7);
            Console.WriteLine($"Список: {someList}");
            Console.WriteLine($"Сумма: {someList.Sum()}");
            Console.WriteLine($"Минимум: {someList.Min()}");
            Console.WriteLine($"Максимум: {someList.Max()}");
            Console.WriteLine($"Cреднее значение: {someList.Avg()}");
            string b = "3334";
            string c = b.ShrinkToFit(2);
            Console.WriteLine($"Оригинальная строка = {b}; Усеченная до двух символов = {c}");



            var list1 = new MyList<uint>(1, 2, 4, 5, 6, 7, 7);
            var list2 = new MyList<uint>(8, 7, 5);


            Console.WriteLine(Environment.NewLine + $"{list1} < {list2}");
            _ = list1 < list2;
            Console.WriteLine(list1);

            Console.Write($"!{someList} = ");
            Console.WriteLine($"{!someList}");

            Console.Write($"{list1} + {list2} = ");
            Console.WriteLine($"{list1 + list2}");

            var list3 = new MyList<uint>(4, 5, 6, 3);
            Console.WriteLine($"{list3} == {list3} = {list3 == list3}");
            list3.Add(9);
            Console.WriteLine($"{list3} == {list2} = {list3 == list2}");





            Console.WriteLine($"Информация о создателе: {MyList<int>.OwnerInfo}");
            Console.WriteLine($"Дата создания: {MyList<int>.CreationDate}"); 


        }
    }
}
