namespace GenericCollectionsApp
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = new();
            numbers.Add(10); //0
            numbers.Add(20); //2
            numbers.Add(30); //3
            numbers.Add(40); //4

            Console.WriteLine($"Current length: {numbers.Count}");
            Console.WriteLine($"Current capacity: {numbers.Capacity}");

            numbers.Add(50); //5

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            //index value should be less than or equal to the current Count of the collection
            numbers.Insert(5, 60); //6
            numbers.Insert(1, 70); //1

            Console.WriteLine($"Current length: {numbers.Count}");
            Console.WriteLine($"Current capacity: {numbers.Capacity}");

            numbers.Remove(30);
            numbers.RemoveAt(2);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Sort();
            Console.WriteLine("/after sorting/n");

            numbers.GetEnumerator();
        }
    }
}
