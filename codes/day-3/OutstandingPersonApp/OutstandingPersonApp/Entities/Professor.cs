namespace OutstandingPersonApp.Entities
{
    public class Professor : Person
    {
        int booksPublished;
        public Professor()
        {

        }
        public Professor(string name, int booksPublished) : base(name)
        {
            this.booksPublished = booksPublished;
        }

        public int BooksPublished
        {
            get => booksPublished;
            set => booksPublished = value;
        }

        public override bool IsOutstanding() => booksPublished >= 5;

        public override string ToString()
        {
            return $"{base.ToString()}, BooksPublished={booksPublished}";
        }
    }
}
