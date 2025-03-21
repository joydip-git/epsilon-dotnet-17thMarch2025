namespace Comparison_Sorting_OperatorOverloading
{
    class PersonComparer : IComparer<Person>
    {
        public int Choice { get; set; }

        public PersonComparer()
        {
            
        }
        public PersonComparer(int choice)
        {
            this.Choice = choice;
        }

        public int Compare(Person? x, Person? y)
        {
            if(x == null && y == null) return 0;
            if(y == null) return 1;

            int result = 0;
            switch (Choice)
            {
                case 1:
                    result = x.Id.CompareTo(y.Id);
                    break;

                case 2:
                    result = x.Name.CompareTo(y.Name);
                    break;

                default:
                    break;
            }
            return result;
        }
    }
}
