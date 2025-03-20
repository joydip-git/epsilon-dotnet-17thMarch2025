namespace GenericDemo
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            //Addition.Add<int>(12, 13);
            //Addition.Add<int,int>(13, 14);
            //Addition.Add<float,double>(14, 15);

            MyCollection<int> intCollection = new MyCollection<int>();
            intCollection.Add(12);
            intCollection.Add(13);
            intCollection.Add(14);
            intCollection.Add(15);
            intCollection.Add(16);
            intCollection.Add(17);
            Console.WriteLine(intCollection.Count);
            Console.WriteLine(intCollection.Capacity);

            //foreach (int item in intCollection)
            //{
            //    Console.WriteLine(item);
            //}

            IEnumerator<int> list = intCollection.GetEnumerator();
            while (list.MoveNext())
            {
                Console.WriteLine(list.Current);
            }
        }
    }
}
