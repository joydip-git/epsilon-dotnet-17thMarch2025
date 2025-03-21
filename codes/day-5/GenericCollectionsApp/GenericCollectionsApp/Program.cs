namespace GenericCollectionsApp
{
    internal class Program
    {
        static void Main()
        {
            HashSet<int> numbers = new HashSet<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(1);

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            HashSet<Person> people = new HashSet<Person>();
            Person anilPerson = new Person { Id = 1, Name = "anil" };
            Person sunilPerson = new Person { Id = 2, Name = "sunil" };
            Person another = new Person { Id = 1, Name = "anil" };
            //Person another = anilPerson;

            //anilPerson.Equals(another);

            people.Add(anilPerson); //anilPerson.GetHashCode()
            people.Add(sunilPerson); //sunilPerson.GetHashCode()
            people.Add(another); //another.GetHashCode()

            foreach (Person item in people)
            {
                Console.WriteLine(item);
            }
        }
    }
}
