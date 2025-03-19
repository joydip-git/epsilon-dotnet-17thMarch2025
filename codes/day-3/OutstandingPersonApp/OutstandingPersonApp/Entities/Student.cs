namespace OutstandingPersonApp.Entities
{
    public class Student : Person
    {
        double marks;
        public Student()
        {

        }
        public Student(string name, double marks) : base(name)
        {
            this.marks = marks;
        }

        public double Marks
        {
            get => marks;
            set => marks = value;
        }

        public override bool IsOutstanding() => marks >= 85 ? true : false;

        public override string ToString()
        {
            return $"{base.ToString()}, Marks={marks}";
        }
    }
}
