using System;

namespace ConsoleAppLinkedList2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll1 = new LinkedList(1);
            LinkedList ll2 = new LinkedList(2);
            LinkedList ll3 = new LinkedList(3);
            LinkedList ll4 = new LinkedList(4);
            LinkedList ll5 = new LinkedList(5);
            LinkedList ll6 = new LinkedList(6);
            LinkedList ll7 = new LinkedList(7);
            LinkedList ll8 = new LinkedList(8);
            LinkedList ll9 = new LinkedList(9);
            ll1.next = ll2;
            ll2.next = ll3;
            ll3.next = ll4;
            ll4.next = ll5;
            ll5.next = ll6;
            ll6.next = ll7;
            ll7.next = ll8;
            ll8.next = ll9;
            ll9.next = ll4;

            //Console.WriteLine(LinkedList.isLinkedListCyclic(ll1));
            //Console.WriteLine(LinkedList.getCyclicPointer(ll1));

            //Console.WriteLine(LinkedList.getMiddleElement(ll1));

            Console.WriteLine(LinkedList.breakCyclic(ll1));

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
