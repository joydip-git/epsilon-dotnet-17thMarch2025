namespace LinqDemo
{
    internal class Program
    {
        //static List<int> Filter(List<int> input, LogicDel logicDel)
        //{
        //    List<int> result = [];
        //    foreach (int item in input)
        //    {
        //        bool isTrue = logicDel(item);
        //        if (isTrue)
        //        {
        //            result.Add(item);
        //        }
        //    }
        //    return result;
        //}
        static List<TInput> Filter<TInput>(List<TInput> input, LogicDel<TInput> logicDel)
        {
            List<TInput> result = [];
            foreach (TInput item in input)
            {
                bool isTrue = logicDel(item);
                if (isTrue)
                {
                    result.Add(item);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<int> list = [1, 2, 3, 4, 5];

            Comparison<int> compareNumbers = (a, b) => a - b;
            list.Sort(compareNumbers);

            Func<int, bool> greaterLogic = x => x > 3;
            var filteredValues = list.Where(greaterLogic);

            Action<int> printDel = (x) => Console.WriteLine(x);
            filteredValues.ToList().ForEach(printDel);

            //2.a. store reference of an instance method in the delegate instance
            Logic logic = new();
            LogicDel<int> evenDel = new(logic.IsEven);

            //2.b. store reference of a static method in the delegate instance
            LogicDel<int> oddDel = new(Logic.IsOdd);
            var result = Filter(list, evenDel);

            //var keyword => used to declare local variable ONLY. this type of variable decalred with var keyword is known as implcitly typed variable
            //var result = Filter(list, oddDel);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }



            //bool status = evenDel(14);
            //Console.WriteLine(status);
        }
    }
}
