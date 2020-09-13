using AlgoPlayground.Shared;
using AlgoPlayground.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPlayground.Algorithms.LinkedLists
{
    public class KthToLast<T>
    {
        private MyLinkedList<T> _list;

        public void SetList(MyLinkedList<T> myLinkedList)
        {
            _list = myLinkedList;
        }

        public void Kth(int k)
        {
            MyLinkedList<T> cur = _list;
            Print(cur, k);
        }

        private int Print(MyLinkedList<T> cur, int k)
        {
            if (cur == null)
            {
                return 0;
            }

            int index = Print(cur.Next, k) + 1;

            if (index == k)
            {
                LinkedListHelper.PrintList(_list);
                Console.WriteLine("The " + k + "th element is: " + cur.Data);
            }

            return index;
        }
    }
}
