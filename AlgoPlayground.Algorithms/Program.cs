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
            var actions = new Dictionary<string, List<string>>()
            {
                {
                    "Linked List",
                    new List<string>()
                    {
                        "Remove duplicates",
                        "Find loop",
                        "Find the kth to last element",
                        "Delete middle node",
                        "Clone linked lists with arbitrary pointer but without buffer",
                        "Clone linked lists with arbitrary pointer",
                        "Intersection point"
                    }
                }
            };

            int myChose = -1;
            while (myChose != 0)
            {
                Console.Clear();
                Console.WriteLine("MENU\n");
                int index = 1;
                foreach (var action in actions)
                {
                    Console.WriteLine("=== " + action.Key);
                    foreach (var l in action.Value)
                    {
                        Console.WriteLine(" " + index++ + ") " + l);
                    }
                }

                Console.WriteLine("0) To exit\n\nWhat you chose? ");
                string c = Console.ReadLine();
                if (!Int32.TryParse(c, out myChose)) continue;

                switch(myChose)
                {
                    case 1:
                        #region LL - Remove Duplicates
                        var rd = new RemoveDuplicates<int>();
                        var listM = Mocks.GetIntList();
                        Console.WriteLine("List before");
                        LinkedListHelper.PrintList<int>(listM);

                        rd.SetList(listM); // 2 3 4 8 6 9
                        var list = rd.RemoveDup();

                        rd.SetList(Mocks.GetIntList()); // 2 3 4 8 6 9
                        var listNoBuffer = rd.RemoveDupNoBufferAllowed();

                        LinkedListHelper.PrintList<int>(listNoBuffer);

                        #endregion
                        break;

                    case 2:
                        #region LL - Find Loop
                        var find = new FindLoop<int>();
                        var listL = Mocks.GetLoopIntList();
                        find.SetList(listL);
                        var loop = find.Find();

                        Console.WriteLine("Loop found: " + loop.Data);

                        #endregion
                        break;

                    case 3:
                        #region LL - Finding the Kth to last Element
                        var kth = new KthToLast<int>();
                        kth.SetList(LinkedListHelper.GetRandomLinkedListInt(8));
                        kth.Kth(1); // 1 means the last element
                        kth.Kth(2); // 2 means the last but one
                        #endregion
                        break;

                    case 4:
                        #region LL - Delete middle node
                        var del = new MiddleNode<int>();
                        var ll = new List<int>() { 2, 5, 9, 2, 4 }.ConvertListToLinkedList();
                        del.SetList(ll);

                        Console.WriteLine("List before");
                        LinkedListHelper.PrintList<int>(ll);

                        var listWithoutMiddle = del.DeleteMiddleNode(ll.Next.Next); // we delete 9

                        Console.WriteLine("List after");
                        LinkedListHelper.PrintList<int>(listWithoutMiddle);

                        #endregion
                        break;

                    case 5:
                        #region LL - Clone linked lists with arbitrary pointer but without buffer
                        var arbList = Mocks.GetListArbitraryPointers();
                        var clone = new Clone<int>();
                        clone.SetList(arbList);

                        Console.WriteLine("List before");
                        LinkedListHelper.PrintList<int>(arbList);
                        var cloned1 = clone.CloneListArbitraryWithNoBuffer();
                        Console.WriteLine("List after");
                        LinkedListHelper.PrintList<int>(cloned1);
                        #endregion
                        break;

                    case 6:
                        #region LL - Clone linked lists with arbitrary pointer
                        var arbList2 = Mocks.GetListArbitraryPointers();
                        var clone2 = new Clone<int>();
                        clone2.SetList(arbList2);

                        Console.WriteLine("List before");
                        LinkedListHelper.PrintList<int>(arbList2);
                        var cloned11 = clone2.CloneListArbitrary();
                        Console.WriteLine("List after");
                        LinkedListHelper.PrintList<int>(cloned11);

                        #endregion
                        break;

                    case 7:
                        #region LL - Intersection point
                        new Intersect().IntersectPoint();
                        #endregion
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
