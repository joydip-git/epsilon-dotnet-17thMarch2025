namespace OutstandingPersonApp.Entities
{
    public abstract class Person
    {
        string name = "";
        public Person()
        {

        }
        public Person(string name)
        {
            this.name = name;
        }
        public string Name
        {
            set => this.name = value;
            get => this.name;
        }
        public abstract bool IsOutstanding();
        public override string ToString()
        {
            //return this.GetType().Name
            return $"Name={name}";
        }
    }
}
