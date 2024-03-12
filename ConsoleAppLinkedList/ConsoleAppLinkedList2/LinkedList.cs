namespace ConsoleAppLinkedList2
{
    public class LinkedList
    {
        public LinkedList next;
        public int val;
        public LinkedList(int val)
        {
            this.val = val;
        }
        public static bool isLinkedListCyclic(LinkedList head)
        {
            LinkedList temp = head;
            LinkedList slow = temp;
            LinkedList fast = temp;
            while (slow != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    return true;
                }
            }
            return false;
        }
        private static int sizeLinkedList(LinkedList head)
        {
            LinkedList temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
        public static int getCyclicPointer(LinkedList head)
        {
            LinkedList temp = head;
            LinkedList slow = temp;
            LinkedList fast = temp;
            while (slow != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    slow = temp;
                    while ((slow != null) && (slow != null))
                    {
                        if (slow == fast)
                        {
                            return slow.val;
                        }
                        slow = slow.next;
                        fast = fast.next;
                    }
                }
            }
            return -1;
        }

        public static int getMiddleElement(LinkedList head)
        {
            if (head == null)
            {
                return -1;
            }
            if (head.next == null)
            {
                return head.val;
            }

            LinkedList temp = head;
            int size = sizeLinkedList(head);

            int mid = (size + 1) / 2;

            while (mid > 0)
            {
                temp = temp.next;
                mid = mid - 1;
            }
            return temp.val;
        }
        public static LinkedList breakCyclic(LinkedList head)
        {
            LinkedList temp = head;
            LinkedList slow = temp;
            LinkedList fast = temp;
            while (slow != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    slow = temp;
                    while ((slow != null) && (slow != null))
                    {
                        if (slow.next == fast.next)
                        {
                            fast.next = null;
                            break;
                        }
                        slow = slow.next;
                        fast = fast.next;
                    }
                }
            }
            return head;
        }
    }
}
