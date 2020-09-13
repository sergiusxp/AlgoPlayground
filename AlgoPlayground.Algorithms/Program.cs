using AlgoPlayground.Algorithms.LinkedLists;
using AlgoPlayground.Shared;
using AlgoPlayground.Shared.Helpers;
using System;
using System.Collections.Generic;

namespace AlgoPlayground.Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LL -Remove Duplicates
            var rd = new RemoveDuplicates<int>();
            
            rd.SetList(Mocks.GetIntList()); // 2 3 4 8 6 9
            var list = rd.RemoveDup();

            rd.SetList(Mocks.GetIntList()); // 2 3 4 8 6 9
            var listNoBuffer = rd.RemoveDupNoBufferAllowed();
            #endregion

            #region LL - Find Loop
            var find = new FindLoop<int>();
            find.SetList(Mocks.GetLoopIntList());
            var loop = find.Find();
            #endregion

            #region LL - Finding the Kth Element
            var kth = new KthToLast<int>();
            kth.SetList(LinkedListHelper.GetRandomLinkedListInt(8));
            kth.Kth(1); // 1 means the last element
            kth.Kth(2); // 2 means the last but one
            #endregion

            Console.ReadLine();
        }
    }
}
