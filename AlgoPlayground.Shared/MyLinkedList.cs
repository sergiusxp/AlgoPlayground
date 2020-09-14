using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPlayground.Shared
{
    public class MyLinkedList<T>
    {
        public MyLinkedList(T _data)
        {
            Data = _data;
        }

        public T Data { get; set; }
        public MyLinkedList<T> Next { get; set; } = null;
    }

    public class MyLinkedListWithArbitraryPointer<T> : MyLinkedList<T>
    {
        public MyLinkedListWithArbitraryPointer(T _data) : base(_data)
        {
        }

        public MyLinkedListWithArbitraryPointer<T> Arbitrary { get; set; }
        public new MyLinkedListWithArbitraryPointer<T> Next { get; set; }
    }
}
