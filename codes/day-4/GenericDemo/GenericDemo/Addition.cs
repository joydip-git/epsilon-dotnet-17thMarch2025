using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class Addition
    {
        //TInput -> Type Parameter
        //where -> used to declare constraint for type parameter
        public static void Add<TInput>(TInput a, TInput b) where TInput : struct
        {

        }
        public static void Add<TInput1, TInput2>(TInput1 a, TInput2 b)
        {

        }
    }
}
