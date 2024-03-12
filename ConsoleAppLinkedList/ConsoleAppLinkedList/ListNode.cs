using System;

namespace ConsoleAppLinkedList1
{
    public class ListNode
    {
        public ListNode _next;
        public int _data;
        public ListNode(int data, ListNode next)
        {
            _data = data;
            _next = next;
        }
        public void addNode(ListNode head, int index, int element)
        {
            ListNode temp = head;
            ListNode input = new ListNode(element, null);
            if (index == 0)
            {
                input._next = head;
                head = input;
            }
            for (int i = 1; i <= index - 1; i++)
            {
                temp = temp._next;
            }
            input._next = temp._next;
            temp._next = input;
        }
        public void deleteNode(ref ListNode head, int index)
        {
            if (head == null)
            {
                return;
            }

            if (index == 0)
            {
                head = head._next;
                return;
            }

            ListNode current = head;
            for (int i = 1; i < index; i++)
            {
                current = current._next;
            }

            if (current._next != null)
            {
                current = current._next._next;
            }
        }

        public void deleteNodebyVal(ref ListNode head, int val)
        {
            if (head == null)
            {
                return;
            }
            ListNode current = head;
            while (current._next != null)
            {
                if (current._next._data == val)
                {
                    current._next = current._next._next;
                }
                else
                {
                    current = current._next;
                }
            }
        }
        public void reverseList(ref ListNode head)
        {
            if (head == null || head._next == null)
                return;

            ListNode current = head;
            ListNode prev = null;
            while (current != null)
            {
                ListNode next = current._next;
                current._next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        public bool PalindromeList(ref ListNode head)
        {
            if (head == null || head._next == null)
                return true;

            int count = 0;
            ListNode temp = head;
            while (temp != null)
            {
                count++;
                temp = temp._next;
            }
            int mid = 0;
            if (count % 2 == 0)
            {
                mid = (count - 1) / 2;
            }
            else
            {
                mid = count / 2;
            }
            temp = head;
            for (int i = 1; i <= mid; i++)
            {
                temp = temp._next;
            }

            ListNode head2 = temp._next;
            reverseList(ref head2);

            while (head2 != null && head != null)
            {
                if (head2._data != head._data)
                {
                    return false;
                }
                head = head._next;
                head2 = head2._next;
            }
            return true;
        }
    }

    public class LinkedListNode
    {
        public int val;
        public LinkedListNode next;
        public LinkedListNode(int val)
        {
            this.val = val;
        }

        static LinkedListNode head = null;

        public static void insert_node(int position, int value)
        {
            LinkedListNode newNode = new LinkedListNode(value);
            LinkedListNode temp = head;
            if (position == 1)
            {
                temp.next = newNode;
            }
            else
            {
                for (int i = 1; i < position - 1; i++)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;
            }
        }
        public static void delete_node(int position)
        {
            if (head == null)
                return;

            LinkedListNode temp = head;
            if (position == 1)
            {
                head = temp.next;
            }

            for (int i = 1; i < position - 1; i++)
            {
                temp = temp.next;
            }
            temp.next = temp.next.next;
        }
        public static void print_ll()
        {
            LinkedListNode temp = head;
            while (temp.next != null)
            {
                Console.Write($"{temp.val} ");
                temp = temp.next;
            }
            Console.Write($"{temp.val}");
        }
    }
}