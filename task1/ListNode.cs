using System;

namespace task1
{
    public class ListNode
    {
        private int _value;
        private ListNode _next;

        public void Insert(int newValue)
        {
            ListNode curNode = this;

            while (curNode._next != null)
            {
                curNode = curNode._next;
            }

            curNode._next = new ListNode { _value = newValue };
        }

        public void GetNode()
        {
            ListNode node = _next;

            while (node != null)
            {
                Console.Write($"{node._value} ");
                node = node._next;
            }
        }
    }
}