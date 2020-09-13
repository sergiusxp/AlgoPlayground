using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AlgoPlayground.Shared.Helpers
{
    public static class LinkedListHelper
    {
        public static MyLinkedList<T> ConvertListToLinkedList<T>(this List<T> listToConvert)
        {
            MyLinkedList<T> list = null, cur = null;

            foreach (var val in listToConvert)
            {
                if (list == null)
                {
                    list = new MyLinkedList<T>(val);
                    cur = list;
                    continue;
                }

                MyLinkedList<T> tmp = new MyLinkedList<T>(val);
                cur.Next = tmp;
                cur = cur.Next;
            }

            return list;
        }

        public static void PrintList<T>(MyLinkedList<T> list)
        {
            MyLinkedList<T> cur = list;
            Console.Write("Linked List values:\n");
            while (cur != null)
            {
                Console.Write(cur.Data + ", ");
                cur = cur.Next;
            }
            Console.Write("\n");
        }

        public static MyLinkedList<int> GetRandomLinkedListInt(int numberOfElements)
        {
            int index = 0;
            MyLinkedList<int> myLinkedList = null;
            MyLinkedList<int> cur = myLinkedList;

            while (numberOfElements > index++)
            {
                if (myLinkedList == null)
                {
                    myLinkedList = new MyLinkedList<int>(new Random().Next(1, 100));
                    cur = myLinkedList;
                }
                else
                {
                    MyLinkedList<int> tmp = new MyLinkedList<int>(new Random().Next(1, 100));
                    cur.Next = tmp;
                    cur = cur.Next;
                }
            }

            return myLinkedList;
        }
    }
}
