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
}
