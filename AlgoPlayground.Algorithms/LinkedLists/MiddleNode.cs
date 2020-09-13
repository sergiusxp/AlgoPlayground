using AlgoPlayground.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPlayground.Algorithms.LinkedLists
{
    public class MiddleNode<T>
    {
        private MyLinkedList<T> _list;

        public void SetList(MyLinkedList<T> list)
        {
            _list = list;
        }

        public MyLinkedList<T> DeleteMiddleNode(MyLinkedList<T> nodeToDelete)
        {
            if (nodeToDelete == null || nodeToDelete.Next == null)
            {
                return null;
            }

            MyLinkedList<T> next = nodeToDelete.Next;
            nodeToDelete.Data = next.Data;
            nodeToDelete.Next = next.Next;

            return _list;
        }
    }
}
