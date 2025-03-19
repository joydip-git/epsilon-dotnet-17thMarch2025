using OutstandingPersonApp.Entities;

namespace OutstandingPersonApp
{
    internal class Program
    {
        static void Main()
        {
            int count = GetNumberOfRecords();
            Person[] people = new Person[count];
            SavePeople(people);
            PrintOutstandingPeople(people);
        }
        static int GetNumberOfRecords()
        {
            Console.Write("How many records? ");
            return int.Parse(Console.ReadLine() ?? "1");
        }
        static void PrintMenu()
        {
            Console.WriteLine("a. s for Student\nb. p for Professor");
        }
        static int GetChoiceFromUser()
        {
            Console.Write("\nEnter Choice[s/p]: ");
            return char.Parse(Console.ReadLine() ?? "s");
        }
        static Person? Create(int choice)
        {
            Person? person = null;

            Console.Write("enter name: ");
            string name = Console.ReadLine() ?? string.Empty;

            switch (choice)
            {
                case 's':
                    Console.Write("enter marks: ");
                    double marks = double.Parse(Console.ReadLine() ?? "0");
                    person = new Student(name, marks);
                    break;

                case 'p':
                    Console.Write("enter books published: ");
                    int booksCount = int.Parse(Console.ReadLine() ?? "0");
                    person = new Professor(name, booksCount);
                    break;

                default:
                    break;
            }
            return person;
        }
        static void SavePeople(Person[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                PrintMenu();
                int choice = GetChoiceFromUser();
                Person? person = Create(choice);
                if (person != null)
                {
                    people[i] = person;
                }
            }
        }
        static void PrintOutstandingPeople(Person[] people)
        {
            foreach (Person person in people)
            {
                if (person != null)
                {
                    bool isOutstanding = person.IsOutstanding();
                    if (isOutstanding)
                    {
                        //when you try to print a reference variable, ToString() method will be invoked
                        //Console.WriteLine(person.ToString());
                        Console.WriteLine(person);
                    }
                }
            }
        }
    }
}
