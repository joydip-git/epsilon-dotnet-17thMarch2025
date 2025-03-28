namespace NewFeatures
{
    internal class Program
    {
        //incorrect codes
        //var a;
        //static var Foo(var x) { }

        static void Main()
        {
            //KeyValuePairCollections();

            //x -> implcitly typed local variable
            //var is a keyword NOT a data type
            var x = 10;

            //implcitly typed array local variable
            var numbers = new[] { 1, 2, 4 };

            //anonymous type            
            var person = new { FirstName = "anil", LastName = "Kumar" };

            //the properties of anonymous type are readonly
            //they can be used to assign values only one time, not afterwards
            //person.FirstName = "";
            Console.WriteLine(person.GetType().Name);
        }
        static void KeyValuePairCollections()
        {
            Dictionary<int, string> dictionary = new();

            //if the key exists then exception will be thrown
            dictionary.Add(1, "epsilon");
            dictionary.Add(0, "hebbal");
            dictionary.Add(2, "bangalore");

            //if the key exists the value for the same will be updated
            //if the key does not exist then the key and value pair will be added
            dictionary[3] = "Karnataka";

            Console.WriteLine("\ndictionary items\n");
            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }

            SortedList<int, string> sortedList = new();

            //if the key exists then exception will be thrown
            sortedList.Add(1, "epsilon");
            sortedList.Add(0, "hebbal");
            sortedList.Add(2, "bangalore");

            //if the key exists the value for the same will be updated
            //if the key does not exist then the key and value pair will be added
            sortedList[3] = "Karnataka";

            Console.WriteLine("\nsorted list items\n");
            foreach (KeyValuePair<int, string> item in sortedList)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
        }
    }
}
