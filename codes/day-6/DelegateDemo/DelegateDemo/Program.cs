namespace DelegateDemo
{
    //1. declare delegate
    delegate int CalDel(int a, int b);
    delegate TResult CalDel<in TInput, out TResult>(TInput a, TInput b);

    internal class Program
    {
        static void Main()
        {
            //2. create instance of delegate
            //CalDel addDel = new(new Calculation().Add);
            //CalDel subDel = new(Calculation.Subtract);
            CalDel<int, int> addDel = new(new Calculation().Add);
            CalDel<int, int> subDel = new(Calculation.Subtract);

            //invoke delegate to invoke method
            //int addResult = addDel(12, 13);
            //int subResult = subDel.Invoke(12, 3);

            //Console.WriteLine(addResult);
            //Console.WriteLine(subResult);

            //anonymous method and a delegate referring to that anonymous method
            //CalDel multiDel = public int Multiply(int a, int b)
            //CalDel multiDel = delegate (int a, int b)
            //{
            //    return a * b;
            //};
            CalDel<int, int> multiDel = delegate (int a, int b)
            {
                return a * b;
            };

            //expression body to write the anonymous method => Lambda Expression
            //CalDel divDel = (int m, int n) => n > 0 ? m / n : 0;
            //CalDel divDel = (m, n) => n > 0 ? m / n : 0;
            CalDel<int,int> divDel = (m, n) => n > 0 ? m / n : 0;

            Calculate(addDel, 12, 13);
            Calculate(subDel, 12, 3);
            Calculate(multiDel, 12, 3);
            Calculate(divDel, 12, 3);
        }
        //static void Calculate(CalDel calDel, int x, int y)
        static void Calculate<TInput,TResult>(CalDel<TInput, TResult> calDel, TInput x, TInput y)
        {
            Console.WriteLine(calDel(x, y));
        }
    }
}
