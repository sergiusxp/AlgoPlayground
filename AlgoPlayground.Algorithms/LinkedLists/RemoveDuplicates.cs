using AlgoPlayground.Shared;
using AlgoPlayground.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPlayground.Algorithms.LinkedLists
{
    public class RemoveDuplicates<T>
    {
        private MyLinkedList<T> _list;

        public void SetList(MyLinkedList<T> list)
        {
            _list = list;
        }

        public MyLinkedList<T> RemoveDup()
        {
            HashSet<T> found = new HashSet<T>();
            MyLinkedList<T> cur = _list;
            MyLinkedList<T> prev = null;

            while (cur != null)
            {
                if (!found.Contains(cur.Data))
                {
                    found.Add(cur.Data);
                    prev = cur;
                }
                else
                {
                    prev.Next = cur.Next;
                }

                cur = cur.Next;
            }

            return _list;
        }

        public MyLinkedList<T> RemoveDupNoBufferAllowed()
        {
            MyLinkedList<T> p1 = _list;

            while (p1 != null)
            {
                MyLinkedList<T> runner = p1;
                while (runner.Next != null)
                {
                    if (EqualityComparer<T>.Default.Equals(runner.Next.Data, p1.Data))
                    {
                        runner.Next = runner.Next.Next;
                    }
                    else
                    {
                        runner = runner.Next;
                    }
                }
                p1 = p1.Next;
            }

            return _list;
        }
    }
}
