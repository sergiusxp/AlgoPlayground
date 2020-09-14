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

        public static MyLinkedListWithArbitraryPointer<int> GetListArbitraryPointers()
        {
            var lwap1 = new MyLinkedListWithArbitraryPointer<int>(1);
            var lwap2 = new MyLinkedListWithArbitraryPointer<int>(2);
            var lwap3 = new MyLinkedListWithArbitraryPointer<int>(3);
            var lwap4 = new MyLinkedListWithArbitraryPointer<int>(4);
            lwap1.Next = lwap2;
            lwap2.Next = lwap3;
            lwap3.Next = lwap4;
            lwap1.Arbitrary = lwap4;
            lwap2.Arbitrary = lwap3;
            lwap4.Arbitrary = lwap3;
            lwap3.Arbitrary = lwap1;

            return lwap1;
        }
    }
}
