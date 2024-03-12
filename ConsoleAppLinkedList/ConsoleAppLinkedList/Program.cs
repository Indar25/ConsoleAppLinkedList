using ConsoleAppLinkedList1;
using System;

namespace ConsoleAppLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1, null);
            head._next = new ListNode(2, null);
            head._next._next = new ListNode(3, null);
            head._next._next._next = new ListNode(4, null);
            head._next._next._next._next = new ListNode(5, null);

            //head.addNode(head, 2, 10);
            //   head.deleteNode(ref head, 0);
            //head.deleteNodebyVal(ref head, 4);

            //head.reverseList(ref head);

            ListNode head1 = new ListNode(1, null);
            head1._next = new ListNode(2, null);
            head1._next._next = new ListNode(3, null);
            head1._next._next._next = new ListNode(2, null);
            head1._next._next._next._next = new ListNode(1, null);
            Console.WriteLine(head1.PalindromeList(ref head1));
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
