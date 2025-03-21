using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    //declare the delegate whose signature should match to that of the method that you want to invoke
    delegate bool LogicDel(int a);

    class Logic
    {
        public bool IsEven(int x) => x % 2 == 0;
        public static bool IsOdd(int x) => x % 2 != 0;
    }
}
