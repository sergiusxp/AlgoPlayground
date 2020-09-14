using AlgoPlayground.Shared;
using AlgoPlayground.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPlayground.Algorithms.LinkedLists
{
    public class Intersect
    {
        public void IntersectPoint()
        {
            MyLinkedList<int> head1 = new MyLinkedList<int>(1);
            head1.Next = new MyLinkedList<int>(2);
            head1.Next.Next = new MyLinkedList<int>(3);
            head1.Next.Next.Next = new MyLinkedList<int>(4);
            head1.Next.Next.Next.Next = new MyLinkedList<int>(5);
            head1.Next.Next.Next.Next.Next = new MyLinkedList<int>(6);
            head1.Next.Next.Next.Next.Next.Next = new MyLinkedList<int>(7);
            head1.Next.Next.Next.Next.Next.Next.Next = new MyLinkedList<int>(8);

            MyLinkedList<int> head2 = new MyLinkedList<int>(11);
            head2.Next = new MyLinkedList<int>(22);
            head2.Next.Next = new MyLinkedList<int>(33);
            head2.Next.Next.Next = new MyLinkedList<int>(44);
            head2.Next.Next.Next.Next = new MyLinkedList<int>(55);
            //head2.Next.Next.Next.Next.Next = head1.Next.Next.Next.Next;

            LinkedListHelper.PrintList(head1);
            LinkedListHelper.PrintList(head2);

            var node = FindIntersection(head1, head2);
            string str = "";

            if (node == null)
            {
                str = "These 2 lists do not have an intersection point.";
            }
            else
            {
                str = "The intersection point between lists is " + node.Data;
            }

            Console.WriteLine(str);
        }

        private MyLinkedList<int> FindIntersection(MyLinkedList<int> h1, MyLinkedList<int> h2)
        {
            // let's compare the two lists' last node
            MyLinkedList<int> last = null, cur1 = h1, cur2 = h2;
            int l1 = 0, l2 = 0, index = 0;

            while (cur1 != null)
            {
                l1++;
                if (cur1.Next == null)
                {
                    last = cur1;
                }
                cur1 = cur1.Next;
            }

            while (cur2 != null)
            {
                l2++;
                if (cur2.Next == null && cur2 != last)
                {
                    return null;
                }
                cur2 = cur2.Next;
            }

            int diff = Math.Abs(l1 - l2);

            cur1 = h1;
            cur2 = h2;

            while (index < diff)
            {
                index++;
                if (l1 > l2)
                {
                    cur1 = cur1.Next;
                }
                else
                {
                    cur2 = cur2.Next;
                }
            }

            while (cur1 != cur2)
            {
                cur1 = cur1.Next;
                cur2 = cur2.Next;
            }

            return cur1;
        }
    }
}
