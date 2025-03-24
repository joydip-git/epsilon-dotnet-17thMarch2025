using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    //declare the delegate whose signature should match to that of the method that you want to invoke
    //delegate bool LogicDel(int a);
    delegate bool LogicDel<in TInput>(TInput a);

    //class LogicDel : MulticastDelegate//:Delegate:Object
    //{
    //    private object _target;
    //    private MethodInfo _method;

    //    public LogicDel(object target, MethodInfo method)
    //    {
    //        _target = target;
    //        _method = method;
    //    }

    //    public bool Invoke(int x)
    //    {
    //        _method.Invoke(_target, new object[] { x });
    //    }
    //}

    class Logic
    {
        public bool IsEven(int x) => x % 2 == 0;
        public static bool IsOdd(int x) => x % 2 != 0;
    }
}
