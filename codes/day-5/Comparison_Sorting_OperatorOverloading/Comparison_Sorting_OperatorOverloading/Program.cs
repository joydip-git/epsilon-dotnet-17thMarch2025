namespace Comparison_Sorting_OperatorOverloading
{
    internal class Program
    {
        static void Main()
        {
            //collection initializer
            //List<int> list = new List<int> { 5, 1, 3, 2, 4 };

            List<int> list = [5, 1, 2, 4, 3];
            list.Sort();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    for (int j = i + 1; j < list.Count; j++)
            //    {
            //        if (list[i] > list[j
            //        if (list[i].CompareTo(list[j])>0)
            //        {
            //            int temp = list[i];
            //            list[i] = list[j];
            //            list[j] = temp;
            //        }
            //    }
            //}

            List<Person> people =
                [
                    new Person{ Name="anil",Id=2},
                    new Person{ Name="sunil",Id=1},
                    new Person{ Name="joy",Id=3}
                ];
            //people.Sort();
            //for (int i = 0; i < people.Count; i++)
            //{
            //    for (int j = i + 1; j < people.Count; j++)
            //    {
            //        if (people[i] < people[j])
            //        if (people[i].CompareTo(person[j])>0)
            //        {
            //            Person temp = people[i];
            //            people[i] = people[j];
            //            people[j] = temp;
            //        }
            //    }
            //}
            int choice = 2;
            //PersonComparer pc = new PersonComparer(choice);
            PersonComparer pc = new PersonComparer { Choice = choice };
            people.Sort(pc);
            //for (int i = 0; i < people.Count; i++)
            //{
            //    for (int j = i + 1; j < people.Count; j++)
            //    {
            //        if (pc.Compare(people[i],people[j])>0)
            //        {
            //            Person temp = people[i];
            //            people[i] = people[j];
            //            people[j] = temp;
            //        }
            //    }
            //}
            foreach (Person item in people)
            {
                Console.WriteLine(item);
            }
        }
    }
}
