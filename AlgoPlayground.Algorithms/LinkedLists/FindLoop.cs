using AlgoPlayground.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPlayground.Algorithms.LinkedLists
{
    public class FindLoop<T>
    {
		private MyLinkedList<T> _list;

		public MyLinkedList<T> Find()
		{
			MyLinkedList<T> f = _list.Next;
			MyLinkedList<T> s = _list.Next.Next;

			while (f != s)
			{
				f = f.Next;
				s = s.Next.Next;
			}

			f = _list;
			while (f != s)
			{
				f = f.Next;
				s = s.Next;
			}

			return f;
		}

        public void SetList(MyLinkedList<T> list)
        {
			_list = list;
        }
    }
}
