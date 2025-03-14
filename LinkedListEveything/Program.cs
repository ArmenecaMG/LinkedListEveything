using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEveything
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>(new int[] { 42, 7, 19, 3, 88, 56 });
            var sortedList = new List<int>(numbers);
            sortedList.Sort();
            LinkedList<int> sortedLinkedList = new LinkedList<int>(sortedList);
            Console.WriteLine("Сортиран списък:");
            PrintLinkedList(sortedLinkedList);
            int search1 = 19;
            int search2 = 100;
            Console.WriteLine(SearchNumber(sortedLinkedList, search1) ?
            $"Числото {search1} е в списъка!" : $"Числото {search1} не е в списъка!");
            Console.WriteLine(SearchNumber(sortedLinkedList, search2) ?
            $"Числото {search2} е в списъка!" : $"Числото {search2} не е в списъка!");
            LinkedList<int> reversedList = ReverseLinkedList(sortedLinkedList);
            Console.WriteLine("Обърнат списък:");
            PrintLinkedList(reversedList);
        }
        static void PrintLinkedList(LinkedList<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " -> ");
            }
            Console.WriteLine("null");
        }
        static bool SearchNumber(LinkedList<int> list, int num)
        {
            return list.Contains(num);
        }
        static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
        {
            LinkedList<int> reversedList = new LinkedList<int>();
            foreach (var item in list)
            {
                reversedList.AddFirst(item);
            }
            return reversedList;
        }
    }
    
}
