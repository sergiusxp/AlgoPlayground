using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace AlgoPlayground.Shared
{
    public class MyTree<T>
    {
        public T Data { get; set; }
        public MyTree<T> Left { get; set; } = null;
        public MyTree<T> Right { get; set; } = null;
    }
}
