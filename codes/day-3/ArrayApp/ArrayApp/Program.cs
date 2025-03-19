namespace ArrayApp
{
    internal class Program
    {
        static void Main()
        {
            //Array numbers = new Array(int,3);
            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"enter value at numbers[{i}]: ");
                numbers[i] = int.Parse(Console.ReadLine() ?? "0");
            }
            Console.WriteLine("\nValues from array\n");
            int index = 0;
            foreach (int item in numbers)
            {
                Console.WriteLine($"Value at numbers[{index}]: {item}");
                index++;
            }
        }
    }
}
