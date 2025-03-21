namespace LinqDemo
{
    internal class Program
    {
        static List<int> Filter(List<int> list, LogicDel logicDel)
        {
            List<int> result = [];
            foreach (int item in list)
            {                
                if (logicDel(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<int> list = [1, 2, 3, 4, 5];
            Logic logic = new();
            LogicDel evenDel = new LogicDel(logic.IsEven);
            LogicDel oddDel = new LogicDel(Logic.IsOdd);
            //Filter(list, evenDel);
            Filter(list, oddDel);



            //bool status = evenDel(14);
            //Console.WriteLine(status);
        }
    }
}
