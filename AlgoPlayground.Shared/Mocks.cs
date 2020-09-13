using AlgoPlayground.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPlayground.Shared
{
    public static class Mocks
    {
        public static MyLinkedList<int> GetIntList()
        {
            return new List<int>() { 2, 3, 3, 3, 4, 8, 3, 4, 6, 6, 9 }.ConvertListToLinkedList();
        }

        public static MyLinkedList<int> GetLoopIntList()
        {
            MyLinkedList<int> list = new List<int>() { 60, 42, 36, 2, 56, 25, 34, 33, 49, 33 }.ConvertListToLinkedList();
            MyLinkedList<int> cur = list;
            MyLinkedList<int> cyc = null;
            int index = 1, rand = 5;

            while (cur != null)
            {
                if (index++ == rand)
                {
                    cyc = cur;
                }

                if (cur.Next == null)
                {
                    cur.Next = cyc;
                    break;
                }

                cur = cur.Next;
            }

            return list;
        }
    }
}
