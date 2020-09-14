using AlgoPlayground.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPlayground.Algorithms.LinkedLists
{
    public class Clone<T>
    {
        private MyLinkedListWithArbitraryPointer<T> _list;

        public void SetList(MyLinkedListWithArbitraryPointer<T> list)
        {
            _list = list;
        }

        public MyLinkedListWithArbitraryPointer<T> CloneListArbitrary()
        {
            MyLinkedListWithArbitraryPointer<T> cur = _list;
            MyLinkedListWithArbitraryPointer<T> cloned = null;
            MyLinkedListWithArbitraryPointer<T> clonedCur = null;
            Queue<MyLinkedListWithArbitraryPointer<T>> set = new Queue<MyLinkedListWithArbitraryPointer<T>>();

            while (cur != null)
            {
                MyLinkedListWithArbitraryPointer<T> tmp = new MyLinkedListWithArbitraryPointer<T>(cur.Data);

                if (cloned == null)
                {
                    cloned = tmp;
                    clonedCur = cloned;
                }
                else
                {
                    clonedCur.Next = tmp;
                    clonedCur = clonedCur.Next;
                }

                set.Enqueue(cur.Arbitrary);
                cur = cur.Next;
            }

            clonedCur = cloned;
            while (clonedCur != null)
            {
                clonedCur.Arbitrary = set.Dequeue();
                clonedCur = clonedCur.Next;
            }

            return cloned;
        }

        public MyLinkedListWithArbitraryPointer<T> CloneListArbitraryWithNoBuffer()
        {
            MyLinkedListWithArbitraryPointer<T> cur = _list;
            return null;
        }
    }
}
