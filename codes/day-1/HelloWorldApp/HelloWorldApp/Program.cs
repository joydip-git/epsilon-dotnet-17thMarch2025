namespace Sample
{
    internal class Program
    {
        //static void Main(string[] args)
        //static void Main()
        //static int Main(string[] args)
        //static int Main()

        static void Main()
        {
            //Console.Write("enter value: ");
            //string str = Console.ReadLine();
            //122 => "122"

            //convert the string value as returned by the ReadLine() method to any value type

            //1. using Parse method (which can convert ONLY string to something else)
            //int x = int.Parse(str); //=> "122" -> 122

            //2. using Convert class static methods (which can convert any value [if possible] to something else)
            //int x = Convert.ToInt32(str);

            string messageToPrint = "enter value: ";
            int value = AcceptValueFromUser(messageToPrint);
            Console.WriteLine("Hello, World! " + value);
            //Console.ReadLine();
        }
        static int AcceptValueFromUser(string message)
        {
            Console.Write(message);
            //string str = Console.ReadLine();
            //int valueFromUser = int.Parse(str);
            //int valueFromUser = int.Parse(Console.ReadLine());
            //return valueFromUser;
            return int.Parse(Console.ReadLine());
        }
    }
}
