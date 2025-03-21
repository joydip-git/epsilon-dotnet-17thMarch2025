using System.Runtime.CompilerServices;

namespace Comparison_Sorting_OperatorOverloading
{
    class Person : IComparable<Person>
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public override string ToString()
        {
            return $"Name={Name}, Id={Id}";
        }

        public int CompareTo(Person? other)
        {
            if (other == null) return 1;
            if (other == this) return 0;
            //if (this.Id == other.Id)
            //    return this.Name.CompareTo(other.Name);
            //else
            //    return this.Id.CompareTo(other.Id);
            return this.Id.CompareTo(other.Id);
        }        
        public static bool operator >(Person p1, Person p2)
        {
            return p1.Id.CompareTo(p2.Id) > 0;
            //return p1.Name > p2.Name;
        }
        public static bool operator <(Person p1, Person p2)
        {
            return p1.Id.CompareTo(p2.Id) < 0;
        }
    }
}
